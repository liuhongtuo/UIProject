using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.File.UtilHelper
{
    /// <summary>
    /// 文件系统工具类
    /// </summary>
    public class FileUtil
    {
        // TODO. 
        private const string ADSSuffix = "_ads";

        #region ctors
        /// <summary>
        /// Private constructor. No instances of the class can be created.
        /// </summary>
        private FileUtil() { }
        #endregion

        #region Public Static Methods

        public static void CopyDirectory(string srcDirPath, string destDirPath, bool overwrite = true)
        {
            try
            {
                List<FileInfo> files = new List<FileInfo>();
                GetDirectoryAllFiles(srcDirPath, ref files);

                foreach (var file in files)
                {
                    string newFilePath = file.FullName.Replace(srcDirPath, destDirPath);
                    string newDirPath = Path.GetDirectoryName(newFilePath);
                    if (!Directory.Exists(newDirPath))
                        Directory.CreateDirectory(newDirPath);

                    System.IO.File.Copy(file.FullName, newFilePath, overwrite);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void GetDirectoryAllFiles(string dirPath, ref List<FileInfo> files, string suffix = null)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(dirPath);
                FileSystemInfo[] infos = dir.GetFileSystemInfos();
                foreach (var info in infos)
                {
                    // 1. If is directory, recursion.
                    if (info is DirectoryInfo)
                    {
                        GetDirectoryAllFiles(info.FullName, ref files, suffix);
                    }
                    // 2. Else if suffix is NOT WithSpace or NULL, just get the file for the suffix.
                    else if (!string.IsNullOrWhiteSpace(suffix))
                    {
                        var file = info as FileInfo;
                        if (suffix.Equals(file.Extension))
                            files.Add(file);
                    }
                    // 3. Else get all files. 
                    else
                    {
                        files.Add(info as FileInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteDirectory(string dirPath)
        {
            if (!Directory.Exists(dirPath)) return;

            try
            {
                Directory.Delete(dirPath, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CeateDirectory(string dirPath)
        {
            if (Directory.Exists(dirPath)) return;

            try
            {
                Directory.CreateDirectory(dirPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteFile(string filePath)
        {
            if (!System.IO.File.Exists(filePath)) return;

            try
            {
                System.IO.File.Delete(filePath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Writes bytes array to file.
        /// If the target file already exists, it is overwritten. limit 2GB
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="contents"></param>
        public static void WriteByBytes(string filePath, byte[] contents)
        {
            try
            {
                PrepareCreateFile(filePath);

                // If the target file already exists, it is overwritten. limit 2GB
                System.IO.File.WriteAllBytes(filePath, contents);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Read file to bytes array. limit 2GB
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static byte[] ReadByBytes(string filePath)
        {
            try
            {
                // limit 2GB
                return System.IO.File.ReadAllBytes(filePath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Writes object to file by binary formatter.
        /// If the target file already exists, it is overwritten.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="obj"></param>
        public static void WriteByBinary<T>(string path, T obj) where T : class
        {
            try
            {
                PrepareCreateFile(path);
                using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(fs, obj);
                    fs.Flush();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Read file to (T)object by binary formatter.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T ReadByBinary<T>(string path) where T : class
        {
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    return formatter.Deserialize(fs) as T;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Writes object to file with MD5 Encrypt.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="obj"></param>
        //public static void WriteWhitMD5<T>(string path, T obj) where T : class
        //{
        //    try
        //    {
        //        PrepareCreateFile(path);
        //        using (var ms = new MemoryStream())
        //        {
        //            var formatter = new BinaryFormatter();
        //            formatter.Serialize(ms, obj);

        //            using (var securityHelper = new CryptographyHelper())
        //            {
        //                var encryptBytes = securityHelper.Encrypt(ms.ToArray());
        //                WriteByBytes(path, encryptBytes);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        /// <summary>
        /// Read file to (T)object with MD5 Decrypt.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        //public static T ReadWhitMD5<T>(string path) where T : class
        //{
        //    try
        //    {
        //        var encryptBytes = ReadByBytes(path);
        //        using (var securityHelper = new CryptographyHelper())
        //        {
        //            var bytes = securityHelper.Decrypt(encryptBytes);

        //            using (var ms = new MemoryStream(bytes))
        //            {
        //                var formatter = new BinaryFormatter();
        //                return formatter.Deserialize(ms) as T;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        /// <summary>
        /// Sets additional attributes to file by alertnate data streams.
        /// </summary>
        /// <typeparam name="T">Additional attributes obejct type.</typeparam>
        /// <param name="filePath">Origin file whole path.</param>
        /// <param name="obj">Additional attributes object.</param>
        public static void WriteADSFile<T>(string filePath, T data)
        {
            try
            {
                string stream = GenerateADSStreamName(filePath);
                ADSFileUtil.Write<T>(filePath, stream, data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets file additional attributes by alternate data streams.
        /// </summary>
        /// <typeparam name="T">Additional attributes obejct type.</typeparam>
        /// <param name="originFilePath">Origin file whole path.</param>
        /// <returns></returns>
        public static T ReadADSFile<T>(string filePath)
        {
            try
            {
                string stream = GenerateADSStreamName(filePath);
                var data = ADSFileUtil.Read<T>(filePath, stream);
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static void PrepareCreateFile(string filePath)
        {
            string dirPth = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(dirPth))
                Directory.CreateDirectory(dirPth);

            if (System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);
        }

        static string GenerateADSStreamName(string filePath)
        {
            var fileName = Path.GetFileNameWithoutExtension(filePath);
            string stream = $"{fileName}{ADSSuffix}";
            return stream;
        }

        #endregion
    }
}
