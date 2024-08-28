using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BT_Buoi11.BLL;
using BT_Buoi11.DTO;

namespace BT_Buoi11.GUI
{
    public partial class FrmPhongBan : Form
    {
        BLL_PhongBan BLL = new BLL_PhongBan();
        PhongBan pb = new PhongBan();

        public FrmPhongBan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            dtgPhongBan.DataSource = BLL.GetDataPhongBan();
        }

        private void LayDuLieuPhongBan()
        {
            pb.maPB = txtMaPhong.Text;
            pb.tenPB = txtTenPhong.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtMaPhong.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LayDuLieuPhongBan();
            BLL.AddPhongBan(pb);
            FrmPhongBan_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            LayDuLieuPhongBan();
            BLL.UpdatePhongBan(pb);
            FrmPhongBan_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LayDuLieuPhongBan();
            BLL.DeletePhongBan(pb);
            FrmPhongBan_Load(sender, e);
            txtMaPhong.Clear();
            txtTenPhong.Clear();
        }

        private void dtgPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgPhongBan.CurrentRow.Index;
            txtMaPhong.Text = dtgPhongBan.Rows[i].Cells[0].Value.ToString();
            txtTenPhong.Text = dtgPhongBan.Rows[i].Cells[1].Value.ToString();
        }
    }
}
