namespace _08_02_TBQAnhHDHuyDQHung_LTNET
{
    partial class frmTBQAnhHDHuyDQHung_TimKiemPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTBQAnhHDHuyDQHung_TimKiemPhongBan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTimPB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvQLPB = new System.Windows.Forms.DataGridView();
            this.mapb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenpb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailpb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnFullPB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLPB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtTimPB);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(547, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 102);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập tên phòng ban";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(652, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 50);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTimPB
            // 
            this.txtTimPB.Location = new System.Drawing.Point(236, 34);
            this.txtTimPB.Multiline = true;
            this.txtTimPB.Name = "txtTimPB";
            this.txtTimPB.Size = new System.Drawing.Size(391, 50);
            this.txtTimPB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(443, -63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "TÌM KIẾM THÔNG TIN NHÂN VIÊN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvQLPB);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(243, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1428, 505);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các phòng ban";
            // 
            // dgvQLPB
            // 
            this.dgvQLPB.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvQLPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLPB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapb,
            this.tenpb,
            this.emailpb,
            this.dienthoai});
            this.dgvQLPB.Location = new System.Drawing.Point(83, 48);
            this.dgvQLPB.Name = "dgvQLPB";
            this.dgvQLPB.ReadOnly = true;
            this.dgvQLPB.RowHeadersWidth = 51;
            this.dgvQLPB.RowTemplate.Height = 24;
            this.dgvQLPB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLPB.Size = new System.Drawing.Size(1254, 436);
            this.dgvQLPB.TabIndex = 1;
            // 
            // mapb
            // 
            this.mapb.DataPropertyName = "mapb";
            this.mapb.HeaderText = "Mã phòng ban";
            this.mapb.MinimumWidth = 6;
            this.mapb.Name = "mapb";
            this.mapb.ReadOnly = true;
            this.mapb.Width = 200;
            // 
            // tenpb
            // 
            this.tenpb.DataPropertyName = "tenpb";
            this.tenpb.HeaderText = "Tên phòng ban";
            this.tenpb.MinimumWidth = 6;
            this.tenpb.Name = "tenpb";
            this.tenpb.ReadOnly = true;
            this.tenpb.Width = 240;
            // 
            // emailpb
            // 
            this.emailpb.DataPropertyName = "emailpb";
            this.emailpb.HeaderText = "Email phòng ban";
            this.emailpb.MinimumWidth = 6;
            this.emailpb.Name = "emailpb";
            this.emailpb.ReadOnly = true;
            this.emailpb.Width = 300;
            // 
            // dienthoai
            // 
            this.dienthoai.DataPropertyName = "dienthoai";
            this.dienthoai.HeaderText = "Điện thoại";
            this.dienthoai.MinimumWidth = 6;
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.ReadOnly = true;
            this.dienthoai.Width = 260;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Blue;
            this.btnThoat.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Location = new System.Drawing.Point(768, 207);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 42);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnFullPB
            // 
            this.btnFullPB.BackColor = System.Drawing.Color.Blue;
            this.btnFullPB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullPB.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFullPB.Location = new System.Drawing.Point(547, 207);
            this.btnFullPB.Name = "btnFullPB";
            this.btnFullPB.Size = new System.Drawing.Size(202, 42);
            this.btnFullPB.TabIndex = 12;
            this.btnFullPB.Text = "Danh sách đầy đủ";
            this.btnFullPB.UseVisualStyleBackColor = false;
            this.btnFullPB.Click += new System.EventHandler(this.btnFullPB_Click);
            // 
            // frmTBQAnhHDHuyDQHung_TimKiemPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1743, 845);
            this.Controls.Add(this.btnFullPB);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTBQAnhHDHuyDQHung_TimKiemPhongBan";
            this.Text = "QLNH - 08 - TBQAnhHDHuyDQHung - Tìm Kiếm Phòng Ban";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimKiemPhongBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTimPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvQLPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenpb;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailpb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFullPB;
    }
}