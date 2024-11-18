using CsharpCodingTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodingTest.Service.Abstract
{
    public interface IFileLoader
    {
        Task<List<Trade>> LoadAsync(string filePath);
    }
}
