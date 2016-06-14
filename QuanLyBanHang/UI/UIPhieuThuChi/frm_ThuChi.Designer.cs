namespace UI.UIPhieuThuChi
{
    partial class frm_ThuChi
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
            this.btThemThuChi = new MetroFramework.Controls.MetroButton();
            this.btCapNhatThuChi = new MetroFramework.Controls.MetroButton();
            this.dgvThuChi = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.datNgayLap = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuChi)).BeginInit();
            this.SuspendLayout();
            // 
            // btThemThuChi
            // 
            this.btThemThuChi.Location = new System.Drawing.Point(781, 85);
            this.btThemThuChi.Name = "btThemThuChi";
            this.btThemThuChi.Size = new System.Drawing.Size(189, 33);
            this.btThemThuChi.TabIndex = 21;
            this.btThemThuChi.Text = "Thêm";
            this.btThemThuChi.UseSelectable = true;
            this.btThemThuChi.Click += new System.EventHandler(this.btThemThuChi_Click);
            // 
            // btCapNhatThuChi
            // 
            this.btCapNhatThuChi.Location = new System.Drawing.Point(781, 124);
            this.btCapNhatThuChi.Name = "btCapNhatThuChi";
            this.btCapNhatThuChi.Size = new System.Drawing.Size(189, 33);
            this.btCapNhatThuChi.TabIndex = 20;
            this.btCapNhatThuChi.Text = "Làm Mới Danh Sách";
            this.btCapNhatThuChi.UseSelectable = true;
            this.btCapNhatThuChi.Click += new System.EventHandler(this.btCapNhatThuChi_Click);
            // 
            // dgvThuChi
            // 
            this.dgvThuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuChi.Location = new System.Drawing.Point(23, 85);
            this.dgvThuChi.Name = "dgvThuChi";
            this.dgvThuChi.Size = new System.Drawing.Size(752, 417);
            this.dgvThuChi.TabIndex = 19;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Ngày Lập";
            // 
            // datNgayLap
            // 
            this.datNgayLap.Location = new System.Drawing.Point(94, 50);
            this.datNgayLap.MinimumSize = new System.Drawing.Size(0, 29);
            this.datNgayLap.Name = "datNgayLap";
            this.datNgayLap.Size = new System.Drawing.Size(200, 29);
            this.datNgayLap.TabIndex = 23;
            this.datNgayLap.ValueChanged += new System.EventHandler(this.datNgayLap_ValueChanged);
            // 
            // frm_ThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 525);
            this.Controls.Add(this.datNgayLap);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btThemThuChi);
            this.Controls.Add(this.btCapNhatThuChi);
            this.Controls.Add(this.dgvThuChi);
            this.Name = "frm_ThuChi";
            this.Text = "Thu - Chi";
            this.Load += new System.EventHandler(this.frm_ThuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btThemThuChi;
        private MetroFramework.Controls.MetroButton btCapNhatThuChi;
        private System.Windows.Forms.DataGridView dgvThuChi;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime datNgayLap;
    }
}