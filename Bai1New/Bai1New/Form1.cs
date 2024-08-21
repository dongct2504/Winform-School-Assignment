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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

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

            int max = Math.Max(txtAValue, txtBValue);
            if (txtAValue > txtBValue)
            {
                txtBigestNum.Text = txtAValue.ToString();
                txtSmallestNum.Text = txtBValue.ToString();
            }
            else
            {
                txtBigestNum.Text = txtBValue.ToString();
                txtSmallestNum.Text = txtAValue.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtBigestNum.Clear();
            txtSmallestNum.Clear();
        }
    }
}
