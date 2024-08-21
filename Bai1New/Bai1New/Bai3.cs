using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1New
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum.Text))
            {
                return;
            }

            int txtNumValue = Convert.ToInt32(txtNum.Text);

            switch (txtNumValue)
            {
                case 0:
                    rtxtResult.Text = "Không";
                    break;
                case 1:
                    rtxtResult.Text = "Một";
                    break;
                case 2:
                    rtxtResult.Text = "Hai";
                    break;
                case 3:
                    rtxtResult.Text = "Ba";
                    break;
                case 4:
                    rtxtResult.Text = "Bốn";
                    break;
                case 5:
                    rtxtResult.Text = "Năm";
                    break;
                case 6:
                    rtxtResult.Text = "Sáu";
                    break;
                case 7:
                    rtxtResult.Text = "Bảy ";
                    break;
                case 8:
                    rtxtResult.Text = "Tám";
                    break;
                case 9:
                    rtxtResult.Text = "Chín";
                    break;
            }
        }
    }
}
