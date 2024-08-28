using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Buoi11.DAL
{
    public class DataAccessLayer
    {
        private SqlDataAdapter da;
        private SqlConnection conn;
        private DataTable dt;


        private void Connected()
        {
            string strcon = "Data Source=localhost;Initial Catalog=DemoKetNoi;User ID=sa;Password=Dong01646245557;TrustServerCertificate=True";
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(strcon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }


        public DataTable Getdt(string query)
        {
            Connected();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            da = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool RunQuery(string query) 
        {
            int check = 0;
            try
            {
                Connected();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                check = cmd.ExecuteNonQuery();
                conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }

            if (check > 0)
            {
                return true;
            }
            return false;
        }


    }
}
