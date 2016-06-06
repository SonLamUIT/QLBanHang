namespace UI.UIPhieuThuChi
{
    partial class UIDanhSachDoiTac
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
            this.dgvDanhSachDoiTac = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDoiTac)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachDoiTac
            // 
            this.dgvDanhSachDoiTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDoiTac.Location = new System.Drawing.Point(23, 63);
            this.dgvDanhSachDoiTac.Name = "dgvDanhSachDoiTac";
            this.dgvDanhSachDoiTac.Size = new System.Drawing.Size(722, 318);
            this.dgvDanhSachDoiTac.TabIndex = 0;
            // 
            // UIDanhSachDoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 404);
            this.Controls.Add(this.dgvDanhSachDoiTac);
            this.MaximizeBox = false;
            this.Name = "UIDanhSachDoiTac";
            this.Text = "Danh Sách Đối Tác";
            this.Load += new System.EventHandler(this.UIDanhSachDoiTac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDoiTac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachDoiTac;
    }
}