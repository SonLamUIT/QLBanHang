namespace UI
{
    partial class frm_DonDatHang
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
            this.dgvDonDatHangNCC = new System.Windows.Forms.DataGridView();
            this.dvgDonDatHangKH = new System.Windows.Forms.DataGridView();
            this.btDDHKH = new MetroFramework.Controls.MetroButton();
            this.btDDHNCC = new MetroFramework.Controls.MetroButton();
            this.btLamMoi = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHangNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDonDatHangKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonDatHangNCC
            // 
            this.dgvDonDatHangNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonDatHangNCC.Location = new System.Drawing.Point(23, 63);
            this.dgvDonDatHangNCC.Name = "dgvDonDatHangNCC";
            this.dgvDonDatHangNCC.Size = new System.Drawing.Size(515, 410);
            this.dgvDonDatHangNCC.TabIndex = 0;
            // 
            // dvgDonDatHangKH
            // 
            this.dvgDonDatHangKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDonDatHangKH.Location = new System.Drawing.Point(544, 63);
            this.dvgDonDatHangKH.Name = "dvgDonDatHangKH";
            this.dvgDonDatHangKH.Size = new System.Drawing.Size(515, 410);
            this.dvgDonDatHangKH.TabIndex = 0;
            // 
            // btDDHKH
            // 
            this.btDDHKH.Location = new System.Drawing.Point(1065, 102);
            this.btDDHKH.Name = "btDDHKH";
            this.btDDHKH.Size = new System.Drawing.Size(189, 33);
            this.btDDHKH.TabIndex = 24;
            this.btDDHKH.Text = "Đơn Đặt Hàng Khách Hàng";
            this.btDDHKH.UseSelectable = true;
            this.btDDHKH.Click += new System.EventHandler(this.btDDHKH_Click);
            // 
            // btDDHNCC
            // 
            this.btDDHNCC.Location = new System.Drawing.Point(1065, 141);
            this.btDDHNCC.Name = "btDDHNCC";
            this.btDDHNCC.Size = new System.Drawing.Size(189, 33);
            this.btDDHNCC.TabIndex = 27;
            this.btDDHNCC.Text = "Đơn Đặt Hàng Nhà Cung Cấp";
            this.btDDHNCC.UseSelectable = true;
            this.btDDHNCC.Click += new System.EventHandler(this.btDDHNCC_Click);
            // 
            // btLamMoi
            // 
            this.btLamMoi.Location = new System.Drawing.Point(1065, 63);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(189, 33);
            this.btLamMoi.TabIndex = 27;
            this.btLamMoi.Text = "Làm Mới Danh Sách";
            this.btLamMoi.UseSelectable = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // frm_DonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 496);
            this.Controls.Add(this.btLamMoi);
            this.Controls.Add(this.btDDHNCC);
            this.Controls.Add(this.btDDHKH);
            this.Controls.Add(this.dvgDonDatHangKH);
            this.Controls.Add(this.dgvDonDatHangNCC);
            this.Name = "frm_DonDatHang";
            this.Text = "Đơn Đặt Hàng";
            this.Load += new System.EventHandler(this.frm_DonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHangNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDonDatHangKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonDatHangNCC;
        private System.Windows.Forms.DataGridView dvgDonDatHangKH;
        private MetroFramework.Controls.MetroButton btDDHKH;
        private MetroFramework.Controls.MetroButton btDDHNCC;
        private MetroFramework.Controls.MetroButton btLamMoi;
    }
}