using CsharpCodingTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpCodingTest.Extension
{
    public static class FrmMainFolderMonitorExtension
    {
        public static void UpdateMonitoringStatus(this FrmMainFolderMonitor form, bool isActive)
        {
            form.btnStatusActive.Enabled = !isActive;
            form.btnStatusStop.Enabled = isActive;
            form.lblStatus.Text = isActive
                ? " Status: Monitoring Active  ✅"
                : " Status: Monitoring Deactive  ⛔";
        }
        public static async Task BindDataToGridAsync<T>(this FrmMainFolderMonitor form, DataGridView grid, List<T> data)
        {
            grid.DataSource = data;
            if (typeof(T) == typeof(Trade))
            {
                grid.Columns["Date"].HeaderText = "Date";
                grid.Columns["Open"].HeaderText = "Open Price";
                grid.Columns["High"].HeaderText = "High Price";
                grid.Columns["Low"].HeaderText = "Low Price";
                grid.Columns["Close"].HeaderText = "Close Price";
                grid.Columns["Volume"].HeaderText = "Volume";
            }
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
    }
}
