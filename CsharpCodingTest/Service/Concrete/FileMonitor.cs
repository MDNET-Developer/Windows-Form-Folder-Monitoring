using CsharpCodingTest.Service.Abstract;
using System;
using System.Data;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpCodingTest.Service.Concrete
{
    public class FileMonitor : IFileMonitor
    {

        private bool _isMonitoring = false;
        private CancellationTokenSource _cancellationTokenSource;
        private Task _monitoringTask;

        
        public async Task StartMonitoring(string folderPath, DataGridView dataGrid, int second)
        {

            _cancellationTokenSource = new CancellationTokenSource(); 
            var cancellationToken = _cancellationTokenSource.Token;

            _isMonitoring = true;

            _monitoringTask = Task.Run(async () =>
            {
                while (_isMonitoring)
                {
                    try
                    {
                       
                        cancellationToken.ThrowIfCancellationRequested();
                        var files = Directory.GetFiles(folderPath);
                        dataGrid.Invoke(new Action(() =>
                        {
                            dataGrid.DataSource = null;
                        }));

                        DataTable dt = new DataTable();
                        dt.Columns.Add("File Name");
                        dt.Columns.Add("Extension");
                        dt.Columns.Add("Full Name");

                        foreach (var file in files)
                        {
                            FileInfo fileInfo = new FileInfo(file);
                            DataRow dr = dt.NewRow();
                            dr[0] = fileInfo.Name;
                            dr[1] = fileInfo.Extension;
                            dr[2] = fileInfo.FullName;
                            dt.Rows.Add(dr);
                        }

                        dataGrid.Invoke(new Action(() =>
                        {
                            dataGrid.DataSource = dt;
                        }));

                        await Task.Delay(second * 1000);
                    }
                    catch (OperationCanceledException)
                    {
                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xəta baş verdi: {ex.Message}");
                    }
                }
            }, cancellationToken);
        }


        public void StopMonitoring()
        {
            _isMonitoring = false;

            if (_monitoringTask != null && !_monitoringTask.IsCompleted)
            {
                _cancellationTokenSource?.Cancel();
                _monitoringTask.Wait(); 
            }
        }
    }
}
