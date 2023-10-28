using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CommonLog = Common.Logging;
using System.Threading.Tasks;
using Common.Logging;

namespace HTProject.Common.File.FileHelper
{
    public static class CsvHelper
    {
        private const string DiskFilePath = @"Data\Logs\Modules";
        private const string MEMSName = "MEMS";
        private const string MEMSInstanceName = "MEMS01";
        private const string DateFormate = "yyyyMMdd_HHmmss";

        private static ILog logger = LogManager.GetLogger(typeof(CsvHelper));
        public static void SaveCsvFile<T>(string path, List<T> lists, string title = null)
        {
            try
            {
                FileInfo info = new FileInfo(path);
                if (!info.Directory.Exists)
                {
                    info.Directory.Create();
                }

                var sb = new StringBuilder();
                if (title != null)
                {
                    sb.AppendLine(title);
                }

                var typeInfo = typeof(T);
                var headers = new List<object>();
                var properties = typeInfo.GetProperties();
                var dictData = new Dictionary<string, object>();
                foreach (var item in properties)
                {
                    string name = item.Name;
                    headers.Add(name);
                    dictData.Add(name, null);
                }
                sb.AppendLine(string.Join(",", headers));

                foreach (var obj in lists)
                {
                    foreach (var item in properties)
                    {
                        string name = item.Name;
                        if (dictData.Keys.Contains(name))
                        {
                            dictData[name] = item.GetValue(obj);
                        }
                    }
                    sb.AppendLine(string.Join(",", dictData.Values));
                }
                System.IO.File.WriteAllText(path, sb.ToString(), Encoding.Default);
            }
            catch (Exception ex)
            {
                logger.Error($"Exception:{ex.Message}");
            }
        }

        public static void GenerateFilePathAndSave<T>(ModuleType moduleType, List<T> lists, string fileName, string diskPath)
        {
            // e.g. @"D:\SMEE\Logs\Modules\ModuleName\InstanceName\FileName\DateTime\FileName.csv";
            if (string.IsNullOrWhiteSpace(fileName)) return;
            if (string.IsNullOrWhiteSpace(diskPath) || !Directory.Exists(diskPath)) return;

            var diskRootPath = Path.GetPathRoot(diskPath);
            var path = Path.Combine(diskRootPath, DiskFilePath);
            var fileNamePath = Path.GetFileNameWithoutExtension(fileName);
            var dateTimeFile = DateTime.Now.ToString(DateFormate);
            switch (moduleType)
            {
                case ModuleType.MEMS:
                    // e.g. MEMS/MEMS01/fileName/DateFormate/fileName
                    path = Path.Combine(path, MEMSName, MEMSInstanceName, fileNamePath, dateTimeFile, fileName);
                    break;
                case ModuleType.DMMS:
                case ModuleType.SCMS:
                default:
                    break;
            }
            SaveCsvFile(path, lists);
        }
    }

    public enum ModuleType
    {
        MEMS,
        DMMS,
        SCMS,
    }
}
