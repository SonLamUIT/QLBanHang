namespace UI.UIPhieuNhapHang
{
    partial class UILapChiTietPhieuNhapHang
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
            this.cbSoPhieuNhapHang = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbMaMatHang = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbSoLuongChuaNhap = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbSoLuongNhap = new MetroFramework.Controls.MetroTextBox();
            this.tbDonGiaNhap = new MetroFramework.Controls.MetroTextBox();
            this.tbThanhTien = new MetroFramework.Controls.MetroTextBox();
            this.btLuu = new MetroFramework.Controls.MetroButton();
            this.btDanhSachMatHang = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Số Phiếu Nhập Hàng";
            // 
            // cbSoPhieuNhapHang
            // 
            this.cbSoPhieuNhapHang.FormattingEnabled = true;
            this.cbSoPhieuNhapHang.Location = new System.Drawing.Point(188, 63);
            this.cbSoPhieuNhapHang.Name = "cbSoPhieuNhapHang";
            this.cbSoPhieuNhapHang.Size = new System.Drawing.Size(121, 21);
            this.cbSoPhieuNhapHang.TabIndex = 1;
            this.cbSoPhieuNhapHang.SelectedIndexChanged += new System.EventHandler(this.cbSoPhieuNhapHang_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Mã Mặt Hàng";
            // 
            // cbMaMatHang
            // 
            this.cbMaMatHang.FormattingEnabled = true;
            this.cbMaMatHang.Location = new System.Drawing.Point(188, 90);
            this.cbMaMatHang.Name = "cbMaMatHang";
            this.cbMaMatHang.Size = new System.Drawing.Size(121, 21);
            this.cbMaMatHang.TabIndex = 1;
            this.cbMaMatHang.SelectedIndexChanged += new System.EventHandler(this.cbMaMatHang_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(136, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Số Lượng Chưa Nhập";
            // 
            // tbSoLuongChuaNhap
            // 
            this.tbSoLuongChuaNhap.Lines = new string[0];
            this.tbSoLuongChuaNhap.Location = new System.Drawing.Point(188, 117);
            this.tbSoLuongChuaNhap.MaxLength = 32767;
            this.tbSoLuongChuaNhap.Name = "tbSoLuongChuaNhap";
            this.tbSoLuongChuaNhap.PasswordChar = '\0';
            this.tbSoLuongChuaNhap.ReadOnly = true;
            this.tbSoLuongChuaNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSoLuongChuaNhap.SelectedText = "";
            this.tbSoLuongChuaNhap.Size = new System.Drawing.Size(315, 23);
            this.tbSoLuongChuaNhap.TabIndex = 4;
            this.tbSoLuongChuaNhap.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 150);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(101, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Số Lượng Nhập";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 179);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Đơn Giá Nhập";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 208);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Thành Tiền";
            // 
            // tbSoLuongNhap
            // 
            this.tbSoLuongNhap.Lines = new string[0];
            this.tbSoLuongNhap.Location = new System.Drawing.Point(188, 146);
            this.tbSoLuongNhap.MaxLength = 32767;
            this.tbSoLuongNhap.Name = "tbSoLuongNhap";
            this.tbSoLuongNhap.PasswordChar = '\0';
            this.tbSoLuongNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSoLuongNhap.SelectedText = "";
            this.tbSoLuongNhap.Size = new System.Drawing.Size(315, 23);
            this.tbSoLuongNhap.TabIndex = 4;
            this.tbSoLuongNhap.UseSelectable = true;
            this.tbSoLuongNhap.TextChanged += new System.EventHandler(this.tbSoLuongNhap_TextChanged);
            // 
            // tbDonGiaNhap
            // 
            this.tbDonGiaNhap.Lines = new string[0];
            this.tbDonGiaNhap.Location = new System.Drawing.Point(188, 175);
            this.tbDonGiaNhap.MaxLength = 32767;
            this.tbDonGiaNhap.Name = "tbDonGiaNhap";
            this.tbDonGiaNhap.PasswordChar = '\0';
            this.tbDonGiaNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDonGiaNhap.SelectedText = "";
            this.tbDonGiaNhap.Size = new System.Drawing.Size(315, 23);
            this.tbDonGiaNhap.TabIndex = 4;
            this.tbDonGiaNhap.UseSelectable = true;
            this.tbDonGiaNhap.TextChanged += new System.EventHandler(this.tbDonGiaNhap_TextChanged);
            // 
            // tbThanhTien
            // 
            this.tbThanhTien.Lines = new string[0];
            this.tbThanhTien.Location = new System.Drawing.Point(188, 204);
            this.tbThanhTien.MaxLength = 32767;
            this.tbThanhTien.Name = "tbThanhTien";
            this.tbThanhTien.PasswordChar = '\0';
            this.tbThanhTien.ReadOnly = true;
            this.tbThanhTien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbThanhTien.SelectedText = "";
            this.tbThanhTien.Size = new System.Drawing.Size(315, 23);
            this.tbThanhTien.TabIndex = 4;
            this.tbThanhTien.UseSelectable = true;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(435, 233);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 6;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseSelectable = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btDanhSachMatHang
            // 
            this.btDanhSachMatHang.Location = new System.Drawing.Point(331, 88);
            this.btDanhSachMatHang.Name = "btDanhSachMatHang";
            this.btDanhSachMatHang.Size = new System.Drawing.Size(153, 23);
            this.btDanhSachMatHang.TabIndex = 7;
            this.btDanhSachMatHang.Text = "Danh Sách Mặt Hàng";
            this.btDanhSachMatHang.UseSelectable = true;
            this.btDanhSachMatHang.Click += new System.EventHandler(this.btDanhSachMatHang_Click);
            // 
            // UILapChiTietPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 281);
            this.Controls.Add(this.btDanhSachMatHang);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tbThanhTien);
            this.Controls.Add(this.tbDonGiaNhap);
            this.Controls.Add(this.tbSoLuongNhap);
            this.Controls.Add(this.tbSoLuongChuaNhap);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbMaMatHang);
            this.Controls.Add(this.cbSoPhieuNhapHang);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "UILapChiTietPhieuNhapHang";
            this.Text = "Chi Tiết Phiếu Nhập Hàng";
            this.Load += new System.EventHandler(this.UILapChiTietPhieuNhapHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox cbSoPhieuNhapHang;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox cbMaMatHang;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbSoLuongChuaNhap;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox tbSoLuongNhap;
        private MetroFramework.Controls.MetroTextBox tbDonGiaNhap;
        private MetroFramework.Controls.MetroTextBox tbThanhTien;
        private MetroFramework.Controls.MetroButton btLuu;
        private MetroFramework.Controls.MetroButton btDanhSachMatHang;
    }
}