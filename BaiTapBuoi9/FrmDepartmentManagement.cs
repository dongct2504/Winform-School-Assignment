using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoi9
{
    public partial class FrmDepartmentManagement : Form
    {
        private const string ConnectionString = "Data Source=localhost;Initial Catalog=DemoKetNoi;" +
            "User ID=sa;Password=Dong01646245557;TrustServerCertificate=True";

        private SqlConnection sqlConnection = null;

        public FrmDepartmentManagement()
        {
            InitializeComponent();
        }

        private void FrmDepartmentManagement_Load(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection == null)
                {
                    sqlConnection = new SqlConnection(ConnectionString);
                }

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                string selectQueryPhongBan = "SELECT MaPhongBan, TenPhongBan FROM PhongBan";

                SqlCommand sqlCommand = new SqlCommand(selectQueryPhongBan, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                cboDepartment.DataSource = dataTable;
                cboDepartment.DisplayMember = "TenPhongBan";
                cboDepartment.ValueMember = "MaPhongBan";
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

        // CRUD Department
        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                // display for department
                string selectQueryDepartment =
                    "SELECT MaPhongBan, TenPhongBan " +
                    "FROM PhongBan " +
                    "WHERE MaPhongBan = @MaPhongBan";

                SqlCommand sqlCommandDepartment = new SqlCommand(selectQueryDepartment, sqlConnection);
                sqlCommandDepartment.Parameters.AddWithValue("@MaPhongBan", cboDepartment.SelectedValue);

                SqlDataReader reader = sqlCommandDepartment.ExecuteReader();

                if (reader.Read())
                {
                    txtDepartmentId.Text = reader["MaPhongBan"].ToString();
                    txtDepartmentName.Text = reader["TenPhongBan"].ToString();
                }

                reader.Close();

                // display for staff
                string selectQueryStaff =
                    "SELECT nv.MaNhanVien, nv.TenNhanVien, nv.ChucVu, nv.SoDienThoai, nv.DiaChi, " +
                    "   pb.TenPhongBan " +
                    "FROM NhanVien nv " +
                    "   JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan " +
                    "WHERE nv.MaPhongBan = @MaPhongBan";

                SqlCommand sqlCommandStaff = new SqlCommand(selectQueryStaff, sqlConnection);
                sqlCommandStaff.Parameters.AddWithValue("@MaPhongBan", cboDepartment.SelectedValue);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommandStaff);
                DataTable staffDataTable = new DataTable();

                sqlDataAdapter.Fill(staffDataTable);

                dgvStaff.DataSource = staffDataTable;
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

        private void btnSaveDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                string addDepartment =
                    "INSERT INTO PhongBan " +
                    "(TenPhongBan) " +
                    "VALUES " +
                    "(@TenPhongBan)";

                SqlCommand sqlCommand = new SqlCommand(addDepartment, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@TenPhongBan", txtDepartmentName.Text);
                sqlCommand.ExecuteNonQuery();

                txtDepartmentId.Clear();
                txtDepartmentName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                FrmDepartmentManagement_Load(sender, e);
            }
        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                string updateDepartment =
                    "UPDATE PhongBan " +
                    "SET TenPhongBan = @TenPhongBan " +
                    "WHERE MaPhongBan = @MaPhongBan";

                SqlCommand sqlCommand = new SqlCommand(updateDepartment, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@TenPhongBan", txtDepartmentName.Text);
                sqlCommand.Parameters.AddWithValue("@MaPhongBan", txtDepartmentId.Text);
                sqlCommand.ExecuteNonQuery();

                txtDepartmentId.Clear();
                txtDepartmentName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                FrmDepartmentManagement_Load(sender, e);
            }
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                string deleteDepartment =
                    "DELETE FROM PhongBan " +
                    "WHERE MaPhongBan = @MaPhongBan";

                SqlCommand sqlCommand = new SqlCommand(deleteDepartment, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MaPhongBan", txtDepartmentId.Text);
                sqlCommand.ExecuteNonQuery();

                txtDepartmentId.Clear();
                txtDepartmentName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                FrmDepartmentManagement_Load(sender, e);
            }
        }

        // CRUD Staff
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                int index = dgvStaff.CurrentRow.Index;

                string selectQueryStaff =
                    "SELECT * " +
                    "FROM NhanVien " +
                    "WHERE MaNhanVien = @MaNhanVien";

                SqlCommand sqlCommandStaff = new SqlCommand(selectQueryStaff, sqlConnection);
                sqlCommandStaff.Parameters.AddWithValue("@MaNhanVien", dgvStaff.Rows[index].Cells[0].Value);

                SqlDataReader reader = sqlCommandStaff.ExecuteReader();

                if (reader.Read())
                {
                    txtStaffId.Text = reader["MaNhanVien"].ToString();
                    txtStaffName.Text = reader["TenNhanVien"].ToString();
                    txtPosition.Text = reader["ChucVu"].ToString();
                    txtPhoneNumber.Text = reader["SoDienThoai"].ToString();
                    txtAddress.Text = reader["DiaChi"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                FrmDepartmentManagement_Load(sender, e);
            }
        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                string addStaff =
                    "INSERT INTO NhanVien " +
                    "(TenNhanVien, ChucVu, SoDienThoai, DiaChi) " +
                    "VALUES " +
                    "(@TenNhanVien, @ChucVu, @SoDienThoai, @DiaChi)";

                SqlCommand sqlCommand = new SqlCommand(addStaff, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@TenNhanVien", txtStaffName.Text);
                sqlCommand.Parameters.AddWithValue("@ChucVu", txtPosition.Text);
                sqlCommand.Parameters.AddWithValue("@SoDienThoai", txtPhoneNumber.Text);
                sqlCommand.Parameters.AddWithValue("@DiaChi", txtAddress.Text);
                sqlCommand.ExecuteNonQuery();

                txtStaffId.Clear();
                txtStaffName.Clear();
                txtPosition.Clear();
                txtPhoneNumber.Clear();
                txtAddress.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                FrmDepartmentManagement_Load(sender, e);
            }
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                string updateStaff =
                    "UPDATE NhanVien " +
                    "SET TenNhanVien = @TenNhanVien, ChucVu = @ChucVu," +
                    "SoDienThoai = @SoDienThoai, DiaChi = @DiaChi " +
                    "WHERE MaNhanVien = @MaNhanVien";

                SqlCommand sqlCommand = new SqlCommand(updateStaff, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@TenNhanVien", txtStaffName.Text);
                sqlCommand.Parameters.AddWithValue("@ChucVu", txtPosition.Text);
                sqlCommand.Parameters.AddWithValue("@SoDienThoai", txtPhoneNumber.Text);
                sqlCommand.Parameters.AddWithValue("@DiaChi", txtAddress.Text);
                sqlCommand.ExecuteNonQuery();

                txtStaffId.Clear();
                txtStaffName.Clear();
                txtPosition.Clear();
                txtPhoneNumber.Clear();
                txtAddress.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                FrmDepartmentManagement_Load(sender, e);
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                string deleteStaff =
                    "DELETE FROM NhanVien " +
                    "WHERE MaNhanVien = @MaNhanVien";

                SqlCommand sqlCommand = new SqlCommand(deleteStaff, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MaNhanVien", txtStaffId.Text);
                sqlCommand.ExecuteNonQuery();

                txtStaffId.Clear();
                txtStaffName.Clear();
                txtPosition.Clear();
                txtPhoneNumber.Clear();
                txtAddress.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                FrmDepartmentManagement_Load(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
