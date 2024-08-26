using CayTrieuDongWinformGiuaKy.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CayTrieuDongWinformGiuaKy
{
    public partial class FrmProfile : Form
    {
        private SqlConnection sqlConnection = null;

        public FrmProfile()
        {
            InitializeComponent();
        }

        private void FrmProfile_Load(object sender, EventArgs e)
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

                string query = "SELECT TenDangNhap, TenHienThi FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@TenDangNhap", SaveUserName.UserName);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    txtUserName.Text = reader["TenDangNhap"].ToString();
                    txtDisplayName.Text = reader["TenHienThi"].ToString();
                }

                reader.Close();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.");
                    return;
                }

                string checkOldPasswordQuery = 
                    "SELECT TenDangNhap, MatKhau " +
                    "FROM TaiKhoan " +
                    "WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MauKhauCu";

                SqlCommand checkOldPasswordCmd = new SqlCommand(checkOldPasswordQuery, sqlConnection);
                checkOldPasswordCmd.Parameters.AddWithValue("@TenDangNhap", txtUserName.Text);
                checkOldPasswordCmd.Parameters.AddWithValue("@MatKhauCu", txtOldPassword.Text);

                SqlDataReader reader = checkOldPasswordCmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Mật khẩu cũ không đúng.");
                    return;
                }

                string updateQuery = 
                    "UPDATE TaiKhoan " +
                    "SET TenHienThi = @TenHienThi, MatKhau = @MatKhau " +
                    "WHERE TenDangNhap = @TenDangNhap";

                SqlCommand sqlCommand = new SqlCommand(updateQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@TenDangNhap", txtUserName.Text);
                sqlCommand.Parameters.AddWithValue("@TenHienThi", txtDisplayName.Text);
                sqlCommand.Parameters.AddWithValue("@MatKhau", txtNewPassword.Text);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thông tin cập nhật thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin.");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
