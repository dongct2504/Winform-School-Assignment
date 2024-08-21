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

namespace BaiTapBuoi9KetNoiDuLieu
{
    public partial class FrmBaiTapBuoi9 : Form
    {
        private const string ConnectionString = "Data Source=localhost;Initial Catalog=DemoKetNoi;User ID=sa;Password=Dong01646245557;TrustServerCertificate=True";

        private SqlConnection sqlConnection = null;

        public FrmBaiTapBuoi9()
        {
            InitializeComponent();
        }

        private void FrmBaiTapBuoi9_Load(object sender, EventArgs e)
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

                LoadData();
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

        private void LoadData()
        {
            string strQuery = "SELECT * FROM PhongBan";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strQuery, sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dgvTable.DataSource = dataTable;
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvTable.CurrentRow.Index;

            txtCode.Text = dgvTable.Rows[index].Cells[0].Value.ToString();
            txtDepartment.Text = dgvTable.Rows[index].Cells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                string strAdd = "INSERT INTO PhongBan " +
                    "(TenPhongBan) " +
                    "VALUES " +
                    $"('{txtDepartment.Text}')";

                SqlCommand sqlCommand = new SqlCommand(strAdd, sqlConnection);
                sqlCommand.ExecuteNonQuery();

                txtDepartment.Clear();
                txtDepartment.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                FrmBaiTapBuoi9_Load(sender, e);
            }
        }
    }
}
