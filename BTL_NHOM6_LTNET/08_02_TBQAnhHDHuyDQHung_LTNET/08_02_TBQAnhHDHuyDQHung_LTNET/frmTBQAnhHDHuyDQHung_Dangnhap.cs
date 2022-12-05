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
    public partial class frmTBQAnhHDHuyDQHung_Dangnhap : Form
    {
        //Khai báo biến toàn cục
        SqlConnection sqlCon;

        // Xây dựng hàm kết nối để dùng chung
        public void connect()
        {
            //B1: khai báo chuỗi kết nối
            string ConnectSQL;
            ConnectSQL = @"Data Source = LAPTOP-4ODME1Q0\SQLEXPRESS01;Initial Catalog = qlnh_08_TBQAnhHDHuyDQHung; Integrated Security = True";


            //B2: Khai báo và khởi tạo kết nõi
            sqlCon = new SqlConnection();
            sqlCon.ConnectionString = ConnectSQL;

            //B3: Mở csdl
            sqlCon.Open();
        }

        public frmTBQAnhHDHuyDQHung_Dangnhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult exitCT = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exitCT == DialogResult.OK)
                Application.Exit();
        }

        // Đăng nhập quyền Admin - User
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            // Sesion User
           // csUserMod mod = null;

            string user = txtUser.Text;
            string pass = txtPass.Text;
           // string adminMod = cbQuyen.Text;
            if (user == "")
            {
                MessageBox.Show("Hãy điền tên đăng nhập", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Focus();
                txtUser.BackColor = Color.Red;
            }
            else
            {
                if (pass == "")
                {
                    MessageBox.Show("Hãy điền mật khẩu đăng nhập", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass.Focus();
                }
                else
                {
                    try
                    {
                        connect(); // Kết nối CSDL
                        string sqlLogin;
                        sqlLogin = "SELECT * FROM dangnhap WHERE username = '" + user + "' AND password = '" + pass + "' AND mod = '" + adminMod + "' ";
                        SqlCommand sqlCom = new SqlCommand(sqlLogin, sqlCon);
                        SqlDataReader sqldr = sqlCom.ExecuteReader();
                        string loginMod = "";
                        string userLogin = "";
                        while (sqldr.Read())
                        {
                            loginMod = sqldr.GetString(4);
                            userLogin = sqldr.GetString(2);
                        }
                        if (loginMod == "Admin")
                        {
                            MessageBox.Show("Đăng nhập thành công với quyền quản trị là: " + userLogin, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmTBQAnhHDHuyDQHung_Admin fAdmin = new frmTBQAnhHDHuyDQHung_Admin();
                            mod = csLoginSession.getMod();
                            mod.setUsername(user);
                            mod.setMod(loginMod);
                            fAdmin.Show();
                            this.Hide();
                        }
                        else if (loginMod == "User")
                        {
                            MessageBox.Show("Đăng nhập thành công với quyền nhân viên là: " + userLogin, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmTBQAnhHDHuyDQHung_Admin fUser = new frmTBQAnhHDHuyDQHung_Admin();
                            mod = csLoginSession.getMod();
                            mod.setUsername(user);
                            mod.setMod(loginMod);
                            fUser.setMenu();
                            fUser.Show();
                            this.Hide();
                        }                  
                        else
                        {
                            MessageBox.Show("Đăng nhập thất bại. Kiểm tra lại thông tin đăng nhập", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUser.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlnh_08_TBQAnhHDHuyDQHungDataSet.dangnhap' table. You can move, or remove it, as needed.
            //this.dangnhapTableAdapter.Fill(this.qlnh_08_TBQAnhHDHuyDQHungDataSet.dangnhap);

        }

        private void chkHienthiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienthiMK.Checked)
                txtPass.UseSystemPasswordChar = true;

            if(!chkHienthiMK.Checked)
                txtPass.UseSystemPasswordChar = false;
        }
    }
}
