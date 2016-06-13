namespace UI
{
    partial class frm_TimKiemHDBL
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
            this.tbx_khachhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgrid_TimKiemHDBL = new System.Windows.Forms.DataGridView();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_TimKiemHDBL)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_khachhang
            // 
            this.tbx_khachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_khachhang.Location = new System.Drawing.Point(152, 64);
            this.tbx_khachhang.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_khachhang.Name = "tbx_khachhang";
            this.tbx_khachhang.Size = new System.Drawing.Size(148, 23);
            this.tbx_khachhang.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên khách hàng";
            // 
            // dtgrid_TimKiemHDBL
            // 
            this.dtgrid_TimKiemHDBL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_TimKiemHDBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_TimKiemHDBL.Enabled = false;
            this.dtgrid_TimKiemHDBL.Location = new System.Drawing.Point(19, 109);
            this.dtgrid_TimKiemHDBL.Name = "dtgrid_TimKiemHDBL";
            this.dtgrid_TimKiemHDBL.ReadOnly = true;
            this.dtgrid_TimKiemHDBL.Size = new System.Drawing.Size(642, 150);
            this.dtgrid_TimKiemHDBL.TabIndex = 21;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(453, 279);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(100, 28);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(561, 279);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(100, 28);
            this.btn_Dong.TabIndex = 2;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // frm_TimKiemHDBL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 332);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.dtgrid_TimKiemHDBL);
            this.Controls.Add(this.tbx_khachhang);
            this.Controls.Add(this.label3);
            this.Name = "frm_TimKiemHDBL";
            this.Text = "Thông Tin Khách Hàng";
            this.Load += new System.EventHandler(this.frm_TimKiemHDBL_Load);
            this.MouseHover += new System.EventHandler(this.frm_TimKiemHDBL_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_TimKiemHDBL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_khachhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgrid_TimKiemHDBL;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Dong;
    }
}