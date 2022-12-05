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
    public partial class frmTBQAnhHDHuyDQHung_DoiMatKhau : Form
    {
        SqlConnection sqlCon;

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

        public frmTBQAnhHDHuyDQHung_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            connect();
            string sqlDoiMK;
            sqlDoiMK = "SELECT COUNT (*) FROM dangnhap WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassOld.Text + "'";
            SqlCommand sqlCom = new SqlCommand();//cung cấp bốn phương thức chính, cho phép
                                                 //ta thực thi lệnh sql bao gồm:ExecuteNonQuery, ExcecuteReader, ExecuteScalar,
           //ExecuteXMLReader
                        sqlCom.Connection = sqlCon;
            sqlCom.CommandText = sqlDoiMK;
            //
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlDoiMK, sqlCon);
            DataTable dtDN = new DataTable();
            sqlDa.Fill(dtDN);
            errorProvider1.Clear();// phương thức này dùng để thông báo lỗi khi trong trường hợp các thông tin nhập vào không đúng hay thiếu 
            if (dtDN.Rows[0][0].ToString() == "1")
            {
                if (txtPassNew.Text == txtRePass.Text)
                {
                    if (txtPassNew.Text.Length >= 6)// ddoj dài của password new và passwword nhập lại có độ dài nhập vào lớn hơn 6 trở lên;
                    {
                        string sqlUpdateMK;
                        sqlUpdateMK = "UPDATE dangnhap SET password = '" + txtPassNew.Text + "' WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassOld.Text + "'";
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlUpdateMK, sqlCon);//
                           //Nếu đối tượng SqlConnection chưa mở thì đối tượng
                        //SqlDataAdapter sẽ tiến hành mở kết nối csdl.
                        DataTable dt = new DataTable();///DataTable tương tự
                        //Để điền dữ liệu vào đối tượng Dataset hay Datatable từ
                        //CSDL nguồn, ta dùng phương thức fill
                        sqlDataAdapter.Fill(dt);
                        MessageBox.Show("Bạn đã đổi mật khẩu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    else
                    {
                        errorProvider1.SetError(txtPassNew, "Độ dài mật khẩu không hợp lệ. Mật khẩu mới tối thiểu phải là 6 ký tự!!!");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtPassNew, "Vui lòng nhập mật khẩu mới cần đổi!!!");
                    errorProvider1.SetError(txtRePass, "Mật khẩu nhập lại chưa đúng!!!");
                    MessageBox.Show("Chưa thể đổi mật khẩu. Vui lòng kiểm tra lại thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu cũ sai. Vui lòng kiểm tra lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassOld.Text = "";
            txtPassNew.Text = "";
            txtRePass.Text = "";
            txtUsername.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();// dùng để thoát và dừng chương trình chạy
        }
    }
}
