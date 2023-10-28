using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.File.UtilHelper
{
    /// <summary>
    /// A class with static methods for reading and writing to "hidden" streams in a normal file.
    /// This only works on NTFS drives, not FAT or FAT32 drives.
    /// </summary>
    public class ADSFileUtil
    {
        private const int DefaultBufferSize = 4096;

        #region Win32 API Defines
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern uint GetFileSize(IntPtr handle,
            IntPtr size);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern IntPtr CreateFile(string fileName,
            uint desiredAccess,
            uint shareMode,
            IntPtr securityAttributes,
            uint creationDisposition,
            uint flagsAndAttributes,
            IntPtr templateFile);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern uint ReadFile(IntPtr handle,
            byte[] buffer,
            uint byteToRead,
            ref uint bytesRead,
            IntPtr overlapped);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool WriteFile(IntPtr handle,
            byte[] buffer,
            uint numberOfBytesToWrite,
            ref uint numberOfBytesWritten,
            IntPtr overlapped);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool CloseHandle(IntPtr handle);
        #endregion

        #region ctors
        /// <summary>
        /// Private constructor. No instances of the class can be created.
        /// </summary>
        private ADSFileUtil() { }
        #endregion

        #region Public Static Methods

        /// <summary>
        /// The static method to call when data must be written to a stream.
        /// </summary>
        /// <typeparam name="T">Data type of T.</typeparam>
        /// <param name="file">The fully qualified name of the file with the stream into which the data wil be written.</param>
        /// <param name="stream">The name of the stream within the normal file to write the data.</param>
        /// <param name="data">The data type of T to embed in the stream in the file.</param>
        public static void Write<T>(string file, string stream, T data)
        {
            try
            {
                IntPtr writeHandle = CreateFile(
                    $"{file}:{stream}",
                    DesiredAccess.GENERIC_WRITE,
                    ShareMode.FILE_SHARE_WRITE,
                    IntPtr.Zero,
                    CreationDisposition.CREATE_ALWAYS,
                    FlagsAndAttributes.FILE_FLAG_OVERLAPPED,
                    IntPtr.Zero);

                if (writeHandle.ToInt64() < 0)
                    throw new StreamNotFoundException(file, stream);

                using (var fs = new FileStream(new SafeFileHandle(writeHandle, true), FileAccess.Write, DefaultBufferSize, true))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(fs, data);
                    fs.Flush();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method called when an alternate data stream must be read from.
        /// </summary>
        /// <typeparam name="T">Data type of T.</typeparam>
        /// <param name="file">The fully qualified name of the file from which the ADS data will be read.</param>
        /// <param name="stream">The name of the stream within the "normal" file from which to read.</param>
        /// <returns>The contents of the file as a type T.</returns>
        public static T Read<T>(string file, string stream)
        {
            try
            {
                IntPtr readHandle = CreateFile(
                  $"{file}:{stream}",
                  DesiredAccess.GENERIC_READ,
                  ShareMode.FILE_SHARE_READ,
                  IntPtr.Zero,
                  CreationDisposition.OPEN_EXISTING,
                  FlagsAndAttributes.FILE_FLAG_OVERLAPPED,
                  IntPtr.Zero);

                if (readHandle.ToInt64() < 0)
                    throw new StreamNotFoundException(file, stream);

                using (var fs = new FileStream(new SafeFileHandle(readHandle, true), FileAccess.Read, DefaultBufferSize, true))
                {
                    var formatter = new BinaryFormatter();
                    return (T)formatter.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// The static method to call when data must be written to a stream.
        /// </summary>
        /// <param name="file">The fully qualified name of the file with the stream into which the data wil be written.</param>
        /// <param name="stream">The name of the stream within the normal file to write the data.</param>
        /// <param name="data">The byte array to embed in the stream in the file.</param>
        /// <returns></returns>
        public static uint Write(string file, string stream, byte[] data)
        {
            IntPtr writeHandle = CreateFile(
                $"{file}:{stream}",
                DesiredAccess.GENERIC_WRITE,
                ShareMode.FILE_SHARE_WRITE,
                IntPtr.Zero,
                CreationDisposition.CREATE_ALWAYS,
                FlagsAndAttributes.FILE_FLAG_OVERLAPPED,
                IntPtr.Zero);

            if (writeHandle.ToInt64() < 0)
                throw new StreamNotFoundException(file, stream);

            uint number = 0;
            bool isSuccessfully = WriteFile(writeHandle, data, (uint)data.Length, ref number, IntPtr.Zero);
            CloseHandle(writeHandle);

            // Throw an exception if the data wasn't written successfully.
            if (!isSuccessfully)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            return number;
        }

        /// <summary>
        /// Method called when an alternate data stream must be read from.
        /// </summary>
        /// <param name="file">The fully qualified name of the file from which the ADS data will be read.</param>
        /// <param name="stream">The name of the stream within the "normal" file from which to read.</param>
        /// <returns>The contents of the file as a byte arrary. It will always return at least a zero-length array,
        /// even if the file does not exist.
        /// </returns>
        public static byte[] Read(string file, string stream)
        {
            IntPtr readHandle = CreateFile(
                 $"{file}:{stream}",
                 DesiredAccess.GENERIC_READ,
                 ShareMode.FILE_SHARE_READ,
                 IntPtr.Zero,
                 CreationDisposition.OPEN_EXISTING,
                 FlagsAndAttributes.FILE_FLAG_OVERLAPPED,
                 IntPtr.Zero);

            if (readHandle.ToInt64() < 0)
                throw new StreamNotFoundException(file, stream);

            uint size = GetFileSize(readHandle, IntPtr.Zero);
            byte[] buffer = new byte[size];
            uint read = uint.MinValue;

            uint result = ReadFile(readHandle, buffer, size, ref read, IntPtr.Zero);
            CloseHandle(readHandle);
            return buffer;
        }

        #endregion
    }

    #region Win32 Constans
    static class DesiredAccess
    {
        public const uint GENERIC_READ = 0x80000000;
        public const uint GENERIC_WRITE = 0x40000000;
        public const uint GENERIC_EXECUTE = 0x20000000;
        public const uint GENERIC_ALL = 0x10000000;
    }

    static class ShareMode
    {
        public const uint FILE_SHARE_READ = 0x00000001;
        public const uint FILE_SHARE_WRITE = 0x00000002;
        public const uint FILE_SHARE_DELETE = 0x00000004;
    }

    static class CreationDisposition
    {
        public const uint CREATE_NEW = 1;
        public const uint CREATE_ALWAYS = 2;
        public const uint OPEN_EXISTING = 3;
        public const uint OPEN_ALWAYS = 4;
        public const uint TRUNCATE_EXISTING = 5;
    }

    static class FlagsAndAttributes
    {
        public const uint FILE_FLAG_WRITE_THROUGH = 0x80000000;
        public const uint FILE_FLAG_OVERLAPPED = 0x40000000;
        public const uint FILE_FLAG_NO_BUFFERING = 0x20000000;
        public const uint FILE_FLAG_RANDOM_ACCESS = 0x10000000;
        public const uint FILE_FLAG_SEQUENTIAL_SCAN = 0x08000000;
        public const uint FILE_FLAG_DELETE_ON_CLOSE = 0x04000000;
        public const uint FILE_FLAG_BACKUP_SEMANTICS = 0x02000000;
        public const uint FILE_FLAG_POSIX_SEMANTICS = 0x01000000;
        public const uint FILE_FLAG_OPEN_REPARSE_POINT = 0x00200000;
        public const uint FILE_FLAG_OPEN_NO_RECALL = 0x00100000;
        public const uint FILE_FLAG_FIRST_PIPE_INSTANCE = 0x00080000;
    }
    #endregion

    #region Exceptions
    /// <summary>
    /// Class to allow stream read operations to raise specific errors if the stream is not found in the file.
    /// </summary>
    public class StreamNotFoundException : FileNotFoundException
    {
        #region Private Members
        private string _stream = string.Empty;
        #endregion

        #region ctors
        /// <summary>
        /// Constructor called with the name of the file and stream which was unsuccessfully opened.
        /// </summary>
        /// <param name="file">Fully qualified name of the file in which the stream was supposed to reside.</param>
        /// <param name="stream">Stream within the file to open.</param>
        public StreamNotFoundException(string file, string stream) : base(string.Empty, file)
        {
            _stream = stream;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Read-only property to allow the user to query the exception to determine the name of the stream that couldn't be found.
        /// </summary>
        public string Stream { get { return _stream; } }
        #endregion

        #region Overridden Properties
        /// <summary>
        /// Overridden Message property to return a concise string describing the exception.
        /// </summary>
        public override string Message
        {
            get
            {
                return $"Stream {_stream} not found in {base.FileName}.";
            }
        }
        #endregion
    }
    #endregion
}
