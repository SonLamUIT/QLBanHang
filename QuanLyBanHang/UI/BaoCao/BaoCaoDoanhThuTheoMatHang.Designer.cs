namespace UI.BaoCao
{
    partial class BaoCaoDoanhThuTheoMatHang
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
            this.datNgayLap = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.btXuatBaoCao = new MetroFramework.Controls.MetroButton();
            this.crbc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // datNgayLap
            // 
            this.datNgayLap.Location = new System.Drawing.Point(90, 63);
            this.datNgayLap.MinimumSize = new System.Drawing.Size(0, 29);
            this.datNgayLap.Name = "datNgayLap";
            this.datNgayLap.Size = new System.Drawing.Size(200, 29);
            this.datNgayLap.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Ngày Lập";
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(23, 98);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.Size = new System.Drawing.Size(547, 483);
            this.dgvBaoCao.TabIndex = 3;
            // 
            // btXuatBaoCao
            // 
            this.btXuatBaoCao.Location = new System.Drawing.Point(296, 69);
            this.btXuatBaoCao.Name = "btXuatBaoCao";
            this.btXuatBaoCao.Size = new System.Drawing.Size(126, 23);
            this.btXuatBaoCao.TabIndex = 5;
            this.btXuatBaoCao.Text = "Xuất Báo Cáo";
            this.btXuatBaoCao.UseSelectable = true;
            this.btXuatBaoCao.Click += new System.EventHandler(this.btXuatBaoCao_Click);
            // 
            // crbc
            // 
            this.crbc.ActiveViewIndex = -1;
            this.crbc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crbc.Cursor = System.Windows.Forms.Cursors.Default;
            this.crbc.Location = new System.Drawing.Point(576, 98);
            this.crbc.Name = "crbc";
            this.crbc.Size = new System.Drawing.Size(670, 483);
            this.crbc.TabIndex = 6;
            // 
            // BaoCaoDoanhThuTheoMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 604);
            this.Controls.Add(this.crbc);
            this.Controls.Add(this.btXuatBaoCao);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.datNgayLap);
            this.Name = "BaoCaoDoanhThuTheoMatHang";
            this.Text = "Báo Cáo Doanh Thu Theo Mặt Hàng";
            this.Load += new System.EventHandler(this.BaoCaoDoanhThuTheoMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime datNgayLap;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private MetroFramework.Controls.MetroButton btXuatBaoCao;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crbc;
    }
}