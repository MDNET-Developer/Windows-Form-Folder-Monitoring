using CsharpCodingTest.Extension;
using CsharpCodingTest.Service.Abstract;
using CsharpCodingTest.Service.Concrete;
using CsharpCodingTest.Service.Factory;
using System;
using System.Windows.Forms;

namespace CsharpCodingTest
{
    public partial class FrmMainFolderMonitor : Form
    {
        IFileMonitor fileMonitor = new FileMonitor();
        IFileTypeResolver fileTypeResolver = new FileTypeResolver();
        public int Time { get; set; } = 5;
        public string FileExtension { get; set; }
        public string FileFullName { get; set; }

        public FrmMainFolderMonitor()
        {
            InitializeComponent();
        }

        private void FrmMainFolderMonitor_Load(object sender, EventArgs e)
        {
            string fileTypesString = string.Join(", ", Enum.GetNames(typeof(FileType)));
            lblFileSupported.Text = $"File Supported: {fileTypesString}";
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            using (FrmSetting frmSetting = new FrmSetting())
            {
                frmSetting.Second = Time;
                frmSetting.ShowDialog();
                Time = frmSetting.Second;
                if (txtFilePath.Text != String.Empty)
                {
                    fileMonitor.StopMonitoring();
                    fileMonitor.StartMonitoring(txtFilePath.Text, dataGridViewFileList, Time);
                }
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                txtFilePath.Clear();
                var result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtFilePath.Text = folderBrowserDialog.SelectedPath;
                    fileMonitor.StopMonitoring();
                    fileMonitor.StartMonitoring(txtFilePath.Text, dataGridViewFileList, Time);
                    this.UpdateMonitoringStatus(true);
                }
            };

        }

        private void btnStatusStop_Click(object sender, EventArgs e)
        {
            this.UpdateMonitoringStatus(false);
            fileMonitor.StopMonitoring();
        }

        private void btnStatusActive_Click(object sender, EventArgs e)
        {
            fileMonitor.StartMonitoring(txtFilePath.Text, dataGridViewFileList, Time);
            this.UpdateMonitoringStatus(true);
        }

        private async void dataGridViewFileList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FileExtension = dataGridViewFileList.CurrentRow.Cells[1].Value.ToString();
            FileFullName = dataGridViewFileList.CurrentRow.Cells[2].Value.ToString();
            FileType fileTypeEnum = await fileTypeResolver.GetFileTypeFromExtensionAsync(FileExtension);
            var factory = FileLoaderFactory.CreateFileLoader(fileTypeEnum);
            var factoryIncludeMethod = await factory.LoadAsync(FileFullName);
            await this.BindDataToGridAsync(dataGridViewFileContent, factoryIncludeMethod);
        }
    }
}
