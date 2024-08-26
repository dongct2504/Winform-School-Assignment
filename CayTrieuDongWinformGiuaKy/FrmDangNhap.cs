using CayTrieuDongWinformGiuaKy.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CayTrieuDongWinformGiuaKy
{
    public partial class FrmDangNhap : Form
    {
        private SqlConnection sqlConnection = null;

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection == null)
                {
                    sqlConnection = new SqlConnection(SqlServerConnectionInit.ConnectionString);
                }

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (!CheckUserIfExist())
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
            else
            {
                FrmMain frmMain = new FrmMain();
                Hide();
                frmMain.ShowDialog();
                Show();
            }
        }

        private bool CheckUserIfExist()
        {
            try
            {
                sqlConnection.Open();

                string queryLogin =
                    "SELECT TenDangNhap " +
                    "FROM TaiKhoan " +
                    "WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";

                SqlCommand sqlCommand = new SqlCommand(queryLogin, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@TenDangNhap", txtUserName.Text);
                sqlCommand.Parameters.AddWithValue("@MatKhau", txtPassword.Text);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    SaveUserName.UserName = reader["TenDangNhap"].ToString();
                    return true;
                }

                reader.Close();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
