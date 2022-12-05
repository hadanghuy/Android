namespace _08_02_TBQAnhHDHuyDQHung_LTNET
{
    partial class frmTBQAnhHDHuyDQHung_TimKiemNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTBQAnhHDHuyDQHung_TimKiemNhanVien));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_QuanLyNhanVien = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nambatdaulv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxTimquequan = new System.Windows.Forms.TextBox();
            this.checkBoxTimquequan = new System.Windows.Forms.CheckBox();
            this.textBoxTimTen = new System.Windows.Forms.TextBox();
            this.checkBoxTimTen = new System.Windows.Forms.CheckBox();
            this.btnFullNV = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuanLyNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_QuanLyNhanVien);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1823, 491);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin nhân viên";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridView_QuanLyNhanVien
            // 
            this.dataGridView_QuanLyNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_QuanLyNhanVien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_QuanLyNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QuanLyNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.hoten,
            this.ngaysinh,
            this.gioitinh,
            this.quequan,
            this.nambatdaulv,
            this.luong,
            this.mapb});
            this.dataGridView_QuanLyNhanVien.Location = new System.Drawing.Point(93, 54);
            this.dataGridView_QuanLyNhanVien.Name = "dataGridView_QuanLyNhanVien";
            this.dataGridView_QuanLyNhanVien.ReadOnly = true;
            this.dataGridView_QuanLyNhanVien.RowHeadersWidth = 51;
            this.dataGridView_QuanLyNhanVien.RowTemplate.Height = 24;
            this.dataGridView_QuanLyNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_QuanLyNhanVien.Size = new System.Drawing.Size(1666, 281);
            this.dataGridView_QuanLyNhanVien.TabIndex = 0;
            this.dataGridView_QuanLyNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_QuanLyNhanVien_CellContentClick);
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.FillWeight = 25.66844F;
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            this.manv.Width = 186;
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.hoten.DataPropertyName = "hoten";
            this.hoten.FillWeight = 620.3209F;
            this.hoten.HeaderText = "Họ và tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 240;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.FillWeight = 25.66844F;
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            this.ngaysinh.Width = 187;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.FillWeight = 25.66844F;
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            this.gioitinh.Width = 160;
            // 
            // quequan
            // 
            this.quequan.DataPropertyName = "quequan";
            this.quequan.FillWeight = 25.66844F;
            this.quequan.HeaderText = "Quê quán";
            this.quequan.MinimumWidth = 6;
            this.quequan.Name = "quequan";
            this.quequan.ReadOnly = true;
            this.quequan.Width = 180;
            // 
            // nambatdaulv
            // 
            this.nambatdaulv.DataPropertyName = "nambatdaulv";
            this.nambatdaulv.FillWeight = 25.66844F;
            this.nambatdaulv.HeaderText = "Năm bắt đầu làm việc";
            this.nambatdaulv.MinimumWidth = 6;
            this.nambatdaulv.Name = "nambatdaulv";
            this.nambatdaulv.ReadOnly = true;
            this.nambatdaulv.Width = 300;
            // 
            // luong
            // 
            this.luong.DataPropertyName = "luong";
            this.luong.FillWeight = 25.66844F;
            this.luong.HeaderText = "Lương";
            this.luong.MinimumWidth = 6;
            this.luong.Name = "luong";
            this.luong.ReadOnly = true;
            this.luong.Width = 160;
            // 
            // mapb
            // 
            this.mapb.DataPropertyName = "mapb";
            this.mapb.FillWeight = 25.66844F;
            this.mapb.HeaderText = "Mã phòng ban";
            this.mapb.MinimumWidth = 6;
            this.mapb.Name = "mapb";
            this.mapb.ReadOnly = true;
            this.mapb.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(569, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÌM KIẾM THÔNG TIN NHÂN VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.textBoxTimquequan);
            this.groupBox1.Controls.Add(this.checkBoxTimquequan);
            this.groupBox1.Controls.Add(this.textBoxTimTen);
            this.groupBox1.Controls.Add(this.checkBoxTimTen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(627, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng tìm kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(544, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 94);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxTimquequan
            // 
            this.textBoxTimquequan.Location = new System.Drawing.Point(213, 73);
            this.textBoxTimquequan.Name = "textBoxTimquequan";
            this.textBoxTimquequan.Size = new System.Drawing.Size(310, 30);
            this.textBoxTimquequan.TabIndex = 3;
            // 
            // checkBoxTimquequan
            // 
            this.checkBoxTimquequan.AutoSize = true;
            this.checkBoxTimquequan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTimquequan.Location = new System.Drawing.Point(6, 78);
            this.checkBoxTimquequan.Name = "checkBoxTimquequan";
            this.checkBoxTimquequan.Size = new System.Drawing.Size(169, 24);
            this.checkBoxTimquequan.TabIndex = 2;
            this.checkBoxTimquequan.Text = "Tìm theo quê quán";
            this.checkBoxTimquequan.UseVisualStyleBackColor = true;
            this.checkBoxTimquequan.CheckedChanged += new System.EventHandler(this.checkBoxTimquequan_CheckedChanged);
            // 
            // textBoxTimTen
            // 
            this.textBoxTimTen.Location = new System.Drawing.Point(213, 35);
            this.textBoxTimTen.Name = "textBoxTimTen";
            this.textBoxTimTen.Size = new System.Drawing.Size(310, 30);
            this.textBoxTimTen.TabIndex = 1;
            // 
            // checkBoxTimTen
            // 
            this.checkBoxTimTen.AutoSize = true;
            this.checkBoxTimTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTimTen.Location = new System.Drawing.Point(6, 40);
            this.checkBoxTimTen.Name = "checkBoxTimTen";
            this.checkBoxTimTen.Size = new System.Drawing.Size(164, 24);
            this.checkBoxTimTen.TabIndex = 0;
            this.checkBoxTimTen.Text = "Tìm kiếm theo tên";
            this.checkBoxTimTen.UseVisualStyleBackColor = true;
            this.checkBoxTimTen.CheckedChanged += new System.EventHandler(this.checkBoxTimTen_CheckedChanged);
            // 
            // btnFullNV
            // 
            this.btnFullNV.BackColor = System.Drawing.Color.AliceBlue;
            this.btnFullNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFullNV.Location = new System.Drawing.Point(337, 225);
            this.btnFullNV.Name = "btnFullNV";
            this.btnFullNV.Size = new System.Drawing.Size(198, 45);
            this.btnFullNV.TabIndex = 14;
            this.btnFullNV.Text = "Danh sách đầy đủ";
            this.btnFullNV.UseVisualStyleBackColor = false;
            this.btnFullNV.Click += new System.EventHandler(this.btnFullNV_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.AliceBlue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Location = new System.Drawing.Point(577, 225);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(143, 45);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTBQAnhHDHuyDQHung_TimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1912, 750);
            this.Controls.Add(this.btnFullNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTBQAnhHDHuyDQHung_TimKiemNhanVien";
            this.Text = "QLNH - 08 - TBQAnhHDHuyDQHung - Tìm Kiếm Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimKiemNhanVien_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuanLyNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_QuanLyNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nambatdaulv;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxTimquequan;
        private System.Windows.Forms.CheckBox checkBoxTimquequan;
        private System.Windows.Forms.TextBox textBoxTimTen;
        private System.Windows.Forms.CheckBox checkBoxTimTen;
        private System.Windows.Forms.Button btnFullNV;
        private System.Windows.Forms.Button btnThoat;
    }
}