namespace UI
{
    partial class frm_TimKiemDonDatHangNCC
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
            this.dtgrid_TimKiemHDBL = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_SoDDH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Ncc = new System.Windows.Forms.ComboBox();
            this.btn_Dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_TimKiemHDBL)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrid_TimKiemHDBL
            // 
            this.dtgrid_TimKiemHDBL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_TimKiemHDBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_TimKiemHDBL.Enabled = false;
            this.dtgrid_TimKiemHDBL.Location = new System.Drawing.Point(26, 159);
            this.dtgrid_TimKiemHDBL.Name = "dtgrid_TimKiemHDBL";
            this.dtgrid_TimKiemHDBL.ReadOnly = true;
            this.dtgrid_TimKiemHDBL.Size = new System.Drawing.Size(642, 150);
            this.dtgrid_TimKiemHDBL.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nhà cung cấp";
            // 
            // cbx_SoDDH
            // 
            this.cbx_SoDDH.FormattingEnabled = true;
            this.cbx_SoDDH.Location = new System.Drawing.Point(506, 74);
            this.cbx_SoDDH.Name = "cbx_SoDDH";
            this.cbx_SoDDH.Size = new System.Drawing.Size(148, 21);
            this.cbx_SoDDH.TabIndex = 25;
            this.cbx_SoDDH.SelectedIndexChanged += new System.EventHandler(this.cbx_SoDDH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Số ĐĐH";
            // 
            // cbx_Ncc
            // 
            this.cbx_Ncc.FormattingEnabled = true;
            this.cbx_Ncc.Location = new System.Drawing.Point(145, 74);
            this.cbx_Ncc.Name = "cbx_Ncc";
            this.cbx_Ncc.Size = new System.Drawing.Size(148, 21);
            this.cbx_Ncc.TabIndex = 26;
            this.cbx_Ncc.SelectedIndexChanged += new System.EventHandler(this.cbx_Ncc_SelectedIndexChanged);
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(554, 329);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(100, 28);
            this.btn_Dong.TabIndex = 27;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // frm_TimKiemDonDatHangNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 381);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.cbx_Ncc);
            this.Controls.Add(this.cbx_SoDDH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgrid_TimKiemHDBL);
            this.Name = "frm_TimKiemDonDatHangNCC";
            this.Text = "Tìm kiếm Đơn Đặt Hàng NCC";
            this.Load += new System.EventHandler(this.frm_TimKiemDonDatHangNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_TimKiemHDBL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrid_TimKiemHDBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_SoDDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Ncc;
        private System.Windows.Forms.Button btn_Dong;
    }
}