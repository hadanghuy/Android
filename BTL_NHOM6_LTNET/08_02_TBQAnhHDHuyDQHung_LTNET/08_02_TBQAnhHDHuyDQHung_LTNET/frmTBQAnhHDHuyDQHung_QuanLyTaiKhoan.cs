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

/*
 * Tên nhóm: TBQAnhHDHuyDQHung_08_QLNH
 * Họ và tên thành viên - MSV - Lớp
 * Tống Bá Quang Anh - 19103100162 - DHTI13A2HN
 * Hà Đăng Huy - 19103100085 - DHTI13A2HN
 * Đinh Quang Hưng - 19103100082 - DHTI13A2HN
 */

namespace _08_02_TBQAnhHDHuyDQHung_LTNET
{
    public partial class frmTBQAnhHDHuyDQHung_QuanLyTaiKhoan : Form
    {
        //Khai báo biến toàn cục
        SqlCommand sqlCom;
        SqlConnection sqlCon;
        SqlDataAdapter sqlDa;
        DataSet dataSet;
        DataTable dataTable = new DataTable();
        
        // Xây dựng hàm kết nối để dùng chung
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

        public frmTBQAnhHDHuyDQHung_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            connect();
            //B1: Tạo câu lệnh truy vấn
            string sql;
            sql = "SELECT * FROM dangnhap";
            //B2: Tạo cầu nối dữ liệu
            sqlDa = new SqlDataAdapter(sql, sqlCon);
            //B3: Tạo dataset
            dataSet = new DataSet();
            //B4: Điền dữ liệu
            sqlDa.Fill(dataSet);
            //B5: Hiển thị dữ liệu
            dataGridView_DSTaiKhoan.DataSource = dataSet.Tables[0];
            dataGridView_DSTaiKhoan.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView_DSTaiKhoan.RowTemplate.Height = 30;
        }

        private void dataGridView_DSTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dataGridView_DSTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = dataGridView_DSTaiKhoan.CurrentRow.Cells[1].Value.ToString();
            txtFullname.Text = dataGridView_DSTaiKhoan.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dataGridView_DSTaiKhoan.CurrentRow.Cells[3].Value.ToString();
            cbMod.Text = dataGridView_DSTaiKhoan.CurrentRow.Cells[4].Value.ToString();
            cbState.Text = dataGridView_DSTaiKhoan.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đăng nhập
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Thông tin đăng nhập không được để trống!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else
            {
                try
                {
                    connect();

                    // Tạo câu lệnh truy vấn
                    string sqlInsert;
                    sqlInsert = "INSERT INTO dangnhap VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "',N'" + txtFullname.Text + "','" + txtEmail.Text + "','" + cbMod.Text + "', '" + cbState.Text + "')";
                    //Bước 5: Dùng SqlCommand thực thi SQL 
                    SqlCommand sqlCom = new SqlCommand(sqlInsert, sqlCon);

                    // Thực thi phương thức ExcuteNoneQuery()
                    int kq = sqlCom.ExecuteNonQuery(); // xử lý lỗi ngoại lệ
                    if (kq > 0)
                    {
                        MessageBox.Show("Bạn đã thêm thành công tài khoản mới!!!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa thêm được tài khoản mới!!!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    frmQuanLyTaiKhoan_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đăng nhập
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Thông tin đăng nhập không được để trống!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else
            {
                try
                {
                    connect();

                    // Tạo câu lệnh truy vấn
                    string sqlDelete;
                    sqlDelete = "DELETE FROM dangnhap WHERE username = '" + txtUsername.Text + "'";
                    // Dùng SqlCommand thực thi SQL 
                    sqlCom = new SqlCommand();
                    sqlCom.Connection = sqlCon;
                    sqlCom.CommandText = sqlDelete;

                    // Thực thi phương thức ExcuteNoneQuery()
                    int kq = sqlCom.ExecuteNonQuery(); // xử lý lỗi ngoại lệ
                    if (kq > 0)
                    {
                        MessageBox.Show("Bạn đã xóa thành công tài khoản!!!", "Xử lý dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa xóa được tài khoản mới!!!", "Xử lý dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    frmQuanLyTaiKhoan_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Xử lý dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            string user = txtUsername.Text;
            string password = txtPassword.Text;
            // Kiểm tra username
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Thông tin đăng nhập không được để trống!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else
            {
                try
                {
                    connect();
                    string sqlUpdate;
                    sqlUpdate = "UPDATE dangnhap SET password = '" + txtPassword.Text + "',fullname = N'" + txtFullname.Text + "',email = '" + txtEmail.Text + "',mod = '" + cbMod.Text + "',state = '" + cbState.Text + "' WHERE username = '" + txtUsername.Text + "'";
                    // Dùng SqlCommand thực thi SQL 
                    sqlCom = new SqlCommand();
                    sqlCom.Connection = sqlCon;
                    sqlCom.CommandText = sqlUpdate;

                    // Thực thi phương thức ExcuteNoneQuery()
                    int kq = sqlCom.ExecuteNonQuery(); // xử lý lỗi ngoại lệ
                    if (kq > 0)
                    {
                        MessageBox.Show("Bạn đã sửa thành công tài khoản!!!", "Xử lý dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa sửa được tài khoản mới!!!", "Xử lý dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    frmQuanLyTaiKhoan_Load(sender, e);
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    MessageBox.Show("Thông tin tài khoản không còn tồn tại!!!", "Xử lý dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult exitCT = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exitCT == DialogResult.OK)
                this.Close();
        }
    }
}
