using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpCodingTest.Service.Abstract
{
    public interface IFileMonitor
    {
        Task StartMonitoring(string folderPath, DataGridView dataGrid, int second);
        void StopMonitoring();
    }

}
