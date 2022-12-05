namespace _08_02_TBQAnhHDHuyDQHung_LTNET
{
    partial class frmTBQAnhHDHuyDQHung_BaoCaoPB
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
            this.phongbanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet = new _08_02_TBQAnhHDHuyDQHung_LTNET.qlnh_08_TBQAnhHDHuyDQHungDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.phongbanTableAdapter = new _08_02_TBQAnhHDHuyDQHung_LTNET.qlnh_08_TBQAnhHDHuyDQHungDataSetTableAdapters.phongbanTableAdapter();
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet3 = new _08_02_TBQAnhHDHuyDQHung_LTNET.qlnh_08_TBQAnhHDHuyDQHungDataSet3();
            this.phongbanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phongbanTableAdapter1 = new _08_02_TBQAnhHDHuyDQHung_LTNET.qlnh_08_TBQAnhHDHuyDQHungDataSet3TableAdapters.phongbanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh_08_TBQAnhHDHuyDQHungDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh_08_TBQAnhHDHuyDQHungDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // phongbanBindingSource
            // 
            this.phongbanBindingSource.DataMember = "phongban";
            this.phongbanBindingSource.DataSource = this.qlnh_08_TBQAnhHDHuyDQHungDataSet;
            // 
            // qlnh_08_TBQAnhHDHuyDQHungDataSet
            // 
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet.DataSetName = "qlnh_08_TBQAnhHDHuyDQHungDataSet";
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.phongbanBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_08_02_TBQAnhHDHuyDQHung_LTNET.rpBaoCaoPB.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1282, 616);
            this.reportViewer1.TabIndex = 0;
            // 
            // phongbanTableAdapter
            // 
            this.phongbanTableAdapter.ClearBeforeFill = true;
            // 
            // qlnh_08_TBQAnhHDHuyDQHungDataSet3
            // 
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet3.DataSetName = "qlnh_08_TBQAnhHDHuyDQHungDataSet3";
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phongbanBindingSource1
            // 
            this.phongbanBindingSource1.DataMember = "phongban";
            this.phongbanBindingSource1.DataSource = this.qlnh_08_TBQAnhHDHuyDQHungDataSet3;
            // 
            // phongbanTableAdapter1
            // 
            this.phongbanTableAdapter1.ClearBeforeFill = true;
            // 
            // frmTBQAnhHDHuyDQHung_BaoCaoPB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 616);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmTBQAnhHDHuyDQHung_BaoCaoPB";
            this.Text = "Báo Cáo Phòng Ban";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCaoPB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh_08_TBQAnhHDHuyDQHungDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh_08_TBQAnhHDHuyDQHungDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private qlnh_08_TBQAnhHDHuyDQHungDataSet qlnh_08_TBQAnhHDHuyDQHungDataSet;
        private System.Windows.Forms.BindingSource phongbanBindingSource;
        private qlnh_08_TBQAnhHDHuyDQHungDataSetTableAdapters.phongbanTableAdapter phongbanTableAdapter;
        private qlnh_08_TBQAnhHDHuyDQHungDataSet3 qlnh_08_TBQAnhHDHuyDQHungDataSet3;
        private System.Windows.Forms.BindingSource phongbanBindingSource1;
        private qlnh_08_TBQAnhHDHuyDQHungDataSet3TableAdapters.phongbanTableAdapter phongbanTableAdapter1;
    }
}