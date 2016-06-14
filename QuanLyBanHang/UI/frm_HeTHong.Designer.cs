namespace UI
{
    partial class frm_HeTHong
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
            this.dgvHeThong = new System.Windows.Forms.DataGridView();
            this.btLamMoi = new MetroFramework.Controls.MetroButton();
            this.btPhucHoi = new MetroFramework.Controls.MetroButton();
            this.btSaoLuu = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeThong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHeThong
            // 
            this.dgvHeThong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeThong.Location = new System.Drawing.Point(23, 63);
            this.dgvHeThong.Name = "dgvHeThong";
            this.dgvHeThong.Size = new System.Drawing.Size(548, 436);
            this.dgvHeThong.TabIndex = 24;
            // 
            // btLamMoi
            // 
            this.btLamMoi.Location = new System.Drawing.Point(577, 63);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(189, 33);
            this.btLamMoi.TabIndex = 30;
            this.btLamMoi.Text = "Làm Mới Lịch Sử Hệ Thống";
            this.btLamMoi.UseSelectable = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // btPhucHoi
            // 
            this.btPhucHoi.Location = new System.Drawing.Point(577, 141);
            this.btPhucHoi.Name = "btPhucHoi";
            this.btPhucHoi.Size = new System.Drawing.Size(189, 33);
            this.btPhucHoi.TabIndex = 29;
            this.btPhucHoi.Text = "Phục Hồi Dữ Liệu";
            this.btPhucHoi.UseSelectable = true;
            this.btPhucHoi.Click += new System.EventHandler(this.btPhucHoi_Click);
            // 
            // btSaoLuu
            // 
            this.btSaoLuu.Location = new System.Drawing.Point(577, 102);
            this.btSaoLuu.Name = "btSaoLuu";
            this.btSaoLuu.Size = new System.Drawing.Size(189, 33);
            this.btSaoLuu.TabIndex = 28;
            this.btSaoLuu.Text = "Sao Lưu Dữ Liệu";
            this.btSaoLuu.UseSelectable = true;
            this.btSaoLuu.Click += new System.EventHandler(this.btSaoLuu_Click);
            // 
            // frm_HeTHong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 522);
            this.Controls.Add(this.btLamMoi);
            this.Controls.Add(this.btPhucHoi);
            this.Controls.Add(this.btSaoLuu);
            this.Controls.Add(this.dgvHeThong);
            this.MaximizeBox = false;
            this.Name = "frm_HeTHong";
            this.Text = "Hệ Thống";
            this.Load += new System.EventHandler(this.frm_HeTHong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeThong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHeThong;
        private MetroFramework.Controls.MetroButton btLamMoi;
        private MetroFramework.Controls.MetroButton btPhucHoi;
        private MetroFramework.Controls.MetroButton btSaoLuu;
    }
}