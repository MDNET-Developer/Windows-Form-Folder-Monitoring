using CsharpCodingTest.Service.Abstract;
using CsharpCodingTest.Service.Concrete;
using System;

namespace CsharpCodingTest.Service.Factory
{
    public class FileLoaderFactory
    {
        public static IFileLoader CreateFileLoader(FileType fileType)
        {
            switch (fileType)
            {
                case FileType.Xml:
                    return new XmlFileLoader();
                case FileType.Csv:
                    return new CsvFileLoader();
                case FileType.Txt:
                    return new TxtFileLoader();
                default:
                    throw new NotSupportedException("File type is not supported.");
            }
        }
    }
}
