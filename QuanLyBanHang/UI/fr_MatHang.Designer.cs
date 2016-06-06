namespace UI
{
    partial class fr_MatHang
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
            this.dtgrid_mathang = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_tenmathang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_dvt = new System.Windows.Forms.ComboBox();
            this.check_box_TimKiem = new System.Windows.Forms.CheckBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_mathang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrid_mathang
            // 
            this.dtgrid_mathang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_mathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_mathang.Location = new System.Drawing.Point(20, 311);
            this.dtgrid_mathang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrid_mathang.Name = "dtgrid_mathang";
            this.dtgrid_mathang.Size = new System.Drawing.Size(667, 185);
            this.dtgrid_mathang.TabIndex = 10;
            this.dtgrid_mathang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_mathang_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(479, 246);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 28);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(587, 246);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_dvt);
            this.groupBox1.Controls.Add(this.tbx_tenmathang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(20, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 134);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập hàng";
            // 
            // tbx_tenmathang
            // 
            this.tbx_tenmathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_tenmathang.Location = new System.Drawing.Point(147, 39);
            this.tbx_tenmathang.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_tenmathang.Name = "tbx_tenmathang";
            this.tbx_tenmathang.Size = new System.Drawing.Size(148, 23);
            this.tbx_tenmathang.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên mặt hàng";
            // 
            // cbx_dvt
            // 
            this.cbx_dvt.FormattingEnabled = true;
            this.cbx_dvt.Location = new System.Drawing.Point(147, 95);
            this.cbx_dvt.Name = "cbx_dvt";
            this.cbx_dvt.Size = new System.Drawing.Size(148, 24);
            this.cbx_dvt.TabIndex = 15;
            // 
            // check_box_TimKiem
            // 
            this.check_box_TimKiem.AutoSize = true;
            this.check_box_TimKiem.Location = new System.Drawing.Point(34, 246);
            this.check_box_TimKiem.Name = "check_box_TimKiem";
            this.check_box_TimKiem.Size = new System.Drawing.Size(83, 21);
            this.check_box_TimKiem.TabIndex = 15;
            this.check_box_TimKiem.Text = "Tìm kiếm";
            this.check_box_TimKiem.UseVisualStyleBackColor = true;
            this.check_box_TimKiem.CheckedChanged += new System.EventHandler(this.check_box_TimKiem_CheckedChanged);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(371, 246);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(100, 28);
            this.btn_TimKiem.TabIndex = 16;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // Them_MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 559);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.check_box_TimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtgrid_mathang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Them_MatHang";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "MẶT HÀNG";
            this.Load += new System.EventHandler(this.Them_MatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_mathang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrid_mathang;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_tenmathang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_dvt;
        private System.Windows.Forms.CheckBox check_box_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
    }
}