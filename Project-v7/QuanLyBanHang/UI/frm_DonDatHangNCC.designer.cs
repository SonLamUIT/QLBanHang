namespace UI
{
    partial class frm_DonDatHangNCC
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
            this.dtime_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_NCC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dtgrid_mathang = new System.Windows.Forms.DataGridView();
            this.cl_TenMH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cl_SoLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SoLuongDaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_mathang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtime_NgayLap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbx_NCC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 79);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn đặt hàng";
            // 
            // dtime_NgayLap
            // 
            this.dtime_NgayLap.Location = new System.Drawing.Point(435, 31);
            this.dtime_NgayLap.Name = "dtime_NgayLap";
            this.dtime_NgayLap.Size = new System.Drawing.Size(200, 20);
            this.dtime_NgayLap.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(336, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ngày Lập";
            // 
            // cbx_NCC
            // 
            this.cbx_NCC.FormattingEnabled = true;
            this.cbx_NCC.Location = new System.Drawing.Point(149, 30);
            this.cbx_NCC.Name = "cbx_NCC";
            this.cbx_NCC.Size = new System.Drawing.Size(155, 21);
            this.cbx_NCC.TabIndex = 3;
            this.cbx_NCC.SelectedIndexChanged += new System.EventHandler(this.cbx_NCC_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nhà Cung Cấp";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.Menu;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(591, 148);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimkiem.TabIndex = 8;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(483, 148);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 28);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dtgrid_mathang
            // 
            this.dtgrid_mathang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_mathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_mathang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_TenMH,
            this.cl_SoLuongDat,
            this.cl_SoLuongDaNhap});
            this.dtgrid_mathang.Location = new System.Drawing.Point(24, 198);
            this.dtgrid_mathang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrid_mathang.Name = "dtgrid_mathang";
            this.dtgrid_mathang.Size = new System.Drawing.Size(667, 320);
            this.dtgrid_mathang.TabIndex = 23;
            this.dtgrid_mathang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_mathang_CellContentClick);
            this.dtgrid_mathang.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_mathang_CellValidated);
            this.dtgrid_mathang.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgrid_mathang_DefaultValuesNeeded);
            // 
            // cl_TenMH
            // 
            this.cl_TenMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_TenMH.HeaderText = "Tên Mặt Hàng";
            this.cl_TenMH.Name = "cl_TenMH";
            this.cl_TenMH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cl_TenMH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cl_TenMH.Width = 208;
            // 
            // cl_SoLuongDat
            // 
            this.cl_SoLuongDat.HeaderText = "Số Lượng Đặt";
            this.cl_SoLuongDat.Name = "cl_SoLuongDat";
            // 
            // cl_SoLuongDaNhap
            // 
            this.cl_SoLuongDaNhap.HeaderText = "Số Lượng Đã Nhập";
            this.cl_SoLuongDaNhap.Name = "cl_SoLuongDaNhap";
            this.cl_SoLuongDaNhap.ReadOnly = true;
            // 
            // frm_DonDatHangNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtgrid_mathang);
            this.Name = "frm_DonDatHangNCC";
            this.Text = "Đơn Đặt Hàng";
            this.Load += new System.EventHandler(this.DonDatHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_mathang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dtgrid_mathang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_NCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewComboBoxColumn cl_TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SoLuongDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SoLuongDaNhap;
        private System.Windows.Forms.DateTimePicker dtime_NgayLap;
    }
}