namespace UI
{
    partial class frm_DoiTac
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
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.check_box_TimKiem = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_LoaiDoiTac = new System.Windows.Forms.ComboBox();
            this.tbx_TenDoiTac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dtgrid_mathang = new System.Windows.Forms.DataGridView();
            this.tbx_Sdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_DiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_mathang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(374, 250);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(100, 28);
            this.btn_TimKiem.TabIndex = 22;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // check_box_TimKiem
            // 
            this.check_box_TimKiem.AutoSize = true;
            this.check_box_TimKiem.Location = new System.Drawing.Point(37, 250);
            this.check_box_TimKiem.Name = "check_box_TimKiem";
            this.check_box_TimKiem.Size = new System.Drawing.Size(68, 17);
            this.check_box_TimKiem.TabIndex = 21;
            this.check_box_TimKiem.Text = "Tìm kiếm";
            this.check_box_TimKiem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_DiaChi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbx_Sdt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_LoaiDoiTac);
            this.groupBox1.Controls.Add(this.tbx_TenDoiTac);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(23, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 134);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đối tác";
            // 
            // cbx_LoaiDoiTac
            // 
            this.cbx_LoaiDoiTac.FormattingEnabled = true;
            this.cbx_LoaiDoiTac.Location = new System.Drawing.Point(147, 95);
            this.cbx_LoaiDoiTac.Name = "cbx_LoaiDoiTac";
            this.cbx_LoaiDoiTac.Size = new System.Drawing.Size(148, 21);
            this.cbx_LoaiDoiTac.TabIndex = 15;
            // 
            // tbx_TenDoiTac
            // 
            this.tbx_TenDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_TenDoiTac.Location = new System.Drawing.Point(147, 39);
            this.tbx_TenDoiTac.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_TenDoiTac.Name = "tbx_TenDoiTac";
            this.tbx_TenDoiTac.Size = new System.Drawing.Size(148, 23);
            this.tbx_TenDoiTac.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên đối tác";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Thuộc loại";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(590, 250);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_xoa.TabIndex = 19;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(482, 250);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 28);
            this.btn_them.TabIndex = 18;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // dtgrid_mathang
            // 
            this.dtgrid_mathang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_mathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_mathang.Location = new System.Drawing.Point(23, 315);
            this.dtgrid_mathang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrid_mathang.Name = "dtgrid_mathang";
            this.dtgrid_mathang.Size = new System.Drawing.Size(667, 185);
            this.dtgrid_mathang.TabIndex = 17;
            // 
            // tbx_Sdt
            // 
            this.tbx_Sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Sdt.Location = new System.Drawing.Point(459, 40);
            this.tbx_Sdt.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_Sdt.Name = "tbx_Sdt";
            this.tbx_Sdt.Size = new System.Drawing.Size(148, 23);
            this.tbx_Sdt.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "SDT";
            // 
            // tbx_DiaChi
            // 
            this.tbx_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_DiaChi.Location = new System.Drawing.Point(459, 93);
            this.tbx_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_DiaChi.Name = "tbx_DiaChi";
            this.tbx_DiaChi.Size = new System.Drawing.Size(148, 23);
            this.tbx_DiaChi.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Địa Chỉ";
            // 
            // frm_DoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 530);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.check_box_TimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtgrid_mathang);
            this.Name = "frm_DoiTac";
            this.Text = "ĐỐI TÁC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_mathang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.CheckBox check_box_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_LoaiDoiTac;
        private System.Windows.Forms.TextBox tbx_TenDoiTac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dtgrid_mathang;
        private System.Windows.Forms.TextBox tbx_DiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Sdt;
        private System.Windows.Forms.Label label1;
    }
}