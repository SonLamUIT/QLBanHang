namespace UI.UIPhieuNhapHang
{
    partial class UISuaPhieuNhapHang
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
            this.datNgayNhap = new MetroFramework.Controls.MetroDateTime();
            this.tbTongTien = new MetroFramework.Controls.MetroTextBox();
            this.tbConLai = new MetroFramework.Controls.MetroTextBox();
            this.tbThanhToan = new MetroFramework.Controls.MetroTextBox();
            this.tbSoPhieuNhapHang = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbSoDDH_NCC = new MetroFramework.Controls.MetroTextBox();
            this.btSua = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // datNgayNhap
            // 
            this.datNgayNhap.Location = new System.Drawing.Point(241, 128);
            this.datNgayNhap.MinimumSize = new System.Drawing.Size(0, 29);
            this.datNgayNhap.Name = "datNgayNhap";
            this.datNgayNhap.Size = new System.Drawing.Size(200, 29);
            this.datNgayNhap.TabIndex = 24;
            // 
            // tbTongTien
            // 
            this.tbTongTien.Lines = new string[0];
            this.tbTongTien.Location = new System.Drawing.Point(241, 163);
            this.tbTongTien.MaxLength = 32767;
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.PasswordChar = '\0';
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTongTien.SelectedText = "";
            this.tbTongTien.Size = new System.Drawing.Size(442, 23);
            this.tbTongTien.TabIndex = 23;
            this.tbTongTien.UseSelectable = true;
            this.tbTongTien.TextChanged += new System.EventHandler(this.tbTongTien_TextChanged);
            // 
            // tbConLai
            // 
            this.tbConLai.Lines = new string[0];
            this.tbConLai.Location = new System.Drawing.Point(241, 225);
            this.tbConLai.MaxLength = 32767;
            this.tbConLai.Name = "tbConLai";
            this.tbConLai.PasswordChar = '\0';
            this.tbConLai.ReadOnly = true;
            this.tbConLai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbConLai.SelectedText = "";
            this.tbConLai.Size = new System.Drawing.Size(442, 23);
            this.tbConLai.TabIndex = 21;
            this.tbConLai.UseSelectable = true;
            // 
            // tbThanhToan
            // 
            this.tbThanhToan.Lines = new string[0];
            this.tbThanhToan.Location = new System.Drawing.Point(241, 192);
            this.tbThanhToan.MaxLength = 32767;
            this.tbThanhToan.Name = "tbThanhToan";
            this.tbThanhToan.PasswordChar = '\0';
            this.tbThanhToan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbThanhToan.SelectedText = "";
            this.tbThanhToan.Size = new System.Drawing.Size(442, 23);
            this.tbThanhToan.TabIndex = 22;
            this.tbThanhToan.UseSelectable = true;
            this.tbThanhToan.TextChanged += new System.EventHandler(this.tbThanhToan_TextChanged);
            // 
            // tbSoPhieuNhapHang
            // 
            this.tbSoPhieuNhapHang.Lines = new string[0];
            this.tbSoPhieuNhapHang.Location = new System.Drawing.Point(241, 64);
            this.tbSoPhieuNhapHang.MaxLength = 32767;
            this.tbSoPhieuNhapHang.Name = "tbSoPhieuNhapHang";
            this.tbSoPhieuNhapHang.PasswordChar = '\0';
            this.tbSoPhieuNhapHang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSoPhieuNhapHang.SelectedText = "";
            this.tbSoPhieuNhapHang.Size = new System.Drawing.Size(442, 23);
            this.tbSoPhieuNhapHang.TabIndex = 20;
            this.tbSoPhieuNhapHang.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 167);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(67, 19);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Tổng Tiền";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 225);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 19);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Còn Lại";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 196);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Thanh Toán";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 138);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Ngày Nhập";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(212, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Số Đơn Đặt Hàng - Nhà Cung Cấp";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Số Phiếu Nhập Hàng";
            // 
            // tbSoDDH_NCC
            // 
            this.tbSoDDH_NCC.Lines = new string[0];
            this.tbSoDDH_NCC.Location = new System.Drawing.Point(241, 93);
            this.tbSoDDH_NCC.MaxLength = 32767;
            this.tbSoDDH_NCC.Name = "tbSoDDH_NCC";
            this.tbSoDDH_NCC.PasswordChar = '\0';
            this.tbSoDDH_NCC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSoDDH_NCC.SelectedText = "";
            this.tbSoDDH_NCC.Size = new System.Drawing.Size(442, 23);
            this.tbSoDDH_NCC.TabIndex = 20;
            this.tbSoDDH_NCC.UseSelectable = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(628, 254);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 25;
            this.btSua.Text = "Sửa";
            this.btSua.UseSelectable = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // UISuaPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 296);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.datNgayNhap);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.tbConLai);
            this.Controls.Add(this.tbThanhToan);
            this.Controls.Add(this.tbSoDDH_NCC);
            this.Controls.Add(this.tbSoPhieuNhapHang);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UISuaPhieuNhapHang";
            this.Text = "Sửa Phiếu Nhập Hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime datNgayNhap;
        private MetroFramework.Controls.MetroTextBox tbTongTien;
        private MetroFramework.Controls.MetroTextBox tbConLai;
        private MetroFramework.Controls.MetroTextBox tbThanhToan;
        private MetroFramework.Controls.MetroTextBox tbSoPhieuNhapHang;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbSoDDH_NCC;
        private MetroFramework.Controls.MetroButton btSua;
    }
}