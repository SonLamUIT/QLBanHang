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
            this.tbx_DiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Sdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_LoaiDoiTac = new System.Windows.Forms.ComboBox();
            this.tbx_TenDoiTac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dtgrid_doitac = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_doitac)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TimKiem.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(374, 250);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(100, 28);
            this.btn_TimKiem.TabIndex = 22;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // check_box_TimKiem
            // 
            this.check_box_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.check_box_TimKiem.AutoSize = true;
            this.check_box_TimKiem.Location = new System.Drawing.Point(37, 250);
            this.check_box_TimKiem.Name = "check_box_TimKiem";
            this.check_box_TimKiem.Size = new System.Drawing.Size(68, 17);
            this.check_box_TimKiem.TabIndex = 21;
            this.check_box_TimKiem.Text = "Tìm kiếm";
            this.check_box_TimKiem.UseVisualStyleBackColor = true;
            this.check_box_TimKiem.CheckedChanged += new System.EventHandler(this.check_box_TimKiem_CheckedChanged);
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 134);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đối tác";
            // 
            // tbx_DiaChi
            // 
            this.tbx_DiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_DiaChi.Location = new System.Drawing.Point(459, 93);
            this.tbx_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_DiaChi.Name = "tbx_DiaChi";
            this.tbx_DiaChi.Size = new System.Drawing.Size(148, 23);
            this.tbx_DiaChi.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Địa Chỉ";
            // 
            // tbx_Sdt
            // 
            this.tbx_Sdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Sdt.Location = new System.Drawing.Point(459, 40);
            this.tbx_Sdt.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_Sdt.Name = "tbx_Sdt";
            this.tbx_Sdt.Size = new System.Drawing.Size(148, 23);
            this.tbx_Sdt.TabIndex = 20;
            this.tbx_Sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_Sdt_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "SDT";
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
            // btn_capnhat
            // 
            this.btn_capnhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_capnhat.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.Location = new System.Drawing.Point(590, 250);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(100, 28);
            this.btn_capnhat.TabIndex = 19;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_them.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(482, 250);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 28);
            this.btn_them.TabIndex = 18;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dtgrid_doitac
            // 
            this.dtgrid_doitac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_doitac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_doitac.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgrid_doitac.Location = new System.Drawing.Point(20, 302);
            this.dtgrid_doitac.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrid_doitac.Name = "dtgrid_doitac";
            this.dtgrid_doitac.Size = new System.Drawing.Size(673, 185);
            this.dtgrid_doitac.TabIndex = 17;
            this.dtgrid_doitac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_doitac_CellClick);
            // 
            // frm_DoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 507);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.check_box_TimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtgrid_doitac);
            this.Name = "frm_DoiTac";
            this.Text = "ĐỐI TÁC";
            this.Load += new System.EventHandler(this.frm_DoiTac_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_doitac)).EndInit();
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
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dtgrid_doitac;
        private System.Windows.Forms.TextBox tbx_DiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Sdt;
        private System.Windows.Forms.Label label1;
    }
}