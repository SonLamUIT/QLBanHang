namespace UI.UIPhieuThucChi
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
            this.datNgayLap = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbMaDoiTac = new MetroFramework.Controls.MetroComboBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.rbPhieuThu = new MetroFramework.Controls.MetroRadioButton();
            this.rbPhieuChi = new MetroFramework.Controls.MetroRadioButton();
            this.tbSoTien = new MetroFramework.Controls.MetroTextBox();
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
            this.tbSoPhieu.Size = new System.Drawing.Size(287, 23);
            this.tbSoPhieu.TabIndex = 1;
            this.tbSoPhieu.UseSelectable = true;
            // 
            // datNgayLap
            // 
            this.datNgayLap.AutoSize = true;
            this.datNgayLap.Location = new System.Drawing.Point(22, 124);
            this.datNgayLap.Name = "datNgayLap";
            this.datNgayLap.Size = new System.Drawing.Size(65, 19);
            this.datNgayLap.TabIndex = 0;
            this.datNgayLap.Text = "Ngày Lập";
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
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(102, 113);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 3;
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
            this.tbSoTien.Size = new System.Drawing.Size(75, 23);
            this.tbSoTien.TabIndex = 5;
            this.tbSoTien.UseSelectable = true;
            // 
            // UILapPhieuThucChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 423);
            this.Controls.Add(this.tbSoTien);
            this.Controls.Add(this.rbPhieuChi);
            this.Controls.Add(this.rbPhieuThu);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.cbMaDoiTac);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbSoPhieu);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.datNgayLap);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UILapPhieuThucChi";
            this.Text = "Lập Phiếu Thu Chi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbSoPhieu;
        private MetroFramework.Controls.MetroLabel datNgayLap;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbMaDoiTac;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroRadioButton rbPhieuThu;
        private MetroFramework.Controls.MetroRadioButton rbPhieuChi;
        private MetroFramework.Controls.MetroTextBox tbSoTien;
    }
}