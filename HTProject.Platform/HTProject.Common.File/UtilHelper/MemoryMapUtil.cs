using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HTProject.Common.File.UtilHelper
{
    /// <summary>
    /// 内存映射文件工具类（使用共享内存进行进程间大数据访问）
    /// </summary>
    public static class MemoryMapUtil
    {
        private const string FileDirectory = @"C:\Program Files (x86)\SMEE\Modules\DMMS\Configuration";
        private const string FileSubfix = ".data";

        #region Properties

        private static string Name;
        private static string FilePath;
        private static string MutexName;

        #endregion

        #region Public methods

        public static void Create<T>(MemoryMapKey key, T data) where T : class
        {
            if (!data.GetType().IsSerializable)
                throw new ArgumentException("Type is not serializable.", nameof(data));

            InitMemoryMap(key);

            var objBytes = Serialize(data);
            using (var mutex = GetMutex(MutexName))
            {
                PrepareMemoryMapFile(FileDirectory, FilePath);

                using (var memoryMappedFile = MemoryMappedFile.CreateFromFile(FilePath, FileMode.CreateNew, Name, objBytes.Length))
                {
                    using (var memoryMappedViewStream = memoryMappedFile.CreateViewStream())
                    {
                        memoryMappedViewStream.Write(objBytes, 0, objBytes.Length);
                    }
                }

                mutex.ReleaseMutex();
            }

        }

        public static T Load<T>(MemoryMapKey key) where T : class
        {
            InitMemoryMap(key);
            try
            {
                using (var memoryMappedFile = MemoryMappedFile.CreateFromFile(FilePath, FileMode.Open, Name))
                {
                    T obj;
                    using (var mutex = GetMutex(MutexName))
                    {
                        using (var memoryMappedViewStream = memoryMappedFile.CreateViewStream())
                        {
                            var binaryReader = new BinaryReader(memoryMappedViewStream);
                            obj = Deserialize<T>(ReadAll(binaryReader));
                        }

                        mutex.ReleaseMutex();
                    }
                    return obj;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void Delete(MemoryMapKey key)
        {
            InitMemoryMap(key);
            using (var mutex = GetMutex(MutexName))
            {
                FileUtil.DeleteFile(FilePath);
                mutex.ReleaseMutex();
            }
        }

        public static void DeleteAll()
        {
            FileUtil.DeleteDirectory(FileDirectory);
        }

        #endregion

        #region Private methods

        private static void InitMemoryMap(MemoryMapKey key)
        {
            Name = $"SMEE-DMMS-{key}";
            MutexName = $"SMEE-DMMS-{key}-Mutex";
            FilePath = Path.Combine(FileDirectory, Name + FileSubfix);
        }

        private static Mutex GetMutex(string mutexName)
        {
            Mutex mutex;
            if (Mutex.TryOpenExisting(MutexName, out mutex))
            {
                mutex.WaitOne();
            }
            else
            {
                bool mutexCreated;
                mutex = new Mutex(true, MutexName, out mutexCreated);

                if (!mutexCreated)
                    mutex.WaitOne();
            }
            return mutex;
        }

        private static void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            if (name.IndexOfAny(Path.GetInvalidPathChars()) > 0)
                throw new ArgumentException($"{name} contains invalid characters.");
        }

        private static void PrepareMemoryMapFile(string fileDirectory, string filePath)
        {
            if (!Directory.Exists(fileDirectory))
                Directory.CreateDirectory(fileDirectory);

            if (System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);
        }

        private static byte[] Serialize<T>(T obj) where T : class
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        private static byte[] ReadAll(BinaryReader reader)
        {
            const int bufferSize = 4096;
            using (var ms = new MemoryStream())
            {
                var buffer = new byte[bufferSize];
                int count;

                while ((count = reader.Read(buffer, 0, buffer.Length)) != 0)
                {
                    ms.Write(buffer, 0, count);
                }

                return ms.ToArray();
            }
        }

        private static T Deserialize<T>(byte[] data) where T : class
        {
            using (var ms = new MemoryStream(data))
            {
                var formatter = new BinaryFormatter();
                return formatter.Deserialize(ms) as T;
            }
        }

        #endregion

    }

    public enum MemoryMapKey
    {
        Station,
        Recipe,
    }
}
