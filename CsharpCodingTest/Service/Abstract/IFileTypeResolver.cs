using CsharpCodingTest.Service.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodingTest.Service.Abstract
{
    public interface IFileTypeResolver
    {
        Task<FileType> GetFileTypeFromExtensionAsync(string fileExtension);
    }
}
