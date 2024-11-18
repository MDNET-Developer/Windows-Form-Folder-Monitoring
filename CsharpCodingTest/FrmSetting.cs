using System;
using System.Windows.Forms;

namespace CsharpCodingTest
{
    public partial class FrmSetting : Form
    {
        public int Second { get; set; }
        public FrmSetting()
        {
            InitializeComponent();
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            txtSecond.Text = Second.ToString();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSecond.Text) && Convert.ToInt32(txtSecond.Text)>4)
            {
                Second = Convert.ToInt32(txtSecond.Text);
                Close();
            }
            else
            {
                MessageBox.Show("The inserted value must be high from 5 ");
            }
           
        }
    }
}
