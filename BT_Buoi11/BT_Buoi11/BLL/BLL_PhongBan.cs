using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BT_Buoi11.DAL;
using BT_Buoi11.DTO;

namespace BT_Buoi11.BLL
{
    internal class BLL_PhongBan
    {
        DataAccessLayer DAL = new DataAccessLayer();
        
        public DataTable GetDataPhongBan()
        {
            string query = "SELECT * FROM PhongBan";
            return DAL.Getdt(query);
        }

        public void AddPhongBan(PhongBan pb)
        {
            string query = "INSERT INTO PhongBan Values('" + pb.maPB + "', '"+ pb.tenPB+"')";
            if (DAL.RunQuery(query))
            {
                MessageBox.Show("Thêm dữ liệu thành công", "Thông Báo");
            }
        }

        public void UpdatePhongBan(PhongBan pb)
        {
            string query = "UPDATE PhongBan SET TenPB = '" + pb.tenPB + "' WHERE MaPB = '" + pb.maPB + "'";
            if (DAL.RunQuery(query))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo");
            }
        }

        public void DeletePhongBan(PhongBan pb)
        {
            string query = "DELETE FROM PhongBan WHERE MaPB = '" + pb.maPB + "'";
            if (DAL.RunQuery(query))
            {
                MessageBox.Show("Xóa dữ liệu thành công", "Thông Báo");
            }
        }

    }
}
