using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoi6
{
    public partial class FrmCalculate : Form
    {
        public FrmCalculate()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtA.Text, out int a) && int.TryParse(txtB.Text, out int b))
            {
                lblSum.Text = $"{a + b}";
                lblMinus.Text = $"{a - b}";
                lblIntegrate.Text = $"{a * b}";

                if (b == 0)
                {
                    lblDivide.Text = "Khong chia duoc cho 0";
                }
                else
                {
                    lblDivide.Text = $"{(double)a / b}";
                }
            }
            else
            {
                MessageBox.Show("Nhap lai");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
