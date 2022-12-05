using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_02_TBQAnhHDHuyDQHung_LTNET
{
    public partial class frmTBQAnhHDHuyDQHung_BaoCaoPB : Form
    {
        public frmTBQAnhHDHuyDQHung_BaoCaoPB()
        {
            InitializeComponent();
        }

        private void frmBaoCaoPB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlnh_08_TBQAnhHDHuyDQHungDataSet3.phongban' table. You can move, or remove it, as needed.
            this.phongbanTableAdapter1.Fill(this.qlnh_08_TBQAnhHDHuyDQHungDataSet3.phongban);
            // TODO: This line of code loads data into the 'qlnh_08_TBQAnhHDHuyDQHungDataSet.phongban' table. You can move, or remove it, as needed.
            //this.phongbanTableAdapter.Fill(this.qlnh_08_TBQAnhHDHuyDQHungDataSet.phongban);

            this.reportViewer1.RefreshReport();
        }
    }
}
