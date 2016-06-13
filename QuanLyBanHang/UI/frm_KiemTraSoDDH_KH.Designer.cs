namespace UI
{
    partial class frm_KiemTraSoDDH_KH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KiemTraSoDDH_KH));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgrid_KtDonDatHang = new System.Windows.Forms.DataGridView();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbx_khachang = new System.Windows.Forms.TextBox();
            this.tbx_SoDonDatHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_KtDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgrid_KtDonDatHang);
            this.groupBox1.Location = new System.Drawing.Point(23, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn các mặt hàng trong đơn đặt hàng";
            // 
            // dtgrid_KtDonDatHang
            // 
            this.dtgrid_KtDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_KtDonDatHang.Location = new System.Drawing.Point(21, 30);
            this.dtgrid_KtDonDatHang.Name = "dtgrid_KtDonDatHang";
            this.dtgrid_KtDonDatHang.Size = new System.Drawing.Size(703, 161);
            this.dtgrid_KtDonDatHang.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(649, 322);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(98, 28);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Quay lại";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbx_khachang
            // 
            this.tbx_khachang.Enabled = false;
            this.tbx_khachang.Location = new System.Drawing.Point(250, 63);
            this.tbx_khachang.Name = "tbx_khachang";
            this.tbx_khachang.Size = new System.Drawing.Size(148, 20);
            this.tbx_khachang.TabIndex = 30;
            // 
            // tbx_SoDonDatHang
            // 
            this.tbx_SoDonDatHang.Enabled = false;
            this.tbx_SoDonDatHang.Location = new System.Drawing.Point(599, 63);
            this.tbx_SoDonDatHang.Name = "tbx_SoDonDatHang";
            this.tbx_SoDonDatHang.Size = new System.Drawing.Size(148, 20);
            this.tbx_SoDonDatHang.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Số ĐĐH";
            // 
            // frm_KiemTraSoDDH_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 376);
            this.Controls.Add(this.tbx_khachang);
            this.Controls.Add(this.tbx_SoDonDatHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_KiemTraSoDDH_KH";
            this.Text = "Kiểm tra Đơn Đặt Hàng";
            this.Load += new System.EventHandler(this.frm_KiemTraSoDDH_KH_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_KtDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrid_KtDonDatHang;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbx_khachang;
        private System.Windows.Forms.TextBox tbx_SoDonDatHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}