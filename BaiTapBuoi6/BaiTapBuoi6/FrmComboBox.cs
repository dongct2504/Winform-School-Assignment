﻿using System;
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
    public partial class FrmComboBox : Form
    {
        public FrmComboBox()
        {
            InitializeComponent();
        }

        private void cbbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbbCity.SelectedItem.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Chac chua",
                "Xac nhan thoat",
                MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
