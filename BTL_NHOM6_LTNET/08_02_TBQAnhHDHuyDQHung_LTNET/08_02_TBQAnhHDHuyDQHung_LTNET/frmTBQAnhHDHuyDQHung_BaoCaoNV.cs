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
    public partial class frmTBQAnhHDHuyDQHung_BaoCaoNV : Form
    {
        public frmTBQAnhHDHuyDQHung_BaoCaoNV()
        {
            InitializeComponent();
        }

        private void frmBaoCaoNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlnh_08_TBQAnhHDHuyDQHungDataSet2.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter1.Fill(this.qlnh_08_TBQAnhHDHuyDQHungDataSet2.nhanvien);
            // TODO: This line of code loads data into the 'qlnh_08_TBQAnhHDHuyDQHungDataSet1.nhanvien' table. You can move, or remove it, as needed.
            //this.nhanvienTableAdapter.Fill(this.qlnh_08_TBQAnhHDHuyDQHungDataSet1.nhanvien);
            this.rpNhanVien.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }

        private void rpNhanVien_Load(object sender, EventArgs e)
        {
        }
    }
}
