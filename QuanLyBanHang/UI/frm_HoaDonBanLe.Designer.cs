namespace UI
{
    partial class frm_HoaDonBanLe
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
            this.datetime_NgayLap = new MetroFramework.Controls.MetroDateTime();
            this.tbx_khachhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgrid_mathang = new System.Windows.Forms.DataGridView();
            this.tbx_tongthanhtien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.check_box_TimKiem = new System.Windows.Forms.CheckBox();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_tenmathang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.column_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_mathang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datetime_NgayLap);
            this.groupBox1.Controls.Add(this.tbx_khachhang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(23, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 93);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // datetime_NgayLap
            // 
            this.datetime_NgayLap.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.datetime_NgayLap.Location = new System.Drawing.Point(521, 36);
            this.datetime_NgayLap.MinimumSize = new System.Drawing.Size(0, 25);
            this.datetime_NgayLap.Name = "datetime_NgayLap";
            this.datetime_NgayLap.Size = new System.Drawing.Size(162, 25);
            this.datetime_NgayLap.TabIndex = 1;
            // 
            // tbx_khachhang
            // 
            this.tbx_khachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_khachhang.Location = new System.Drawing.Point(147, 39);
            this.tbx_khachhang.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_khachhang.Name = "tbx_khachhang";
            this.tbx_khachhang.Size = new System.Drawing.Size(148, 23);
            this.tbx_khachhang.TabIndex = 0;
            this.tbx_khachhang.TextChanged += new System.EventHandler(this.tbx_khachhang_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày lập";
            // 
            // dtgrid_mathang
            // 
            this.dtgrid_mathang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_mathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_mathang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbx_tenmathang,
            this.column_SoLuong,
            this.column_DonGia,
            this.column_ThanhTien});
            this.dtgrid_mathang.Location = new System.Drawing.Point(25, 34);
            this.dtgrid_mathang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrid_mathang.Name = "dtgrid_mathang";
            this.dtgrid_mathang.Size = new System.Drawing.Size(687, 178);
            this.dtgrid_mathang.TabIndex = 2;
            this.dtgrid_mathang.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_mathang_CellValidated);
            this.dtgrid_mathang.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgrid_mathang_DefaultValuesNeeded);
            // 
            // tbx_tongthanhtien
            // 
            this.tbx_tongthanhtien.Enabled = false;
            this.tbx_tongthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_tongthanhtien.Location = new System.Drawing.Point(587, 416);
            this.tbx_tongthanhtien.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_tongthanhtien.Name = "tbx_tongthanhtien";
            this.tbx_tongthanhtien.Size = new System.Drawing.Size(148, 23);
            this.tbx_tongthanhtien.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 420);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tổng thành tiền";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.Location = new System.Drawing.Point(552, 465);
            this.btn_ThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(100, 28);
            this.btn_ThanhToan.TabIndex = 4;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // check_box_TimKiem
            // 
            this.check_box_TimKiem.AutoSize = true;
            this.check_box_TimKiem.Location = new System.Drawing.Point(454, 472);
            this.check_box_TimKiem.Name = "check_box_TimKiem";
            this.check_box_TimKiem.Size = new System.Drawing.Size(68, 17);
            this.check_box_TimKiem.TabIndex = 3;
            this.check_box_TimKiem.Text = "Tìm kiếm";
            this.check_box_TimKiem.UseVisualStyleBackColor = true;
            this.check_box_TimKiem.CheckedChanged += new System.EventHandler(this.check_box_TimKiem_CheckedChanged);
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(660, 465);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(100, 28);
            this.btn_Dong.TabIndex = 5;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgrid_mathang);
            this.groupBox2.Location = new System.Drawing.Point(23, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 235);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Những mặt hàng cần mua";
            // 
            // cbx_tenmathang
            // 
            this.cbx_tenmathang.HeaderText = "Mặt hàng";
            this.cbx_tenmathang.Name = "cbx_tenmathang";
            // 
            // column_SoLuong
            // 
            this.column_SoLuong.HeaderText = "Số lượng";
            this.column_SoLuong.Name = "column_SoLuong";
            // 
            // column_DonGia
            // 
            this.column_DonGia.HeaderText = "Đơn giá";
            this.column_DonGia.Name = "column_DonGia";
            // 
            // column_ThanhTien
            // 
            this.column_ThanhTien.HeaderText = "Thành Tiền";
            this.column_ThanhTien.Name = "column_ThanhTien";
            this.column_ThanhTien.ReadOnly = true;
            // 
            // frm_HoaDonBanLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.check_box_TimKiem);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.tbx_tongthanhtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_HoaDonBanLe";
            this.Text = "HÓA ĐƠN BÁN LẺ";
            this.Load += new System.EventHandler(this.frm_HoaDonBanLe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_mathang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_khachhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroDateTime datetime_NgayLap;
        private System.Windows.Forms.DataGridView dtgrid_mathang;
        private System.Windows.Forms.TextBox tbx_tongthanhtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.CheckBox check_box_TimKiem;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbx_tenmathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ThanhTien;
    }
}