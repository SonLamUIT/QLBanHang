namespace UI
{
    partial class frm_PhieuGiaoHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTime_NgayGiao = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_kiemtradondathang = new System.Windows.Forms.Button();
            this.cbx_sodondathang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_tenkhachhang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_TongTien = new System.Windows.Forms.TextBox();
            this.tbx_ThanhToan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_ConLai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_GiaoHang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgrid_CTphieugiaohang = new System.Windows.Forms.DataGridView();
            this.column_SoLuongDaGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_SoLuongChuaGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_CTphieugiaohang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTime_NgayGiao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_kiemtradondathang);
            this.groupBox1.Controls.Add(this.cbx_sodondathang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_tenkhachhang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu giao hàng";
            // 
            // dateTime_NgayGiao
            // 
            this.dateTime_NgayGiao.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dateTime_NgayGiao.Location = new System.Drawing.Point(148, 68);
            this.dateTime_NgayGiao.MinimumSize = new System.Drawing.Size(0, 25);
            this.dateTime_NgayGiao.Name = "dateTime_NgayGiao";
            this.dateTime_NgayGiao.Size = new System.Drawing.Size(148, 25);
            this.dateTime_NgayGiao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ngày giao";
            // 
            // btn_kiemtradondathang
            // 
            this.btn_kiemtradondathang.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_kiemtradondathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kiemtradondathang.Location = new System.Drawing.Point(640, 26);
            this.btn_kiemtradondathang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kiemtradondathang.Name = "btn_kiemtradondathang";
            this.btn_kiemtradondathang.Size = new System.Drawing.Size(93, 28);
            this.btn_kiemtradondathang.TabIndex = 23;
            this.btn_kiemtradondathang.Text = "Kiểm tra";
            this.btn_kiemtradondathang.UseVisualStyleBackColor = false;
            this.btn_kiemtradondathang.Click += new System.EventHandler(this.btn_kiemtradondathang_Click);
            // 
            // cbx_sodondathang
            // 
            this.cbx_sodondathang.FormattingEnabled = true;
            this.cbx_sodondathang.Location = new System.Drawing.Point(471, 31);
            this.cbx_sodondathang.Name = "cbx_sodondathang";
            this.cbx_sodondathang.Size = new System.Drawing.Size(148, 21);
            this.cbx_sodondathang.TabIndex = 22;
            this.cbx_sodondathang.SelectedIndexChanged += new System.EventHandler(this.cbx_sodondathang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Số đơn đặt hàng";
            // 
            // cbx_tenkhachhang
            // 
            this.cbx_tenkhachhang.FormattingEnabled = true;
            this.cbx_tenkhachhang.Location = new System.Drawing.Point(148, 31);
            this.cbx_tenkhachhang.Name = "cbx_tenkhachhang";
            this.cbx_tenkhachhang.Size = new System.Drawing.Size(148, 21);
            this.cbx_tenkhachhang.TabIndex = 20;
            this.cbx_tenkhachhang.SelectedIndexChanged += new System.EventHandler(this.cbx_tenkhachhang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 400);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tổng tiền";
            // 
            // tbx_TongTien
            // 
            this.tbx_TongTien.Enabled = false;
            this.tbx_TongTien.Location = new System.Drawing.Point(595, 399);
            this.tbx_TongTien.Name = "tbx_TongTien";
            this.tbx_TongTien.ReadOnly = true;
            this.tbx_TongTien.Size = new System.Drawing.Size(148, 20);
            this.tbx_TongTien.TabIndex = 26;
            // 
            // tbx_ThanhToan
            // 
            this.tbx_ThanhToan.Location = new System.Drawing.Point(595, 425);
            this.tbx_ThanhToan.Name = "tbx_ThanhToan";
            this.tbx_ThanhToan.Size = new System.Drawing.Size(148, 20);
            this.tbx_ThanhToan.TabIndex = 28;
            this.tbx_ThanhToan.TextChanged += new System.EventHandler(this.tbx_ThanhToan_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 426);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Thanh toán";
            // 
            // tbx_ConLai
            // 
            this.tbx_ConLai.Enabled = false;
            this.tbx_ConLai.Location = new System.Drawing.Point(595, 451);
            this.tbx_ConLai.Name = "tbx_ConLai";
            this.tbx_ConLai.ReadOnly = true;
            this.tbx_ConLai.Size = new System.Drawing.Size(148, 20);
            this.tbx_ConLai.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 452);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Còn lại";
            // 
            // btn_GiaoHang
            // 
            this.btn_GiaoHang.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_GiaoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GiaoHang.Location = new System.Drawing.Point(549, 502);
            this.btn_GiaoHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GiaoHang.Name = "btn_GiaoHang";
            this.btn_GiaoHang.Size = new System.Drawing.Size(93, 28);
            this.btn_GiaoHang.TabIndex = 25;
            this.btn_GiaoHang.Text = "Giao Hàng";
            this.btn_GiaoHang.UseVisualStyleBackColor = false;
            this.btn_GiaoHang.Click += new System.EventHandler(this.btn_GiaoHang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgrid_CTphieugiaohang);
            this.groupBox2.Location = new System.Drawing.Point(23, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 207);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu giao hàng";
            // 
            // dtgrid_CTphieugiaohang
            // 
            this.dtgrid_CTphieugiaohang.AllowUserToAddRows = false;
            this.dtgrid_CTphieugiaohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_CTphieugiaohang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_SoLuongDaGiao,
            this.column_SoLuongChuaGiao,
            this.column_DonGia,
            this.column_ThanhTien});
            this.dtgrid_CTphieugiaohang.Location = new System.Drawing.Point(10, 36);
            this.dtgrid_CTphieugiaohang.Name = "dtgrid_CTphieugiaohang";
            this.dtgrid_CTphieugiaohang.Size = new System.Drawing.Size(746, 150);
            this.dtgrid_CTphieugiaohang.TabIndex = 0;
            this.dtgrid_CTphieugiaohang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_CTphieugiaohang_CellEndEdit);
            this.dtgrid_CTphieugiaohang.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_CTphieugiaohang_CellValidated);
            this.dtgrid_CTphieugiaohang.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgrid_CTphieugiaohang_DefaultValuesNeeded);
            // 
            // column_SoLuongDaGiao
            // 
            this.column_SoLuongDaGiao.HeaderText = "Số lượng đã giao";
            this.column_SoLuongDaGiao.Name = "column_SoLuongDaGiao";
            // 
            // column_SoLuongChuaGiao
            // 
            this.column_SoLuongChuaGiao.HeaderText = "Số lượng chưa giao";
            this.column_SoLuongChuaGiao.Name = "column_SoLuongChuaGiao";
            this.column_SoLuongChuaGiao.ReadOnly = true;
            // 
            // column_DonGia
            // 
            this.column_DonGia.HeaderText = "Đơn giá";
            this.column_DonGia.Name = "column_DonGia";
            // 
            // column_ThanhTien
            // 
            this.column_ThanhTien.HeaderText = "Thành tiền";
            this.column_ThanhTien.Name = "column_ThanhTien";
            this.column_ThanhTien.ReadOnly = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(663, 502);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(93, 28);
            this.btn_Thoat.TabIndex = 32;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_PhieuGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 554);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_GiaoHang);
            this.Controls.Add(this.tbx_ConLai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_TongTien);
            this.Controls.Add(this.tbx_ThanhToan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "frm_PhieuGiaoHang";
            this.Text = "PHIẾU GIAO HÀNG";
            this.Load += new System.EventHandler(this.frm_PhieuGiaoHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_CTphieugiaohang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_sodondathang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_tenkhachhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_kiemtradondathang;
        private MetroFramework.Controls.MetroDateTime dateTime_NgayGiao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_TongTien;
        private System.Windows.Forms.TextBox tbx_ThanhToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_ConLai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_GiaoHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgrid_CTphieugiaohang;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_SoLuongDaGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_SoLuongChuaGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ThanhTien;
    }
}