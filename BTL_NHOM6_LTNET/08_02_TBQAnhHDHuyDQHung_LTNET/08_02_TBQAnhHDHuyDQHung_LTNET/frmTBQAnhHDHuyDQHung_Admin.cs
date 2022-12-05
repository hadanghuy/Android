using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;// khai báo thư viện này dùng để siuwr dụng các đối tượng và phương thức của sqlclient
using System.Diagnostics;// khai báo thư viện để sử dụng phương thức process để mở các ứng dụng như word, excel, paint

/*
 * Tên nhóm: TBQAnhHDHuyDQHung_08_QLNH
 * Họ và tên thành viên - MSV - Lớp
 * Tống Bá Quang Anh - 19103100162 - DHTI13A2HN
 * Hà Đăng Huy - 19103100085 - DHTI13A2HN
 * Đinh Quang Hưng - 19103100082 - DHTI13A2HN
 */

namespace _08_02_TBQAnhHDHuyDQHung_LTNET
{
    public partial class frmTBQAnhHDHuyDQHung_Admin : Form
    {
        SqlConnection sqlCon;
        DataTable dataTable = new DataTable();

        public frmTBQAnhHDHuyDQHung_Admin()
        {
            InitializeComponent();
        }

        // Hệ thống
        public void setMenu()
        {
            if (csLoginSession.getMod().getMod().Equals("User"))
            {
                quảnLýTàiKhoảnToolStripMenuItem.Visible = false;//phần này tối sẽ hỏi
            }
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_QuanLyTaiKhoan fQLTK = new frmTBQAnhHDHuyDQHung_QuanLyTaiKhoan();
            fQLTK.Show();
            this.Hide();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_DoiMatKhau fDMK = new frmTBQAnhHDHuyDQHung_DoiMatKhau();
            fDMK.getUsername();
            fDMK.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();// ngoài cách dùng thế này để đóng hoàn toàn form thì vẫn còn cách thứ hai dùng đối dượng this.Close();
        }

        // Menu Tiện ích
        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.EXE");// dùng đối tượng Process.Start để mở một file mới đến ứng dụng đó cụ thể ở đây là word
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("EXCEL.EXE");//// dùng đối tượng Process.Start để mở một file mới đến ứng dụng đó cụ thể ở đây là excel
        }
        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");// dùng đối tượng Process.Start để mở một file mới đến ứng dụng đó cụ thể ở đây là paint
        }

        // Menu Trợ giúp
        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_ThongTinTacGia fTacgia = new frmTBQAnhHDHuyDQHung_ThongTinTacGia();
            fTacgia.Show();
            this.Hide();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_HuongDanSD fHuongdan = new frmTBQAnhHDHuyDQHung_HuongDanSD();
            this.Hide();
            fHuongdan.Show();
        }

        private void bảnQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản N08.0.0.1", "Phiên bản", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Menu Quản Lý
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_QuanLyNhanVien fQLNV = new frmTBQAnhHDHuyDQHung_QuanLyNhanVien();//dùng để gọi đến form cần gọi
            fQLNV.Show();
            this.Hide();
        }
        //.Showdialog();
        //thì ko cho phép người sử dụng dùng form khác trừ khi nó
        //đóng lại.
        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_QuanLyPhongBan fQLPB = new frmTBQAnhHDHuyDQHung_QuanLyPhongBan();
            fQLPB.Show();
            this.Hide();
        }

        // Menu Báo Cáo
        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_BaoCaoNV frpNV = new frmTBQAnhHDHuyDQHung_BaoCaoNV();
            frpNV.Show();
            this.Hide();
        }

        private void phòngBanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_BaoCaoPB frpPB = new frmTBQAnhHDHuyDQHung_BaoCaoPB();//child Form dùng để gọi đến from
                                                                                      ////báo cáo phòng ban, hay chính là các form cần gọi đến
            frpPB.Show();//Dùng đển mở form đó, trong trường hợp dùng phuwong thức show này thì khi chạy cho phép sử dụng form khác kể cả chưa đóng lại
                         //Cách thứ hai dùng phuwong thức frpB.Showdialog();
                         //Cách này khi thực hiện thì ko cho phép người sử dụng dùng form khác trừ khi nó
            //đóng lại.
            this.Hide();
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

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
