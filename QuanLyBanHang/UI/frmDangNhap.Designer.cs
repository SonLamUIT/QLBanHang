namespace UI
{
    partial class frmDangNhap
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbxTenDangNhap = new MetroFramework.Controls.MetroTextBox();
            this.tbxMatKhau = new MetroFramework.Controls.MetroTextBox();
            this.btThoat = new MetroFramework.Controls.MetroButton();
            this.btDangNhap = new MetroFramework.Controls.MetroButton();
            this.lbTinhTrang = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tên Đăng Nhập";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(43, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Mật Khẩu";
            // 
            // tbxTenDangNhap
            // 
            this.tbxTenDangNhap.Lines = new string[0];
            this.tbxTenDangNhap.Location = new System.Drawing.Point(149, 76);
            this.tbxTenDangNhap.MaxLength = 32767;
            this.tbxTenDangNhap.Name = "tbxTenDangNhap";
            this.tbxTenDangNhap.PasswordChar = '\0';
            this.tbxTenDangNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxTenDangNhap.SelectedText = "";
            this.tbxTenDangNhap.Size = new System.Drawing.Size(270, 23);
            this.tbxTenDangNhap.TabIndex = 1;
            this.tbxTenDangNhap.UseSelectable = true;
            // 
            // tbxMatKhau
            // 
            this.tbxMatKhau.Lines = new string[0];
            this.tbxMatKhau.Location = new System.Drawing.Point(149, 114);
            this.tbxMatKhau.MaxLength = 32767;
            this.tbxMatKhau.Name = "tbxMatKhau";
            this.tbxMatKhau.PasswordChar = '*';
            this.tbxMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxMatKhau.SelectedText = "";
            this.tbxMatKhau.Size = new System.Drawing.Size(270, 23);
            this.tbxMatKhau.TabIndex = 2;
            this.tbxMatKhau.UseSelectable = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(257, 179);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseSelectable = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(176, 179);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btDangNhap.TabIndex = 3;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.UseSelectable = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Location = new System.Drawing.Point(90, 150);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(0, 0);
            this.lbTinhTrang.TabIndex = 5;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 225);
            this.Controls.Add(this.lbTinhTrang);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.tbxMatKhau);
            this.Controls.Add(this.tbxTenDangNhap);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmDangNhap";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbxTenDangNhap;
        private MetroFramework.Controls.MetroTextBox tbxMatKhau;
        private MetroFramework.Controls.MetroButton btThoat;
        private MetroFramework.Controls.MetroButton btDangNhap;
        private MetroFramework.Controls.MetroLabel lbTinhTrang;
    }
}