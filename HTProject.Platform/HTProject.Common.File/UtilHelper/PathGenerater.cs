using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.File.UtilHelper
{
    public class PathGenerater
    {
        private const string WaferResult = "WaferResult";
        private const string RE = "RE";
        private const string LO = "LO";
        private const string DateFormate = "yyyyMMdd_HHmmss";
        private const string AlignmentDirectoryName = "AL";
        private const string InspectionDirectoryName = "OTF";
        private const string ReviewDirectoryName = "Review";
        private const string MarkMeasureDirectoryName = "Measurement";
        private const string CDMeasureDirectoryName = "CDMeasure";
        private const string InspectionTestDirectoryName = "Inspection";
        private const string VertControlDirectoryName = "VertControl";
        private const string DataName = "Data";
        private const string DefectImageName = "DefectImage";
        private const string LOTID = "REVALIDATE";
        private const int SLOTID = 1;

        /// <summary>
        /// Recipe Edit
        /// </summary>
        /// <param name="pathType"></param>
        /// <param name="recipeName"></param>
        /// <returns></returns>
        public static string RESavePath(PathType pathType, string recipeName, DateTime? inspectionDateTime = null, string disk = null)
        {
            // e.g. WaferResult/RE/{recipe_name}
            string path = Path.Combine(WaferResult, RE, recipeName);
            if (!string.IsNullOrWhiteSpace(disk) && Directory.Exists(disk))
                path = Path.Combine(disk, path);
            inspectionDateTime = inspectionDateTime ?? DateTime.Now;
            switch (pathType)
            {
                case PathType.IO:
                    // e.g. WaferResult/RE/{recipe_name}/AL
                    path = Path.Combine(path, AlignmentDirectoryName);
                    break;
                case PathType.Data:
                    // e.g. WaferResult/RE/{recipe_name}/{date_time}/OTF
                    //path = Path.Combine(path, InspectionTestDirectoryName, inspectionDateTime.Value.ToString(DateFormate), DefectImageName, InspectionDirectoryName);//DefectImage文件夹需求
                    path = Path.Combine(path, InspectionTestDirectoryName, inspectionDateTime.Value.ToString(DateFormate), DataName, InspectionDirectoryName);//Data需求
                    break;
            }

            return path;
        }

        /// <summary>
        /// Lot
        /// </summary>
        /// <param name="pathType"></param>
        /// <param name="lotName"></param>
        /// <param name="substrateName"></param>
        /// <returns></returns>
        public static string LOSavePath(PathType pathType, string lotRcipeName, string lotName, string substrateName, string disk = null)
        {
            // e.g. WaferResult/LO/{lot_name}/{wafer_name}
            string path = Path.Combine(WaferResult, LO, lotName, lotRcipeName, substrateName);
            if (!string.IsNullOrWhiteSpace(disk) && Directory.Exists(disk))
                path = Path.Combine(disk, path);

            switch (pathType)
            {
                case PathType.IO:
                    // e.g. WaferResult/LO/{lot_name}/{wafer_name}/AL
                    path = Path.Combine(path, AlignmentDirectoryName);
                    break;
                case PathType.Data:
                    // e.g. WaferResult/LO/{lot_name}/{wafer_name}/OTF
                    //path = Path.Combine(path, InspectionTestDirectoryName, DefectImageName, InspectionDirectoryName);//DefectImage文件夹需求
                    path = Path.Combine(path, InspectionTestDirectoryName, DataName, InspectionDirectoryName);//Data需求
                    break;
                default:
                    break;
            }

            return path;
        }


        public static string GetUnloadFilePath(PathType pathType, string recipeName, string lotID, int slotID, DateTime? testTime = null, string disk = null)
        {
            if (string.IsNullOrWhiteSpace(lotID)) lotID = LOTID;
            if (slotID <= 0) slotID = SLOTID;
            string path = Path.Combine(recipeName, lotID, slotID.ToString("D2"));
            if (!string.IsNullOrWhiteSpace(disk) && Directory.Exists(disk))
                path = Path.Combine(disk, path);
            testTime = testTime ?? DateTime.Now;

            switch (pathType)
            {
                case PathType.IO:
                    // e.g. 盘符:\RecipeName\LotID\SlotID\Inspection\Inspection_time
                    path = Path.Combine(path, InspectionTestDirectoryName, testTime.Value.ToString("yyyyMMddHHmmss"));
                    break;
                case PathType.MCFC:
                    // e.g. 盘符:\RecipeName\LotID\SlotID\Measurement\Mark_time
                    path = Path.Combine(path, MarkMeasureDirectoryName, testTime.Value.ToString("yyyyMMddHHmmss"));
                    break;
                case PathType.Data:
                    // e.g. 盘符:\RecipeName\LotID\SlotID\CDMeasure\CD_time
                    path = Path.Combine(path, CDMeasureDirectoryName, testTime.Value.ToString("yyyyMMddHHmmss"));
                    break;
                default:
                    break;
            }
            return path;
        }

        public static void DeleteFile(string filePath, bool isDeleteSelf = false, bool isDeleteSubdirectories = true, bool isDeleteFiles = true)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(filePath);
                if (directory.Exists)
                {
                    if (isDeleteSelf)
                    {
                        directory.Delete(true);
                        return;
                    }

                    if (isDeleteSubdirectories)
                    {
                        DirectoryInfo[] childs = directory.GetDirectories();
                        foreach (var child in childs)
                        {
                            child.Delete(true);
                        }
                    }

                    if (isDeleteFiles)
                    {
                        FileInfo[] files = directory.GetFiles();
                        foreach (var file in files)
                        {
                            file.Delete();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public enum PathType
    {
        Station,
        IO,
        MCFC,
        Warning,
        Data
    }
}
