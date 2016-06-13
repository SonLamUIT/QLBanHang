namespace UI
{
    partial class frm_DonDatHangKH
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
            this.dateTime_ngaygiaodukien = new MetroFramework.Controls.MetroDateTime();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTime_ngaylap = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_tenkhachhang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dathang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgrid_ctddhKH = new System.Windows.Forms.DataGridView();
            this.cbx_mathang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.column_soluongdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_soluongdagiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_soluongchuagiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_ctddhKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTime_ngaygiaodukien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTime_ngaylap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_tenkhachhang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn đặt hàng";
            // 
            // dateTime_ngaygiaodukien
            // 
            this.dateTime_ngaygiaodukien.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dateTime_ngaygiaodukien.Location = new System.Drawing.Point(489, 79);
            this.dateTime_ngaygiaodukien.MinimumSize = new System.Drawing.Size(0, 25);
            this.dateTime_ngaygiaodukien.Name = "dateTime_ngaygiaodukien";
            this.dateTime_ngaygiaodukien.Size = new System.Drawing.Size(162, 25);
            this.dateTime_ngaygiaodukien.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ngày giao (dự kiến)";
            // 
            // dateTime_ngaylap
            // 
            this.dateTime_ngaylap.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dateTime_ngaylap.Location = new System.Drawing.Point(489, 39);
            this.dateTime_ngaylap.MinimumSize = new System.Drawing.Size(0, 25);
            this.dateTime_ngaylap.Name = "dateTime_ngaylap";
            this.dateTime_ngaylap.Size = new System.Drawing.Size(162, 25);
            this.dateTime_ngaylap.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ngày lập";
            // 
            // cbx_tenkhachhang
            // 
            this.cbx_tenkhachhang.FormattingEnabled = true;
            this.cbx_tenkhachhang.Location = new System.Drawing.Point(155, 44);
            this.cbx_tenkhachhang.Name = "cbx_tenkhachhang";
            this.cbx_tenkhachhang.Size = new System.Drawing.Size(148, 21);
            this.cbx_tenkhachhang.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Khách hàng";
            // 
            // btn_dathang
            // 
            this.btn_dathang.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_dathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dathang.Location = new System.Drawing.Point(489, 405);
            this.btn_dathang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dathang.Name = "btn_dathang";
            this.btn_dathang.Size = new System.Drawing.Size(100, 28);
            this.btn_dathang.TabIndex = 17;
            this.btn_dathang.Text = "Đặt hàng";
            this.btn_dathang.UseVisualStyleBackColor = false;
            this.btn_dathang.Click += new System.EventHandler(this.btn_dathang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgrid_ctddhKH);
            this.groupBox2.Location = new System.Drawing.Point(23, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 196);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Những mặt hàng cần đặt";
            // 
            // dtgrid_ctddhKH
            // 
            this.dtgrid_ctddhKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_ctddhKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_ctddhKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbx_mathang,
            this.column_soluongdat,
            this.column_soluongdagiao,
            this.column_soluongchuagiao});
            this.dtgrid_ctddhKH.Location = new System.Drawing.Point(17, 28);
            this.dtgrid_ctddhKH.Name = "dtgrid_ctddhKH";
            this.dtgrid_ctddhKH.Size = new System.Drawing.Size(652, 150);
            this.dtgrid_ctddhKH.TabIndex = 0;
            this.dtgrid_ctddhKH.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_ctddhKH_CellValidated);
            this.dtgrid_ctddhKH.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // cbx_mathang
            // 
            this.cbx_mathang.HeaderText = "Mặt hàng";
            this.cbx_mathang.Name = "cbx_mathang";
            // 
            // column_soluongdat
            // 
            this.column_soluongdat.HeaderText = "Số lượng đặt";
            this.column_soluongdat.Name = "column_soluongdat";
            // 
            // column_soluongdagiao
            // 
            this.column_soluongdagiao.HeaderText = "Số lượng đã giao";
            this.column_soluongdagiao.Name = "column_soluongdagiao";
            this.column_soluongdagiao.ReadOnly = true;
            // 
            // column_soluongchuagiao
            // 
            this.column_soluongchuagiao.HeaderText = "Số lượng chưa giao";
            this.column_soluongchuagiao.Name = "column_soluongchuagiao";
            this.column_soluongchuagiao.ReadOnly = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(612, 405);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_Thoat.TabIndex = 19;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Di chuyển đến phiếu giao hàng...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_DonDatHangKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_dathang);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_DonDatHangKH";
            this.Text = "ĐƠN ĐẶT HÀNG CỦA KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frm_DonDatHangKH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_ctddhKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_tenkhachhang;
        private MetroFramework.Controls.MetroDateTime dateTime_ngaygiaodukien;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroDateTime dateTime_ngaylap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dathang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgrid_ctddhKH;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbx_mathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_soluongdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_soluongdagiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_soluongchuagiao;
    }
}