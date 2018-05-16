using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    public interface IFileAccess
    {
        Task<FileData> GetFileStreamFormPath(string Path);
    }
    public class FileData
    {
        public byte[] DataArray { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }
}
