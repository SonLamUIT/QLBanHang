﻿namespace UI
{
    partial class frm_BaoCaoCongNoKH
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
            this.cbx_sodondathang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_tenkhachhang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_Nam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_Thang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgrid_BCCN = new System.Windows.Forms.DataGridView();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_BCCN)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_sodondathang
            // 
            this.cbx_sodondathang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_sodondathang.FormattingEnabled = true;
            this.cbx_sodondathang.Location = new System.Drawing.Point(633, 19);
            this.cbx_sodondathang.Name = "cbx_sodondathang";
            this.cbx_sodondathang.Size = new System.Drawing.Size(148, 21);
            this.cbx_sodondathang.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Số đơn đặt hàng";
            // 
            // cbx_tenkhachhang
            // 
            this.cbx_tenkhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_tenkhachhang.FormattingEnabled = true;
            this.cbx_tenkhachhang.Location = new System.Drawing.Point(181, 19);
            this.cbx_tenkhachhang.Name = "cbx_tenkhachhang";
            this.cbx_tenkhachhang.Size = new System.Drawing.Size(148, 21);
            this.cbx_tenkhachhang.TabIndex = 24;
            this.cbx_tenkhachhang.SelectedIndexChanged += new System.EventHandler(this.cbx_tenkhachhang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Khách hàng";
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.Location = new System.Drawing.Point(549, 431);
            this.btn_ThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(144, 28);
            this.btn_ThongKe.TabIndex = 27;
            this.btn_ThongKe.Text = "Thiết lập thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_Nam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbx_Thang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbx_sodondathang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbx_tenkhachhang);
            this.groupBox1.Location = new System.Drawing.Point(8, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 105);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu giao hàng";
            // 
            // tbx_Nam
            // 
            this.tbx_Nam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Nam.Location = new System.Drawing.Point(197, 65);
            this.tbx_Nam.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_Nam.Name = "tbx_Nam";
            this.tbx_Nam.Size = new System.Drawing.Size(54, 23);
            this.tbx_Nam.TabIndex = 29;
            this.tbx_Nam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_Nam_KeyPress);
            this.tbx_Nam.Validated += new System.EventHandler(this.tbx_Nam_Validated);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Năm";
            // 
            // tbx_Thang
            // 
            this.tbx_Thang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Thang.Location = new System.Drawing.Point(97, 65);
            this.tbx_Thang.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_Thang.Name = "tbx_Thang";
            this.tbx_Thang.Size = new System.Drawing.Size(46, 23);
            this.tbx_Thang.TabIndex = 27;
            this.tbx_Thang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_Thang_KeyPress);
            this.tbx_Thang.Validated += new System.EventHandler(this.tbx_Thang_Validated);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tháng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgrid_BCCN);
            this.groupBox2.Location = new System.Drawing.Point(8, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 166);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết báo cáo công nợ";
            // 
            // dtgrid_BCCN
            // 
            this.dtgrid_BCCN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_BCCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_BCCN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgrid_BCCN.Location = new System.Drawing.Point(3, 31);
            this.dtgrid_BCCN.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrid_BCCN.Name = "dtgrid_BCCN";
            this.dtgrid_BCCN.Size = new System.Drawing.Size(797, 132);
            this.dtgrid_BCCN.TabIndex = 2;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(710, 431);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_Thoat.TabIndex = 32;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_BaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 483);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ThongKe);
            this.Name = "frm_BaoCaoCongNo";
            this.Text = "BÁO CÁO CÔNG NỢ KHÁCH HÀNG - BÁN SỈ";
            this.Load += new System.EventHandler(this.frm_BaoCaoCongNo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_BCCN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_sodondathang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_tenkhachhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_Nam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_Thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgrid_BCCN;
        private System.Windows.Forms.Button btn_Thoat;
    }
}