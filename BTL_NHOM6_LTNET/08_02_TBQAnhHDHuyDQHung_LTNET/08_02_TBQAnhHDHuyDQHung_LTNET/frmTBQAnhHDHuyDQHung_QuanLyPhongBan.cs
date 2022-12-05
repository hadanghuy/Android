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
    public partial class frmTBQAnhHDHuyDQHung_QuanLyPhongBan : Form
    {
        //Khai báo biến toàn cục
        SqlConnection sqlCon;
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

        public frmTBQAnhHDHuyDQHung_QuanLyPhongBan()
        {
            InitializeComponent();
        }

        private void frmQuanLyPhongBan_Load(object sender, EventArgs e)
        {
            connect();
            //B1: Tạo câu lệnh truy vấn
            string sql;
            sql = "SELECT * FROM phongban";
            //B2: Tạo cầu nối dữ liệu
            SqlDataAdapter sqlDa = new SqlDataAdapter(sql, sqlCon);
            //B3: Tạo dataset
            DataSet ds = new DataSet();
            //B4: Điền dữ liệu
            sqlDa.Fill(ds);
            //B5: Hiển thị dữ liệu
            dgvQLPB.DataSource = ds.Tables[0];
            dgvQLPB.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvQLPB.RowTemplate.Height = 30;
        }

        private void dgvQLPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMapb.Text = dgvQLPB.CurrentRow.Cells[0].Value.ToString();
            txtTenpb.Text = dgvQLPB.CurrentRow.Cells[1].Value.ToString();
            txtEmailpb.Text = dgvQLPB.CurrentRow.Cells[2].Value.ToString();
            txtDtpb.Text = dgvQLPB.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDau_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[dataSet.Tables[0]].Position = 0;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet.Tables[0]].Position--;
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet.Tables[0]].Position++;
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet.Tables[0]].Position = dataSet.Tables[0].Rows.Count - 1;
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMapb.Text = "";
            txtTenpb.Text = "";
            txtEmailpb.Text = "";
            txtDtpb.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMapb.Text == "")
            {
                MessageBox.Show("Mã phòng ban không được để trống!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMapb.Focus();
            }
            else
            {
                try
                {
                    connect();

                    //Bước 4: Tạo câu lệnh truy vấn
                    string sql;
                    sql = "INSERT INTO phongban VALUES (N'" + txtMapb.Text + "',N'" + txtTenpb.Text + "',N'" + txtEmailpb.Text + "',N'" + txtDtpb.Text + "')";
                    //Bước 5: Dùng SqlCommand thực thi SQL 
                    SqlCommand sqlcom = new SqlCommand();
                    sqlcom.Connection = sqlCon;
                    sqlcom.CommandText = sql;

                    //Bước 6: Thực thi phương thức ExcuteNoneQuery()
                    int kq = sqlcom.ExecuteNonQuery(); // xử lý lỗi ngoại lệ khóa chính của CSDL
                    if (kq > 0)
                    {
                        MessageBox.Show("Bạn đã thêm thành công phòng ban mới", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa thêm được phòng ban!!!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    frmQuanLyPhongBan_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMapb.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMapb.Focus();
            }
            else
            {
                try
                {
                    connect();
                    string sqlUpdate;
                    sqlUpdate = "UPDATE phongban SET tenpb = N'" + txtTenpb.Text + "',emailpb = '" + txtEmailpb.Text + "',dienthoai = '" + txtDtpb.Text + "'WHERE mapb = '" + txtMapb.Text + "'";
                    // Dùng SqlCommand thực thi SQL 
                    SqlCommand sqlCom = new SqlCommand();
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
                    frmQuanLyPhongBan_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMapb.Text == "")
            {
                MessageBox.Show("Mã phòng ban không được để trống!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMapb.Focus();
            }
            else
            {
                try
                {
                    connect();
                    string sqlDelete;
                    sqlDelete = "DELETE FROM phongban WHERE mapb = '" + txtMapb.Text + "'";
                    SqlCommand sqlCom = new SqlCommand();
                    sqlCom.Connection = sqlCon;
                    sqlCom.CommandText = sqlDelete;

                    //Bước 6: Thực thi phương thức ExcuteNoneQuery()
                    int kq = sqlCom.ExecuteNonQuery(); // xử lý lỗi ngoại lệ khóa chính của CSDL
                    if (kq > 0)
                    {
                        MessageBox.Show("Bạn đã xóa thành công phòng ban!!!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa xóa được phòng ban!!!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    frmQuanLyPhongBan_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSapxep_Click(object sender, EventArgs e)
        {
            connect();
            string sqlSort;
            sqlSort = "SELECT * FROM phongban ORDER BY tenpb ASC";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSort, sqlCon);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dgvQLPB.DataSource = dataSet.Tables[0];
        }

        private void btnTimKiemPB_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_TimKiemPhongBan fTimPB = new frmTBQAnhHDHuyDQHung_TimKiemPhongBan();
            fTimPB.ShowDialog();
        }

        private void btnDem_Click(object sender, EventArgs e)
        {
            connect();
            string sql;
            sql = "select count(*) from phongban";
            SqlCommand sqlcom = new SqlCommand(sql, sqlCon);
            // sử dụng phương thức ExcureScalar phương thức này thực thi sql và trả về kiểu Object(như trả về hàng,
           // cột)
            object obj = sqlcom.ExecuteScalar();
            MessageBox.Show("Tổng số nhân viên là: " + obj);
            tongsv.Text = "Tổng số nhân viên là: " + obj;
            //quan trong là tính điểm trung bình hay tính điểm trung bình;

        }

        private void btnVItri_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ô hiện thời:" + dgvQLPB.CurrentCell.Value.ToString());
            //mẩu tin đang chọn trên điều khiển
           // DataGridView sử dụng thuộc tính trên, thuộc tính này
//trả về đối tượng DataGridViewRow chứa đựng mẩu tin
//đang chọn

        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            connect();
            string sql;
            sql = "select* from phongban";
            SqlCommand sqlcom = new SqlCommand(sql, sqlCon);
            SqlDataReader sqldr = sqlcom.ExecuteReader();
            //ExecuteReader() Trả về dữ liệu chỉ đọc 1 chiều và sử dụng đối tượng
           // SqlDataReader để nắm giữ tập dữ liệu đó
            string str = "";
            while (sqldr.Read()) //dùng để đọc các đối tượng trong bảng cớ sỏ dũ liêu

            {
                str += sqldr.GetString(0) + "_" + sqldr.GetString(1) + "\r\n";// hiện thi các đội tượng đã đọc đó;
            }

            sqldr.Close();
            sqldr.Dispose();
            MessageBox.Show(str);
            sqlCon.Close();
            sqlCon.Dispose();
        }
    }
}
