namespace UI.UIPhieuNhapHang
{
    partial class UIDanhSachMatHang
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
            this.dgvDanhSachMatHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachMatHang
            // 
            this.dgvDanhSachMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMatHang.Location = new System.Drawing.Point(23, 63);
            this.dgvDanhSachMatHang.Name = "dgvDanhSachMatHang";
            this.dgvDanhSachMatHang.Size = new System.Drawing.Size(451, 296);
            this.dgvDanhSachMatHang.TabIndex = 0;
            // 
            // UIDanhSachMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 382);
            this.Controls.Add(this.dgvDanhSachMatHang);
            this.MaximizeBox = false;
            this.Name = "UIDanhSachMatHang";
            this.Text = "Danh Sách Mặt Hàng";
            this.Load += new System.EventHandler(this.UIDanhSachMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachMatHang;
    }
}