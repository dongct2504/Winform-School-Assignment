using System;
using System.Windows.Forms;

namespace CayTrieuDongWinformGiuaKy
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhoa frmKhoa = new FrmKhoa();
            Hide();
            frmKhoa.ShowDialog();
            Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfile frmProfile = new FrmProfile();
            Hide();
            frmProfile.ShowDialog();
            Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
