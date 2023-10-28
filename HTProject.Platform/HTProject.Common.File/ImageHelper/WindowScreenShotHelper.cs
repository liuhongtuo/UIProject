using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;

namespace HTProject.Common.File.ImageHelper
{
    class WindowScreenShotHelper
    {
        private const string LOTID = "REVALIDATE";
        private const int SLOTID = 1;
        private const string OPERATIONID = "SMEE";

        #region win32API
        /// <summary>
        /// 在窗口原来的位置以原来的尺寸激活和显示窗口
        /// </summary>
        private const int SW_SHOWNORMAL = 1;
        /// <summary>
        /// 光栅操作值
        /// </summary>
        private const int SRCCOPY = 0x00CC0020;
        /// <summary>
        /// 不调整窗口位置
        /// </summary>
        private const uint SWP_NOMOVE = 0x0002;
        /// <summary>
        /// 不调整窗口大小
        /// </summary>
        private const uint SWP_NOSIZE = 0x0002;
        /// <summary>
        /// 窗体置顶
        /// </summary>
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        /// <summary>
        /// 取消窗体置顶
        /// </summary>
        private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rectangle rect);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateCompatibleDC(IntPtr hdc);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);

        [DllImport("gdi32.dll")]
        private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        [DllImport("gdi32.dll")]
        private static extern int DeleteDC(IntPtr hdc);

        /// <summary>
        /// 指定窗口截图
        /// </summary>
        /// <param name="hdcDest">目标设备的句柄</param>
        /// <param name="nXDest">目标对象的左上角X坐标</param>
        /// <param name="nYDest">目标对象的左上角Y坐标</param>
        /// <param name="nWidth">目标对象的矩形宽度</param>
        /// <param name="nHeight">目标对象的矩形高度</param>
        /// <param name="hdcSrc">DC源设备的句柄</param>
        /// <param name="nXSrc">源对象的左上角X坐标</param>
        /// <param name="nYSrc">源对象的左上角X坐标</param>
        /// <param name="dwRop">光栅的操作值</param>
        /// <returns></returns>
        [DllImport("gdi32.dll")]
        private static extern int BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, UInt32 dwRop);
        #endregion

        public static Bitmap GetShotCutImage(IntPtr hWnd)
        {
            var windowhdc = GetWindowDC(hWnd);
            Rectangle windowRect = new Rectangle();
            GetWindowRect(hWnd, ref windowRect);
            int width = Math.Abs(windowRect.Width - windowRect.X);
            int height = Math.Abs(windowRect.Height - windowRect.Y);
            var hbitmap = CreateCompatibleBitmap(windowhdc, width, height);
            var hdc = CreateCompatibleDC(windowhdc);
            SelectObject(hdc, hbitmap);
            PrintWindow(hWnd, hdc, 0);
            var bmp = System.Drawing.Image.FromHbitmap(hbitmap);
            DeleteDC(windowhdc);
            DeleteDC(hdc);
            return bmp;
        }

        public static Bitmap GetShotCutImageWithArea(IntPtr hWnd, int offsetX = 0, int offsetY = 0)
        {
            var hdcSrc = GetWindowDC(hWnd);
            Rectangle windowRect = new Rectangle();
            GetWindowRect(hWnd, ref windowRect);
            int width = Math.Abs(windowRect.Width - windowRect.X);
            int height = Math.Abs(windowRect.Height - windowRect.Y);
            var hbitmap = CreateCompatibleBitmap(hdcSrc, width, height);
            var hdcDest = CreateCompatibleDC(hdcSrc);
            var hOld = SelectObject(hdcDest, hbitmap);
            BitBlt(hdcDest, offsetX, offsetY, width, height, hdcSrc, 0, 0, SRCCOPY);
            SelectObject(hdcDest, hOld);
            var bmp = System.Drawing.Image.FromHbitmap(hbitmap);
            DeleteDC(hdcSrc);
            DeleteDC(hdcDest);
            return bmp;
        }

        public static Bitmap GetShotCutImageWithFullScreen(System.Drawing.Point srcUpLeftPoint, System.Drawing.Point destUpLeftPoint, int width = 1920, int height = 1080)
        {
            var bitmap = new Bitmap(width, height);
            using (Graphics gra = Graphics.FromImage(bitmap))
            {
                gra.CopyFromScreen(srcUpLeftPoint, destUpLeftPoint, new System.Drawing.Size(width, height));
            }
            return bitmap;
        }

        public static Bitmap GetShotCutImageWithWindowName(string windowName)
        {
            var winIntPtr = FindWindow(null, windowName);
            //API截图需要窗体处于显示状态，因此当窗体为最小化状态时显示窗体
            var minimizedWin = IsIconic(winIntPtr);
            if (minimizedWin)
            {
                ShowWindow(winIntPtr);
                //SetWindowTop(winIntPtr);
            }
            var bitmap = GetShotCutImage(winIntPtr);
            return bitmap;
        }

        /// <summary>
        /// 使用窗口句柄获取窗口截图
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        public static BitmapImage GetWindowShotImage(IntPtr hWnd)
        {
            var image = GetShotCutImage(hWnd);
            var bitmapImage = ConvertToBitmapImage(image);
            return bitmapImage;
        }

        /// <summary>
        /// 使用窗口句柄获取窗口区域截图
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="offsetX">窗口区域X向偏移</param>
        /// <param name="offsetY">窗口区域Y向偏移</param>
        /// <returns></returns>
        public static BitmapImage GetWindowShotImageWithArea(IntPtr hWnd, int offsetX = 0, int offsetY = 0)
        {
            var image = GetShotCutImageWithArea(hWnd, offsetX, offsetY);
            var bitmapImage = ConvertToBitmapImage(image);
            return bitmapImage;
        }

        /// <summary>
        /// 获取全屏幕区域截图
        /// </summary>
        /// <param name="srcUpLeftPoint">源屏幕左上角点</param>
        /// <param name="destUpLeftPoint">截图左上角点</param>
        /// <param name="width">图像区域宽度</param>
        /// <param name="height">图像区域高度</param>
        /// <returns></returns>
        public static BitmapImage GetWindowShotImageWithFullScreen(System.Drawing.Point srcUpLeftPoint, System.Drawing.Point destUpLeftPoint, int width = 1920, int height = 1080)
        {
            var image = GetShotCutImageWithFullScreen(srcUpLeftPoint, destUpLeftPoint);
            var bitmapImage = ConvertToBitmapImage(image);
            return bitmapImage;
        }

        /// <summary>
        /// 使用窗口句柄获取指定区域截图
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="width">指定区域宽度</param>
        /// <param name="height">指定区域高度</param>
        /// <param name="offsetX">指定区域相对于原窗口X向偏移</param>
        /// <param name="offsetY">指定区域相对于原窗口Y向偏移</param>
        /// <param name="savePath">存图路径</param>
        /// <returns></returns>
        public static BitmapImage GetWindowShotImageWithSpecifiedArea(IntPtr hWnd, int width = 1920, int height = 1080, int offsetX = 0, int offsetY = 0, string savePath = "")
        {
            var image = GetShotCutImage(hWnd);
            var specifiedImage = ConvertToBitmapWithSpecifiedArea(image, width, height, offsetX, offsetY, savePath);
            var bitmapImage = ConvertToBitmapImage(specifiedImage);
            return bitmapImage;
        }

        /// <summary>
        /// 使用窗口名称获取指定区域截图
        /// </summary>
        /// <param name="name">窗口名称</param>
        /// <param name="width">指定区域宽度</param>
        /// <param name="height">指定区域高度</param>
        /// <param name="offsetX">指定区域相对于原窗口X向偏移</param>
        /// <param name="offsetY">指定区域相对于原窗口Y向偏移</param>
        /// <param name="savePath">存图路径</param>
        /// <returns></returns>
        public static BitmapImage GetWindowShotImageWithSpecifiedAreaByName(string name, int width = 1920, int height = 1080, int offsetX = 0, int offsetY = 0, string savePath = "")
        {
            var image = GetShotCutImageWithWindowName(name);
            var specifiedImage = ConvertToBitmapWithSpecifiedArea(image, width, height, offsetX, offsetY, savePath);
            var bitmapImage = ConvertToBitmapImage(specifiedImage);
            return bitmapImage;
        }

        /// <summary>
        /// 使用窗口名称获取指定区域截图
        /// </summary>
        /// <param name="isLot">是否为量产模式</param>
        /// <param name="savePath">存图路径</param>
        /// <param name="name">窗口名称</param>
        /// <returns></returns>
        public static BitmapImage GetWindowShotImageWithSpecifiedAreaByName(bool isLot, string savePath = "", string name = "SOI525")
        {
            var image = GetShotCutImageWithWindowName(name);
            Bitmap specifiedImage = null;
            //量产界面和处方界面Map图位置不同，需要分开截取
            if (isLot)
            {
                //量产界面
                specifiedImage = ConvertToBitmapWithSpecifiedArea(image, 560, 580, 0, 175, savePath);
            }
            else
            {
                //处方界面
                specifiedImage = ConvertToBitmapWithSpecifiedArea(image, 950, 675, 225, 285, savePath);
            }
            var bitmapImage = ConvertToBitmapImage(specifiedImage);
            return bitmapImage;
        }

        public static Bitmap ConvertToBitmapWithSpecifiedArea(Bitmap bitmapSrc, int width, int height, int offsetX, int offsetY, string savePath)
        {
            try
            {
                Bitmap bitmap = new Bitmap(width, height);
                Bitmap newImage;
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.DrawImage(bitmapSrc, 0, 0, new Rectangle(offsetX, offsetY, width, height), GraphicsUnit.Pixel);
                    newImage = System.Drawing.Image.FromHbitmap(bitmap.GetHbitmap());
                    if (!string.IsNullOrWhiteSpace(savePath))
                    {
                        FileInfo file = new FileInfo(savePath);
                        if (!file.Directory.Exists)
                        {
                            file.Directory.Create();
                        }
                        bitmap.Save(savePath, ImageFormat.Jpeg);
                    }
                }
                bitmap.Dispose();
                return newImage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static BitmapImage ConvertToBitmapImage(Bitmap bitmap)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, ImageFormat.Bmp);
                stream.Position = 0;
                BitmapImage rtn = new BitmapImage();
                rtn.BeginInit();
                rtn.CacheOption = BitmapCacheOption.OnLoad;
                rtn.StreamSource = stream;
                rtn.EndInit();
                rtn.Freeze();
                bitmap.Dispose();
                return rtn;
            }
        }

        public static void SetWindowTop(IntPtr hWnd)
        {
            SetWindowPos(hWnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
        }

        public static void ShowWindow(IntPtr hWnd)
        {
            ShowWindow(hWnd, SW_SHOWNORMAL);
            System.Threading.Thread.Sleep(1500);
        }

        public static string GetMapFileName(string lotID, int slotID, string operationID, string testTime)
        {
            if (string.IsNullOrWhiteSpace(lotID)) lotID = LOTID;
            if (slotID <= 0) slotID = SLOTID;
            if (string.IsNullOrWhiteSpace(operationID)) operationID = OPERATIONID;
            if (string.IsNullOrWhiteSpace(testTime)) testTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            return $"{lotID}_{slotID.ToString("D2")}_{operationID}_{testTime}.jpg";
        }
    }
}
