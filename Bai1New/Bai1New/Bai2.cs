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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtA.Text) || string.IsNullOrEmpty(txtB.Text))
            {
                MessageBox.Show("Nhap lai");
                return;
            }

            int txtAValue = Convert.ToInt32(txtA.Text);
            int txtBValue = Convert.ToInt32(txtB.Text);
            int txtCValue = Convert.ToInt32(txtC.Text);

            int max = Math.Max(txtAValue, Math.Max(txtBValue, txtCValue));
            int min = Math.Min(txtAValue, Math.Min(txtBValue, txtCValue));

            txtBigestNum.Text = max.ToString();
            txtSmallestNum.Text = min.ToString();
        }

        private void txtSmallestNum_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtBigestNum.Clear();
            txtSmallestNum.Clear();
        }
    }
}
