using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _08_02_TBQAnhHDHuyDQHung_LTNET
{
    public partial class frmTBQAnhHDHuyDQHung_TimKiemNhanVien : Form
    {
        SqlConnection sqlCon;
        SqlDataAdapter sqlDa;
        DataSet dataSet;
        DataTable dataTable = new DataTable();
        public frmTBQAnhHDHuyDQHung_TimKiemNhanVien()
        {
            InitializeComponent();
        }

        public void connect()
        {
            //B1: khai báo chuỗi kết nối
            string ketnoi;
            ketnoi = @"Data Source = LAPTOP-4ODME1Q0\SQLEXPRESS01;Initial Catalog = qlnh_08_TBQAnhHDHuyDQHung; Integrated Security = True";

            //B2: Khai báo và khởi tạo kết nõi
            sqlCon = new SqlConnection();
            sqlCon.ConnectionString = ketnoi;

            //B3: Mở csdl
            sqlCon.Open();
        }

        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            connect();
            //B1: Tạo câu lệnh truy vấn
            string sql;
            sql = "SELECT * FROM nhanvien";
            //B2: Tạo cầu nối dữ liệu
            sqlDa = new SqlDataAdapter(sql, sqlCon);
            //B3: Tạo dataset
            dataSet = new DataSet();
            //B4: Điền dữ liệu
            sqlDa.Fill(dataSet);
            //B5: Hiển thị dữ liệu
            dataGridView_QuanLyNhanVien.DataSource = dataSet.Tables[0];
            dataGridView_QuanLyNhanVien.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView_QuanLyNhanVien.RowTemplate.Height = 30;
        }

        private void dataGridView_QuanLyNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void checkBoxTimTen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTimTen.Checked == false)
                textBoxTimTen.Visible = false;
            else
                textBoxTimTen.Visible = true;
        }

        private void checkBoxTimquequan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTimquequan.Checked == true)
                textBoxTimquequan.Visible = true;
            else
                textBoxTimquequan.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkBoxTimTen.Checked == true)
            {
                if (textBoxTimTen.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sqlSearch = "SELECT * FROM nhanvien WHERE hoten LIKE N'%" + textBoxTimTen.Text + "%'";
                    SqlCommand sqlCom = new SqlCommand(sqlSearch, sqlCon);
                    sqlCom.ExecuteNonQuery();
                    SqlDataReader sqlDataReader = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sqlDataReader);
                    dataGridView_QuanLyNhanVien.DataSource = dt;
                }
            }
            else if (checkBoxTimquequan.Checked == true)
            {
                if (textBoxTimTen.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sqlSearch = "SELECT * FROM nhanvien WHERE quequan LIKE N'%" + textBoxTimquequan.Text + "%'";
                    SqlCommand sqlCom = new SqlCommand(sqlSearch, sqlCon);
                    sqlCom.ExecuteNonQuery();
                    SqlDataReader sqlDataReader = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sqlDataReader);
                    dataGridView_QuanLyNhanVien.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục cần tìm kiếm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFullNV_Click(object sender, EventArgs e)
        {
            frmTimKiemNhanVien_Load(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
