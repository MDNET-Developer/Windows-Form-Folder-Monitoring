using CsharpCodingTest.Service.Abstract;
using CsharpCodingTest.Service.Factory;
using System;
using System.Threading.Tasks;

namespace CsharpCodingTest.Service.Concrete
{
    public class FileTypeResolver : IFileTypeResolver
    {
        public async Task<FileType> GetFileTypeFromExtensionAsync(string fileExtension)
        {
           return await Task.Run(() =>
            {
                fileExtension = fileExtension.ToLower();

                switch (fileExtension)
                {
                    case ".xml":
                        return FileType.Xml;
                    case ".csv":
                        return FileType.Csv;
                    case ".txt":
                        return FileType.Txt;
                    default:
                        throw new NotSupportedException("Unsupported file extension.");
                }
            });
        }
    }
}
