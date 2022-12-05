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
using System.Diagnostics;

namespace _08_02_TBQAnhHDHuyDQHung_LTNET
{
    public partial class frmTBQAnhHDHuyDQHung_User : Form
    {
        public frmTBQAnhHDHuyDQHung_User()
        {
            InitializeComponent();
        }

        // Hệ thống
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_DoiMatKhau fDMK = new frmTBQAnhHDHuyDQHung_DoiMatKhau();
            fDMK.ShowDialog();
            this.Hide();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Quản Lý
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_QuanLyNhanVien fQLNV = new frmTBQAnhHDHuyDQHung_QuanLyNhanVien();
            fQLNV.ShowDialog();
            this.Hide();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_QuanLyPhongBan fQLPB = new frmTBQAnhHDHuyDQHung_QuanLyPhongBan();
            fQLPB.ShowDialog();
            this.Hide();
        }

        // Báo cáo
        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_BaoCaoNV frpNV = new frmTBQAnhHDHuyDQHung_BaoCaoNV();
            frpNV.ShowDialog();
            this.Hide();
        }

        private void phòngBanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_BaoCaoPB frpPB = new frmTBQAnhHDHuyDQHung_BaoCaoPB();
            frpPB.ShowDialog();
            this.Hide();
        }

        // Tiện ích
        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.EXE");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("EXCEL.EXE");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        // Trợ giúp
        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTBQAnhHDHuyDQHung_ThongTinTacGia fTacgia = new frmTBQAnhHDHuyDQHung_ThongTinTacGia();
            fTacgia.ShowDialog();
            this.Hide();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bảnQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản N08.0.0.1", "Phiên bản", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
