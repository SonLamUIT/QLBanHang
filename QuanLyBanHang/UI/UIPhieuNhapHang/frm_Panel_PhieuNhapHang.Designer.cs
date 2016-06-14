namespace UI.UIPhieuNhapHang
{
    partial class frm_Panel_PhieuNhapHang
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
            this.dgvDanhSachPhieuNhapHang = new System.Windows.Forms.DataGridView();
            this.btThemPhieuNhapHang = new MetroFramework.Controls.MetroButton();
            this.btCapNhatDanhSachPhieuNhapHang = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.datNgapLap = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachPhieuNhapHang
            // 
            this.dgvDanhSachPhieuNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuNhapHang.Location = new System.Drawing.Point(23, 102);
            this.dgvDanhSachPhieuNhapHang.Name = "dgvDanhSachPhieuNhapHang";
            this.dgvDanhSachPhieuNhapHang.ReadOnly = true;
            this.dgvDanhSachPhieuNhapHang.Size = new System.Drawing.Size(710, 398);
            this.dgvDanhSachPhieuNhapHang.TabIndex = 6;
            this.dgvDanhSachPhieuNhapHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPhieuNhapHang_CellDoubleClick);
            // 
            // btThemPhieuNhapHang
            // 
            this.btThemPhieuNhapHang.Location = new System.Drawing.Point(544, 63);
            this.btThemPhieuNhapHang.Name = "btThemPhieuNhapHang";
            this.btThemPhieuNhapHang.Size = new System.Drawing.Size(189, 33);
            this.btThemPhieuNhapHang.TabIndex = 12;
            this.btThemPhieuNhapHang.Text = "Thêm";
            this.btThemPhieuNhapHang.UseSelectable = true;
            this.btThemPhieuNhapHang.Click += new System.EventHandler(this.btThemPhieuNhapHang_Click);
            // 
            // btCapNhatDanhSachPhieuNhapHang
            // 
            this.btCapNhatDanhSachPhieuNhapHang.Location = new System.Drawing.Point(349, 63);
            this.btCapNhatDanhSachPhieuNhapHang.Name = "btCapNhatDanhSachPhieuNhapHang";
            this.btCapNhatDanhSachPhieuNhapHang.Size = new System.Drawing.Size(189, 33);
            this.btCapNhatDanhSachPhieuNhapHang.TabIndex = 10;
            this.btCapNhatDanhSachPhieuNhapHang.Text = "Làm Mới Danh Sách";
            this.btCapNhatDanhSachPhieuNhapHang.UseSelectable = true;
            this.btCapNhatDanhSachPhieuNhapHang.Click += new System.EventHandler(this.btCapNhatDanhSachPhieuNhapHang_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Ngày Lập";
            // 
            // datNgapLap
            // 
            this.datNgapLap.Location = new System.Drawing.Point(94, 67);
            this.datNgapLap.MinimumSize = new System.Drawing.Size(0, 29);
            this.datNgapLap.Name = "datNgapLap";
            this.datNgapLap.Size = new System.Drawing.Size(171, 29);
            this.datNgapLap.TabIndex = 16;
            this.datNgapLap.ValueChanged += new System.EventHandler(this.datNgapLap_ValueChanged);
            // 
            // frm_Panel_PhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 527);
            this.Controls.Add(this.datNgapLap);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btThemPhieuNhapHang);
            this.Controls.Add(this.btCapNhatDanhSachPhieuNhapHang);
            this.Controls.Add(this.dgvDanhSachPhieuNhapHang);
            this.Name = "frm_Panel_PhieuNhapHang";
            this.Text = "Phiếu Nhập Hàng";
            this.Load += new System.EventHandler(this.frm_Panel_PhieuNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuNhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachPhieuNhapHang;
        private MetroFramework.Controls.MetroButton btThemPhieuNhapHang;
        private MetroFramework.Controls.MetroButton btCapNhatDanhSachPhieuNhapHang;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime datNgapLap;
    }
}