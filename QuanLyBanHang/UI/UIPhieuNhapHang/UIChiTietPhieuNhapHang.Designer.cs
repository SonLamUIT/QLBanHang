namespace UI.UIPhieuNhapHang
{
    partial class UIChiTietPhieuNhapHang
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
            this.dgvDanhSachChiTietPhieuNhapHang = new System.Windows.Forms.DataGridView();
            this.btCapNhat = new MetroFramework.Controls.MetroButton();
            this.btXoa = new MetroFramework.Controls.MetroButton();
            this.btSua = new MetroFramework.Controls.MetroButton();
            this.btThem = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietPhieuNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachChiTietPhieuNhapHang
            // 
            this.dgvDanhSachChiTietPhieuNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChiTietPhieuNhapHang.Location = new System.Drawing.Point(23, 63);
            this.dgvDanhSachChiTietPhieuNhapHang.Name = "dgvDanhSachChiTietPhieuNhapHang";
            this.dgvDanhSachChiTietPhieuNhapHang.Size = new System.Drawing.Size(821, 386);
            this.dgvDanhSachChiTietPhieuNhapHang.TabIndex = 0;
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(769, 468);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btCapNhat.TabIndex = 1;
            this.btCapNhat.Text = "Cập Nhật";
            this.btCapNhat.UseSelectable = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(688, 468);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseSelectable = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(607, 468);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseSelectable = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(526, 468);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseSelectable = true;
            // 
            // UIChiTietPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 514);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.dgvDanhSachChiTietPhieuNhapHang);
            this.Name = "UIChiTietPhieuNhapHang";
            this.Text = "Chi Tiết Phiếu Nhập Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietPhieuNhapHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachChiTietPhieuNhapHang;
        private MetroFramework.Controls.MetroButton btCapNhat;
        private MetroFramework.Controls.MetroButton btXoa;
        private MetroFramework.Controls.MetroButton btSua;
        private MetroFramework.Controls.MetroButton btThem;
    }
}