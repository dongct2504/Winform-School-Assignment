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
    public partial class FrmListBox : Form
    {
        public FrmListBox()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lsbItems.Items.IndexOf(lsbItems.Text) >= 0)
            {
                lsbItems.SelectedItem = txtInput.Text;
                txtInput.Clear();
                txtInput.Focus();
            }
            else if (txtInput.Text.Length >= 0)
            {
                lsbItems.Items.Add(txtInput.Text);
                txtInput.Focus();
                txtInput.Clear();
            }
        }

        private void lsbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbItems.SelectedIndex != 0)
            {
                lsbItems.Items.Remove(lsbItems.SelectedItem);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
