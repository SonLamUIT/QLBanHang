namespace UI.UIPhieuNhapHang
{
    partial class frm_ChiTietPhieuNhapHang
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btThemChiTietPhieuNhapHang = new MetroFramework.Controls.MetroButton();
            this.btCapNhatDanhSachChiTietPhieuNhapHang = new MetroFramework.Controls.MetroButton();
            this.dgvDanhSachChiTietPhieuNhapHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietPhieuNhapHang)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btThemChiTietPhieuNhapHang
            // 
            this.btThemChiTietPhieuNhapHang.Location = new System.Drawing.Point(781, 124);
            this.btThemChiTietPhieuNhapHang.Name = "btThemChiTietPhieuNhapHang";
            this.btThemChiTietPhieuNhapHang.Size = new System.Drawing.Size(189, 33);
            this.btThemChiTietPhieuNhapHang.TabIndex = 12;
            this.btThemChiTietPhieuNhapHang.Text = "Thêm";
            this.btThemChiTietPhieuNhapHang.UseSelectable = true;
            this.btThemChiTietPhieuNhapHang.Click += new System.EventHandler(this.btThemChiTietPhieuNhapHang_Click);
            // 
            // btCapNhatDanhSachChiTietPhieuNhapHang
            // 
            this.btCapNhatDanhSachChiTietPhieuNhapHang.Location = new System.Drawing.Point(781, 85);
            this.btCapNhatDanhSachChiTietPhieuNhapHang.Name = "btCapNhatDanhSachChiTietPhieuNhapHang";
            this.btCapNhatDanhSachChiTietPhieuNhapHang.Size = new System.Drawing.Size(189, 33);
            this.btCapNhatDanhSachChiTietPhieuNhapHang.TabIndex = 11;
            this.btCapNhatDanhSachChiTietPhieuNhapHang.Text = "Cập Nhật";
            this.btCapNhatDanhSachChiTietPhieuNhapHang.UseSelectable = true;
            this.btCapNhatDanhSachChiTietPhieuNhapHang.Click += new System.EventHandler(this.btCapNhatDanhSachChiTietPhieuNhapHang_Click);
            // 
            // dgvDanhSachChiTietPhieuNhapHang
            // 
            this.dgvDanhSachChiTietPhieuNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChiTietPhieuNhapHang.Location = new System.Drawing.Point(23, 85);
            this.dgvDanhSachChiTietPhieuNhapHang.Name = "dgvDanhSachChiTietPhieuNhapHang";
            this.dgvDanhSachChiTietPhieuNhapHang.Size = new System.Drawing.Size(752, 398);
            this.dgvDanhSachChiTietPhieuNhapHang.TabIndex = 10;
            this.dgvDanhSachChiTietPhieuNhapHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachChiTietPhieuNhapHang_CellContentClick);
            // 
            // frm_ChiTietPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 508);
            this.Controls.Add(this.btThemChiTietPhieuNhapHang);
            this.Controls.Add(this.btCapNhatDanhSachChiTietPhieuNhapHang);
            this.Controls.Add(this.dgvDanhSachChiTietPhieuNhapHang);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frm_ChiTietPhieuNhapHang";
            this.Text = "Chi Tiết Phiếu Nhập Hàng";
            this.Load += new System.EventHandler(this.frm_ChiTietPhieuNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietPhieuNhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroButton btThemChiTietPhieuNhapHang;
        private MetroFramework.Controls.MetroButton btCapNhatDanhSachChiTietPhieuNhapHang;
        private System.Windows.Forms.DataGridView dgvDanhSachChiTietPhieuNhapHang;
    }
}