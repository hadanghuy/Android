namespace _08_02_TBQAnhHDHuyDQHung_LTNET
{
    partial class frmTBQAnhHDHuyDQHung_BaoCaoNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTBQAnhHDHuyDQHung_BaoCaoNV));
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlnh08TBQAnhHDHuyDQHungDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet1 = new _08_02_TBQAnhHDHuyDQHung_LTNET.qlnh_08_TBQAnhHDHuyDQHungDataSet1();
            this.rpNhanVien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet = new _08_02_TBQAnhHDHuyDQHung_LTNET.qlnh_08_TBQAnhHDHuyDQHungDataSet();
            this.qlnh08TBQAnhHDHuyDQHungDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new _08_02_TBQAnhHDHuyDQHung_LTNET.qlnh_08_TBQAnhHDHuyDQHungDataSet1TableAdapters.nhanvienTableAdapter();
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet2 = new _08_02_TBQAnhHDHuyDQHung_LTNET.qlnh_08_TBQAnhHDHuyDQHungDataSet2();
            this.nhanvienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter1 = new _08_02_TBQAnhHDHuyDQHung_LTNET.qlnh_08_TBQAnhHDHuyDQHungDataSet2TableAdapters.nhanvienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh08TBQAnhHDHuyDQHungDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh_08_TBQAnhHDHuyDQHungDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh_08_TBQAnhHDHuyDQHungDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh08TBQAnhHDHuyDQHungDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh_08_TBQAnhHDHuyDQHungDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            this.nhanvienBindingSource.DataSource = this.qlnh08TBQAnhHDHuyDQHungDataSet1BindingSource;
            // 
            // qlnh08TBQAnhHDHuyDQHungDataSet1BindingSource
            // 
            this.qlnh08TBQAnhHDHuyDQHungDataSet1BindingSource.DataSource = this.qlnh_08_TBQAnhHDHuyDQHungDataSet1;
            this.qlnh08TBQAnhHDHuyDQHungDataSet1BindingSource.Position = 0;
            // 
            // qlnh_08_TBQAnhHDHuyDQHungDataSet1
            // 
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet1.DataSetName = "qlnh_08_TBQAnhHDHuyDQHungDataSet1";
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpNhanVien
            // 
            this.rpNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nhanvienBindingSource1;
            this.rpNhanVien.LocalReport.DataSources.Add(reportDataSource1);
            this.rpNhanVien.LocalReport.ReportEmbeddedResource = "_08_02_TBQAnhHDHuyDQHung_LTNET.rpBaoCaoNV.rdlc";
            this.rpNhanVien.Location = new System.Drawing.Point(0, 0);
            this.rpNhanVien.Name = "rpNhanVien";
            this.rpNhanVien.ServerReport.BearerToken = null;
            this.rpNhanVien.Size = new System.Drawing.Size(1326, 718);
            this.rpNhanVien.TabIndex = 0;
            this.rpNhanVien.Load += new System.EventHandler(this.rpNhanVien_Load);
            // 
            // qlnh_08_TBQAnhHDHuyDQHungDataSet
            // 
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet.DataSetName = "qlnh_08_TBQAnhHDHuyDQHungDataSet";
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlnh08TBQAnhHDHuyDQHungDataSetBindingSource
            // 
            this.qlnh08TBQAnhHDHuyDQHungDataSetBindingSource.DataSource = this.qlnh_08_TBQAnhHDHuyDQHungDataSet;
            this.qlnh08TBQAnhHDHuyDQHungDataSetBindingSource.Position = 0;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // qlnh_08_TBQAnhHDHuyDQHungDataSet2
            // 
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet2.DataSetName = "qlnh_08_TBQAnhHDHuyDQHungDataSet2";
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienBindingSource1
            // 
            this.nhanvienBindingSource1.DataMember = "nhanvien";
            this.nhanvienBindingSource1.DataSource = this.qlnh_08_TBQAnhHDHuyDQHungDataSet2;
            // 
            // nhanvienTableAdapter1
            // 
            this.nhanvienTableAdapter1.ClearBeforeFill = true;
            // 
            // frmTBQAnhHDHuyDQHung_BaoCaoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 718);
            this.Controls.Add(this.rpNhanVien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTBQAnhHDHuyDQHung_BaoCaoNV";
            this.Text = "Báo Cáo Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCaoNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh08TBQAnhHDHuyDQHungDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh_08_TBQAnhHDHuyDQHungDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh_08_TBQAnhHDHuyDQHungDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh08TBQAnhHDHuyDQHungDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh_08_TBQAnhHDHuyDQHungDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpNhanVien;
        private System.Windows.Forms.BindingSource qlnh08TBQAnhHDHuyDQHungDataSetBindingSource;
        private qlnh_08_TBQAnhHDHuyDQHungDataSet qlnh_08_TBQAnhHDHuyDQHungDataSet;
        private System.Windows.Forms.BindingSource qlnh08TBQAnhHDHuyDQHungDataSet1BindingSource;
        private qlnh_08_TBQAnhHDHuyDQHungDataSet1 qlnh_08_TBQAnhHDHuyDQHungDataSet1;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private qlnh_08_TBQAnhHDHuyDQHungDataSet1TableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
        private qlnh_08_TBQAnhHDHuyDQHungDataSet2 qlnh_08_TBQAnhHDHuyDQHungDataSet2;
        private System.Windows.Forms.BindingSource nhanvienBindingSource1;
        private qlnh_08_TBQAnhHDHuyDQHungDataSet2TableAdapters.nhanvienTableAdapter nhanvienTableAdapter1;
    }
}