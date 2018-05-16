using App6.UWP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

[assembly: Xamarin.Forms.Dependency(typeof(FileAccessImplementation))]

namespace App6.UWP
{
    public class FileAccessImplementation : IFileAccess
    {
        public async Task<FileData> GetFileStreamFormPath(string Path)
        {
            var file = await StorageFile.GetFileFromPathAsync(Path);

            byte[] fileBytes = null;
            if (file == null) return null;
            using (var stream = await file.OpenReadAsync())
            {
                fileBytes = new byte[stream.Size];
                using (var reader = new DataReader(stream))
                {
                    await reader.LoadAsync((uint)stream.Size);
                    reader.ReadBytes(fileBytes);
                }
            }

            var FileData = new FileData()
            {
                FileName = file.Name,
                FilePath = file.Path,
                DataArray = fileBytes
            };
            return FileData;
        }
    }
}
