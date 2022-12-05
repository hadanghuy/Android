namespace _08_02_TBQAnhHDHuyDQHung_LTNET
{
    partial class frmTBQAnhHDHuyDQHung_Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTBQAnhHDHuyDQHung_Dangnhap));
            this.ptbAccount = new System.Windows.Forms.PictureBox();
            this.ptbPassword = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbQuyen = new System.Windows.Forms.ComboBox();
            this.dangnhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet = new _08_02_TBQAnhHDHuyDQHung_LTNET.qlnh_08_TBQAnhHDHuyDQHungDataSet();
            this.dangnhapTableAdapter = new _08_02_TBQAnhHDHuyDQHung_LTNET.qlnh_08_TBQAnhHDHuyDQHungDataSetTableAdapters.dangnhapTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.chkHienthiMK = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangnhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh_08_TBQAnhHDHuyDQHungDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbAccount
            // 
            this.ptbAccount.BackColor = System.Drawing.Color.Transparent;
            this.ptbAccount.Image = ((System.Drawing.Image)(resources.GetObject("ptbAccount.Image")));
            this.ptbAccount.Location = new System.Drawing.Point(97, 246);
            this.ptbAccount.Margin = new System.Windows.Forms.Padding(4);
            this.ptbAccount.Name = "ptbAccount";
            this.ptbAccount.Size = new System.Drawing.Size(51, 47);
            this.ptbAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAccount.TabIndex = 0;
            this.ptbAccount.TabStop = false;
            // 
            // ptbPassword
            // 
            this.ptbPassword.BackColor = System.Drawing.Color.Transparent;
            this.ptbPassword.Image = ((System.Drawing.Image)(resources.GetObject("ptbPassword.Image")));
            this.ptbPassword.Location = new System.Drawing.Point(97, 311);
            this.ptbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ptbPassword.Name = "ptbPassword";
            this.ptbPassword.Size = new System.Drawing.Size(51, 45);
            this.ptbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPassword.TabIndex = 1;
            this.ptbPassword.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(184, 246);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(455, 47);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(184, 311);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(455, 45);
            this.txtPass.TabIndex = 1;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Location = new System.Drawing.Point(229, 463);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(172, 47);
            this.btnDangnhap.TabIndex = 3;
            this.btnDangnhap.Text = "Đăng Nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.PowderBlue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(477, 463);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(162, 47);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbQuyen
            // 
            this.cbQuyen.BackColor = System.Drawing.Color.White;
            this.cbQuyen.DropDownHeight = 200;
            this.cbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.IntegralHeight = false;
            this.cbQuyen.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cbQuyen.Location = new System.Drawing.Point(477, 375);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(162, 24);
            this.cbQuyen.TabIndex = 2;
            // 
            // dangnhapBindingSource
            // 
            this.dangnhapBindingSource.DataMember = "dangnhap";
            this.dangnhapBindingSource.DataSource = this.qlnh_08_TBQAnhHDHuyDQHungDataSet;
            // 
            // qlnh_08_TBQAnhHDHuyDQHungDataSet
            // 
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet.DataSetName = "qlnh_08_TBQAnhHDHuyDQHungDataSet";
            this.qlnh_08_TBQAnhHDHuyDQHungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dangnhapTableAdapter
            // 
            this.dangnhapTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quyền Đăng Nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkHienthiMK
            // 
            this.chkHienthiMK.AutoSize = true;
            this.chkHienthiMK.BackColor = System.Drawing.Color.Transparent;
            this.chkHienthiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienthiMK.ForeColor = System.Drawing.Color.White;
            this.chkHienthiMK.Location = new System.Drawing.Point(477, 421);
            this.chkHienthiMK.Name = "chkHienthiMK";
            this.chkHienthiMK.Size = new System.Drawing.Size(162, 24);
            this.chkHienthiMK.TabIndex = 6;
            this.chkHienthiMK.Text = "Hiển thị mật khẩu";
            this.chkHienthiMK.UseVisualStyleBackColor = false;
            this.chkHienthiMK.CheckedChanged += new System.EventHandler(this.chkHienthiMK_CheckedChanged);
            // 
            // frmTBQAnhHDHuyDQHung_Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 553);
            this.Controls.Add(this.chkHienthiMK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbQuyen);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.ptbPassword);
            this.Controls.Add(this.ptbAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(824, 600);
            this.Name = "frmTBQAnhHDHuyDQHung_Dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLNH - 08 - TBQAnhHDHuyDQHung - Trang Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangnhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnh_08_TBQAnhHDHuyDQHungDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAccount;
        private System.Windows.Forms.PictureBox ptbPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbQuyen;
        private qlnh_08_TBQAnhHDHuyDQHungDataSet qlnh_08_TBQAnhHDHuyDQHungDataSet;
        private System.Windows.Forms.BindingSource dangnhapBindingSource;
        private qlnh_08_TBQAnhHDHuyDQHungDataSetTableAdapters.dangnhapTableAdapter dangnhapTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkHienthiMK;
    }
}

