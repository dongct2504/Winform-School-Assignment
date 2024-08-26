using CayTrieuDongWinformGiuaKy.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CayTrieuDongWinformGiuaKy
{
    public partial class FrmKhoa : Form
    {
        private SqlConnection sqlConnection = null;
        private bool isAddCourse = false;
        private bool isAddClass = false;

        public FrmKhoa()
        {
            InitializeComponent();
        }

        private void FrmKhoa_Load(object sender, EventArgs e)
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

                string selectQueryPhongBan = "SELECT MaKhoa, TenKhoa FROM Khoa";

                SqlCommand sqlCommand = new SqlCommand(selectQueryPhongBan, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                cboCourse.DataSource = dataTable;
                cboCourse.DisplayMember = "TenKhoa";
                cboCourse.ValueMember = "MaKhoa";
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

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                if (cboCourse.SelectedValue == null || cboCourse.SelectedValue == DBNull.Value)
                {
                    return;
                }

                string selectedValue = cboCourse.SelectedValue.ToString();

                // display for course
                string selectQueryCourse =
                    "SELECT MaKhoa, TenKhoa " +
                    "FROM Khoa " +
                    "WHERE MaKhoa = @MaKhoa";

                SqlCommand sqlCommandCourse = new SqlCommand(selectQueryCourse, sqlConnection);
                sqlCommandCourse.Parameters.AddWithValue("@MaKhoa", selectedValue);

                SqlDataReader reader = sqlCommandCourse.ExecuteReader();

                if (reader.Read())
                {
                    txtCourseId.Text = reader["MaKhoa"].ToString();
                    txtCourseName.Text = reader["TenKhoa"].ToString();
                }

                reader.Close();

                // display for classes
                string selectQueryClass = "SELECT * FROM Lop WHERE MaKhoa = @MaKhoa";

                SqlCommand sqlCommandClass = new SqlCommand(selectQueryClass, sqlConnection);
                sqlCommandClass.Parameters.AddWithValue("@MaKhoa", selectedValue);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommandClass);
                DataTable classDataTable = new DataTable();

                sqlDataAdapter.Fill(classDataTable);

                dgvClass.DataSource = classDataTable;
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

        // CRUD Courses
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            isAddCourse = true;
            txtCourseId.Enabled = true;
            txtCourseId.Focus();
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            isAddCourse = false;
            txtCourseId.Enabled = false;
            txtCourseName.Focus();
        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                if (isAddCourse)
                {
                    string addCourse =
                        "INSERT INTO Khoa " +
                        "(MaKhoa, TenKhoa) " +
                        "VALUES " +
                        "(@MaKhoa, @TenKhoa)";

                    SqlCommand sqlCommand = new SqlCommand(addCourse, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MaKhoa", txtCourseId.Text);
                    sqlCommand.Parameters.AddWithValue("@TenKhoa", txtCourseName.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    string updateCourse =
                        "UPDATE Khoa " +
                        "SET TenKhoa = @TenKhoa " +
                        "WHERE MaKhoa = @MaKhoa";

                    SqlCommand sqlCommand = new SqlCommand(updateCourse, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MaKhoa", txtCourseId.Text);
                    sqlCommand.Parameters.AddWithValue("@TenKhoa", txtCourseName.Text);
                    sqlCommand.ExecuteNonQuery();
                }

                txtCourseId.Clear();
                txtCourseName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                FrmKhoa_Load(sender, e);
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                string deleteCourse =
                    "DELETE FROM Khoa " +
                    "WHERE MaKhoa = @MaKhoa";

                SqlCommand sqlCommand = new SqlCommand(deleteCourse, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MaKhoa", txtCourseId.Text);
                sqlCommand.ExecuteNonQuery();

                txtCourseId.Clear();
                txtCourseName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                FrmKhoa_Load(sender, e);
            }
        }

        // CRUD Classes
        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                sqlConnection.Open();

                int index = dgvClass.CurrentRow.Index;

                string selectQueryStaff =
                    "SELECT * " +
                    "FROM Lop " +
                    "WHERE MaLop = @MaLop";

                SqlCommand sqlCommandClass = new SqlCommand(selectQueryStaff, sqlConnection);
                sqlCommandClass.Parameters.AddWithValue("@MaLop", dgvClass.Rows[index].Cells[0].Value);

                SqlDataReader reader = sqlCommandClass.ExecuteReader();

                if (reader.Read())
                {
                    txtClassId.Text = reader["MaLop"].ToString();
                    txtClassName.Text = reader["TenLop"].ToString();
                    nmNumberOfStudent.Text = reader["SiSo"].ToString();
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

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            isAddClass = true;
            txtClassId.Enabled = true;
            txtClassId.Focus();
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            isAddClass = false;
            txtClassId.Enabled = false;
            txtClassName.Focus();
        }

        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                if (isAddClass)
                {
                    string addClass =
                        "INSERT INTO Lop " +
                        "(MaLop, TenLop, SiSo, MaKhoa) " +
                        "VALUES " +
                        "(@MaLop, @TenLop, @SiSo, @MaKhoa)";

                    SqlCommand sqlCommand = new SqlCommand(addClass, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MaLop", txtClassId.Text);
                    sqlCommand.Parameters.AddWithValue("@TenLop", txtClassName.Text);
                    sqlCommand.Parameters.AddWithValue("@SiSo", nmNumberOfStudent.Text);
                    sqlCommand.Parameters.AddWithValue("@MaKhoa", txtCourseId.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    string updateClass =
                        "UPDATE Lop " +
                        "SET TenLop = @TenLop, SiSo = @SiSo " +
                        "WHERE MaLop = @MaLop";

                    SqlCommand sqlCommand = new SqlCommand(updateClass, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MaLop", txtClassId.Text);
                    sqlCommand.Parameters.AddWithValue("@TenLop", txtClassName.Text);
                    sqlCommand.Parameters.AddWithValue("@SiSo", nmNumberOfStudent.Text);
                    sqlCommand.ExecuteNonQuery();
                }

                txtClassId.Clear();
                txtClassName.Clear();
                nmNumberOfStudent.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                FrmKhoa_Load(sender, e);
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                string deleteCourse =
                    "DELETE FROM Lop " +
                    "WHERE MaLop = @MaLop";

                SqlCommand sqlCommand = new SqlCommand(deleteCourse, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MaLop", txtClassId.Text);
                sqlCommand.ExecuteNonQuery();

                txtCourseId.Clear();
                txtCourseName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                FrmKhoa_Load(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
