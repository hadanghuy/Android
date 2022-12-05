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
    public partial class frmTBQAnhHDHuyDQHung_TimKiemPhongBan : Form
    {
        SqlConnection sqlCon;
        SqlDataAdapter sqlDa;
        DataSet dataSet;
        DataTable dataTable = new DataTable();

        public frmTBQAnhHDHuyDQHung_TimKiemPhongBan()
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

        private void frmTimKiemPhongBan_Load(object sender, EventArgs e)
        {
            connect();
            //B1: Tạo câu lệnh truy vấn
            string sql;
            sql = "SELECT * FROM phongban";
            //B2: Tạo cầu nối dữ liệu
            sqlDa = new SqlDataAdapter(sql, sqlCon);
            //B3: Tạo dataset
            dataSet = new DataSet();
            //B4: Điền dữ liệu
            sqlDa.Fill(dataSet);
            //B5: Hiển thị dữ liệu
            dgvQLPB.DataSource = dataSet.Tables[0];
            dgvQLPB.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvQLPB.RowTemplate.Height = 30;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtTimPB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên phòng cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sqlSearch = "SELECT * FROM phongban WHERE tenpb LIKE N'%" + txtTimPB.Text + "%'";
                SqlCommand sqlCom = new SqlCommand(sqlSearch, sqlCon);
                sqlCom.ExecuteNonQuery();
                SqlDataReader sqlDataReader = sqlCom.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                dgvQLPB.DataSource = dt;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFullPB_Click(object sender, EventArgs e)
        {
            frmTimKiemPhongBan_Load(sender,e);
        }
    }
}
