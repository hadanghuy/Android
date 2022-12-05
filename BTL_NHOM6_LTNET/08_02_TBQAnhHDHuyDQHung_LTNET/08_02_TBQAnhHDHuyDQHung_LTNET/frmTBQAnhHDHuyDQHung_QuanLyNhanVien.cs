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
    public partial class frmTBQAnhHDHuyDQHung_QuanLyNhanVien : Form
    {
        //Khai báo biến toàn cục
        SqlConnection sqlCon;
        DataSet dataSet;
        DataTable dataTable = new DataTable();

        // Xây dựng hàm kết nối để dùng chung
        public void connect()//khai báo một phương thức chung cho dùng để kết nối với cơ sơ dữ liệu
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

        public frmTBQAnhHDHuyDQHung_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            connect();
            //B1: Tạo câu lệnh truy vấn
            string sql;
            sql = "SELECT * FROM nhanvien";
            //B2: Tạo cầu nối dữ liệu
            SqlDataAdapter sqlDa = new SqlDataAdapter(sql, sqlCon);
            //B3: Tạo dataset
            dataSet = new DataSet();//đây là nơi dùng để điền dự liệu vào dataset
            //B4: Điền dữ liệu
            sqlDa.Fill(dataSet);
            //B5: Hiển thị dữ liệu
            dgvQLNV.DataSource = dataSet.Tables[0];
            dgvQLNV.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvQLNV.RowTemplate.Height = 100;
        }

        private void dataGridView_QuanLyNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Đối tượng này dùng để trình bày dữ liệu có trong
            //đối tượng DataSet, DataTable, DataView dưới hình
            //thức khác nhau
            //Để lấy mẩu tin đang chọn trên điều khiển
            //DataGridView sử dụng thuộc tính trên, thuộc tính này
            //trả về đối tượng DataGridViewRow chứa đựng mẩu tin
           //đang chọn

            txtManv.Text = dgvQLNV.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dgvQLNV.CurrentRow.Cells[1].Value.ToString();
            dtpNgaysinh.Text = dgvQLNV.CurrentRow.Cells[2].Value.ToString();
            cbboxGioitinh.Text = dgvQLNV.CurrentRow.Cells[3].Value.ToString();
            txtQuequan.Text = dgvQLNV.CurrentRow.Cells[4].Value.ToString();
            txtNambdlv.Text = dgvQLNV.CurrentRow.Cells[5].Value.ToString();
            txtLuong.Text = dgvQLNV.CurrentRow.Cells[6].Value.ToString();
            cbMapb.Text = dgvQLNV.CurrentRow.Cells[7].Value.ToString();
        }
        //Điều khiển dữ liệu
        private void btnDau_Click(object sender, EventArgs e)
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
            // Trong lt đếm từ 0 -> n: VD: 0 -> 9 = 10 khi đếm trong hàng cần - 1;
            this.BindingContext[dataSet.Tables[0]].Position = dataSet.Tables[0].Rows.Count - 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống", "thêm dự liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManv.Focus();
            }
            else
            {
                try
                {
                    connect();
                    string sqlInsert;
                    sqlInsert = "INSERT INTO nhanvien VALUES ('" + txtManv.Text + "',N'" + txtHoten.Text + "','" + dtpNgaysinh.Text + "',N'" + cbboxGioitinh.Text + "',N'" + txtQuequan.Text + "','" + txtNambdlv.Text + "','" + txtLuong.Text + "',N'" + cbMapb.Text + "')";
                    SqlCommand sqlcom = new SqlCommand(sqlInsert, sqlCon);//cung cấp bốn phương thức chính, cho phép
                                                 //ta thực thi lệnh sql bao gồm:ExecuteNonQuery, ExcecuteReader, ExecuteScalar,
                                                 //ExecuteXMLReader
                    int kq = sqlcom.ExecuteNonQuery();//Để thực thi phát biểu Sql
                    if (kq > 0)
                        MessageBox.Show("Bạn đã thêm được thành công nhân viên vào công ty", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Bạn chưa thêm được nhân viên vào công ty", "Thêm dữ liệu");

                    frmQuanLyNhanVien_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManv.Focus();
            }
            else
            {
                try
                {
                    connect();
                    string sqlUpdate;
                    sqlUpdate = "UPDATE nhanvien SET hoten = N'" + txtHoten.Text + "',ngaysinh = '" + dtpNgaysinh.Text + "',gioitinh = '" + cbboxGioitinh.Text + "',quequan = N'" + txtQuequan.Text + "',nambatdaulv = '" + txtNambdlv.Text + "',luong = '" + txtLuong.Text + "'," +
                        "mapb = '" + cbMapb.Text + "' WHERE manv = '" + txtManv.Text + "'";
                    // Dùng SqlCommand thực thi SQL 
                    SqlCommand sqlCom = new SqlCommand();
                    sqlCom.Connection = sqlCon;
                    sqlCom.CommandText = sqlUpdate;//CommandText Cho phép ta khai báo phát biểu SQL
                    // còn một cách khai báo khác   SqlCommand sqlcom = new SqlCommand( sqlUpdate, sqlcon);
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
                    frmQuanLyNhanVien_Load(sender, e);// load lại dữ liệu trong cớ sở dữ liệu sau khi thực hiện câu lệnh truy vấn
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra khóa chính mã nhân viên
            if (txtManv.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManv.Focus();
            }
            else
            {
                try
                {
                    connect();
                    string sqlDelete;
                    sqlDelete = "DELETE FROM nhanvien WHERE manv = '" + txtManv.Text + "'";// thực hiện câu lệnh truy vấn khi xóa đi nhân viên với mã tương ứng
                    SqlCommand sqlCom = new SqlCommand();
                    sqlCom.Connection = sqlCon;
                    sqlCom.CommandText = sqlDelete;

                    //Bước 6: Thực thi phương thức ExcuteNoneQuery()
                    int kq = sqlCom.ExecuteNonQuery(); // xử lý lỗi ngoại lệ khóa chính của CSDL
                    if (kq > 0)
                    {
                        MessageBox.Show("Bạn đã xóa thành công nhân viên khỏi công ty!!!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa xóa được nhân viên khỏi công ty!!!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    frmQuanLyNhanVien_Load(sender, e);//load dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }
        }

        private void btnSapxep_Click(object sender, EventArgs e)
        {
            connect();
            string sqlSort;
            sqlSort = "SELECT * FROM nhanvien ORDER BY luong DESC";// truy vấn sắp xếp theo thứ tự giảm dần
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSort, sqlCon);// dùng để thực thi các câu lệnh trong sql
            dataSet = new DataSet();//Để điền dữ liệu vào đối tượng Dataset hay Datatable từ
           // CSDL nguồn, ta dùng phương thức fill

            adapter.Fill(dataSet);
            dgvQLNV.DataSource = dataSet.Tables[0];


        }

        private void btnMaxluong_Click(object sender, EventArgs e)
        {
            connect();
            string sqlMaxLuong;
            sqlMaxLuong = "SELECT * FROM nhanvien WHERE luong = (SELECT MAX(luong) FROM nhanvien)";// câu lệnh đưa ra thông tin nhân viên với mức lương 
            // lớn nhất
            SqlDataAdapter adapter = new SqlDataAdapter(sqlMaxLuong, sqlCon);
            dataSet = new DataSet();// đối tượng dataset dùng để tạo vè điền thông tin đối tượng vào trong 
            adapter.Fill(dataSet);// dùng để điền đối tượng vào trong phuwong thức dataset
            dgvQLNV.DataSource = dataSet.Tables[0];
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        { /// lúc này ta gán cho các  đối tượng của text về rỗng khi kích vào nút nhập lại
            txtManv.Text = "";
            txtHoten.Text = "";
            dtpNgaysinh.Text = "";
            cbboxGioitinh.Text = "";
            txtQuequan.Text = "";
            txtNambdlv.Text = "";
            txtLuong.Text = "";
            cbMapb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();// dùng để đóng  
        }
       
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_TimKiemNhanVien fTimNV = new frmTBQAnhHDHuyDQHung_TimKiemNhanVien();
            fTimNV.ShowDialog();//
        }

        private void btnVItri_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ô hiện thời:" + dgvQLNV.CurrentCell.Value.ToString());// //Thuộc tính CurrentCell
                                                                                   // Để lấy giá trị trên ô đang chọn
              //mẩu tin đang chọn trên điều khiển
              // DataGridView sử dụng thuộc tính trên, thuộc tính này
             //trả về đối tượng DataGridViewRow chứa đựng mẩu tin
             //đang chọn
        }

        private void btnDem_Click(object sender, EventArgs e)
        {
            connect();
            string sql;
            sql = "select count(*) from nhân viên";
            SqlCommand sqlcom = new SqlCommand(sql, sqlCon);
            // sử dụng phương thức ExcureScalar phương thức này thực thi sql và trả về kiểu Object(như trả về hàng,
            // cột)
            object obj = sqlcom.ExecuteScalar();
            MessageBox.Show("Tổng số nhân viên là: " + obj);
            tongsv.Text = "Tổng số nhân viên là: " + obj;
            //quan trong là tính điểm trung bình hay tính điểm trung bình;
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            connect();
            string sql;
            sql = "select* from nhanvien";
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

        private void cbboxGioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
