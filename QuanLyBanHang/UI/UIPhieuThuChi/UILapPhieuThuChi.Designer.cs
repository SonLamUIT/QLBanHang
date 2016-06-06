namespace UI.UIPhieuThuChi
{
    partial class UILapPhieuThuChi
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbSoPhieu = new MetroFramework.Controls.MetroTextBox();
            this.label = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbMaDoiTac = new MetroFramework.Controls.MetroComboBox();
            this.datNgayLap = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.rbPhieuThu = new MetroFramework.Controls.MetroRadioButton();
            this.rbPhieuChi = new MetroFramework.Controls.MetroRadioButton();
            this.tbSoTien = new MetroFramework.Controls.MetroTextBox();
            this.btLapPhieu = new MetroFramework.Controls.MetroButton();
            this.btDanhSachDoiTac = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Loại Phiếu";
            // 
            // tbSoPhieu
            // 
            this.tbSoPhieu.Lines = new string[0];
            this.tbSoPhieu.Location = new System.Drawing.Point(102, 84);
            this.tbSoPhieu.MaxLength = 32767;
            this.tbSoPhieu.Name = "tbSoPhieu";
            this.tbSoPhieu.PasswordChar = '\0';
            this.tbSoPhieu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSoPhieu.SelectedText = "";
            this.tbSoPhieu.Size = new System.Drawing.Size(200, 23);
            this.tbSoPhieu.TabIndex = 1;
            this.tbSoPhieu.UseSelectable = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 124);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(65, 19);
            this.label.TabIndex = 0;
            this.label.Text = "Ngày Lập";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 159);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Mã Đối Tác";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 188);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Số Tiền";
            // 
            // cbMaDoiTac
            // 
            this.cbMaDoiTac.FormattingEnabled = true;
            this.cbMaDoiTac.ItemHeight = 23;
            this.cbMaDoiTac.Location = new System.Drawing.Point(102, 148);
            this.cbMaDoiTac.Name = "cbMaDoiTac";
            this.cbMaDoiTac.Size = new System.Drawing.Size(121, 29);
            this.cbMaDoiTac.TabIndex = 2;
            this.cbMaDoiTac.UseSelectable = true;
            // 
            // datNgayLap
            // 
            this.datNgayLap.Location = new System.Drawing.Point(102, 113);
            this.datNgayLap.MinimumSize = new System.Drawing.Size(0, 29);
            this.datNgayLap.Name = "datNgayLap";
            this.datNgayLap.Size = new System.Drawing.Size(200, 29);
            this.datNgayLap.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 89);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Số Phiếu ";
            // 
            // rbPhieuThu
            // 
            this.rbPhieuThu.AutoSize = true;
            this.rbPhieuThu.Location = new System.Drawing.Point(102, 63);
            this.rbPhieuThu.Name = "rbPhieuThu";
            this.rbPhieuThu.Size = new System.Drawing.Size(77, 15);
            this.rbPhieuThu.TabIndex = 4;
            this.rbPhieuThu.Text = "Phiếu Thu";
            this.rbPhieuThu.UseSelectable = true;
            this.rbPhieuThu.CheckedChanged += new System.EventHandler(this.rbPhieuThu_CheckedChanged);
            // 
            // rbPhieuChi
            // 
            this.rbPhieuChi.AutoSize = true;
            this.rbPhieuChi.Location = new System.Drawing.Point(185, 64);
            this.rbPhieuChi.Name = "rbPhieuChi";
            this.rbPhieuChi.Size = new System.Drawing.Size(74, 15);
            this.rbPhieuChi.TabIndex = 4;
            this.rbPhieuChi.Text = "Phiếu Chi";
            this.rbPhieuChi.UseSelectable = true;
            this.rbPhieuChi.CheckedChanged += new System.EventHandler(this.rbPhieuChi_CheckedChanged);
            // 
            // tbSoTien
            // 
            this.tbSoTien.Lines = new string[0];
            this.tbSoTien.Location = new System.Drawing.Point(102, 184);
            this.tbSoTien.MaxLength = 32767;
            this.tbSoTien.Name = "tbSoTien";
            this.tbSoTien.PasswordChar = '\0';
            this.tbSoTien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSoTien.SelectedText = "";
            this.tbSoTien.Size = new System.Drawing.Size(287, 23);
            this.tbSoTien.TabIndex = 5;
            this.tbSoTien.UseSelectable = true;
            // 
            // btLapPhieu
            // 
            this.btLapPhieu.Location = new System.Drawing.Point(320, 220);
            this.btLapPhieu.Name = "btLapPhieu";
            this.btLapPhieu.Size = new System.Drawing.Size(75, 23);
            this.btLapPhieu.TabIndex = 6;
            this.btLapPhieu.Text = "Lập Phiếu";
            this.btLapPhieu.UseSelectable = true;
            this.btLapPhieu.Click += new System.EventHandler(this.btLapPhieu_Click);
            // 
            // btDanhSachDoiTac
            // 
            this.btDanhSachDoiTac.Location = new System.Drawing.Point(229, 154);
            this.btDanhSachDoiTac.Name = "btDanhSachDoiTac";
            this.btDanhSachDoiTac.Size = new System.Drawing.Size(109, 23);
            this.btDanhSachDoiTac.TabIndex = 7;
            this.btDanhSachDoiTac.Text = "Danh Sách Đối Tác";
            this.btDanhSachDoiTac.UseSelectable = true;
            this.btDanhSachDoiTac.Click += new System.EventHandler(this.btDanhSachDoiTac_Click);
            // 
            // UILapPhieuThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 266);
            this.Controls.Add(this.btDanhSachDoiTac);
            this.Controls.Add(this.btLapPhieu);
            this.Controls.Add(this.tbSoTien);
            this.Controls.Add(this.rbPhieuChi);
            this.Controls.Add(this.rbPhieuThu);
            this.Controls.Add(this.datNgayLap);
            this.Controls.Add(this.cbMaDoiTac);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbSoPhieu);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "UILapPhieuThuChi";
            this.Text = "Lập Phiếu Thu Chi";
            this.Load += new System.EventHandler(this.UILapPhieuThuChi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbSoPhieu;
        private MetroFramework.Controls.MetroLabel label;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbMaDoiTac;
        private MetroFramework.Controls.MetroDateTime datNgayLap;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroRadioButton rbPhieuThu;
        private MetroFramework.Controls.MetroRadioButton rbPhieuChi;
        private MetroFramework.Controls.MetroTextBox tbSoTien;
        private MetroFramework.Controls.MetroButton btLapPhieu;
        private MetroFramework.Controls.MetroButton btDanhSachDoiTac;
    }
}