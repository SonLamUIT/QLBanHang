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
            this.tbSoPhieu = new MetroFramework.Controls.MetroTextBox();
            this.label = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbMaDoiTac = new MetroFramework.Controls.MetroComboBox();
            this.datNgayLap = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbSoTien = new MetroFramework.Controls.MetroTextBox();
            this.btLapPhieu = new MetroFramework.Controls.MetroButton();
            this.btDanhSachDoiTac = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbTongNo = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // tbSoPhieu
            // 
            this.tbSoPhieu.Lines = new string[0];
            this.tbSoPhieu.Location = new System.Drawing.Point(104, 63);
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
            this.label.Location = new System.Drawing.Point(24, 103);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(65, 19);
            this.label.TabIndex = 0;
            this.label.Text = "Ngày Lập";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 138);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Mã Đối Tác";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 167);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Số Tiền";
            // 
            // cbMaDoiTac
            // 
            this.cbMaDoiTac.FormattingEnabled = true;
            this.cbMaDoiTac.ItemHeight = 23;
            this.cbMaDoiTac.Location = new System.Drawing.Point(104, 127);
            this.cbMaDoiTac.Name = "cbMaDoiTac";
            this.cbMaDoiTac.Size = new System.Drawing.Size(121, 29);
            this.cbMaDoiTac.TabIndex = 2;
            this.cbMaDoiTac.UseSelectable = true;
            this.cbMaDoiTac.SelectedIndexChanged += new System.EventHandler(this.cbMaDoiTac_SelectedIndexChanged);
            // 
            // datNgayLap
            // 
            this.datNgayLap.Location = new System.Drawing.Point(104, 92);
            this.datNgayLap.MinimumSize = new System.Drawing.Size(0, 29);
            this.datNgayLap.Name = "datNgayLap";
            this.datNgayLap.Size = new System.Drawing.Size(200, 29);
            this.datNgayLap.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 68);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Số Phiếu ";
            // 
            // tbSoTien
            // 
            this.tbSoTien.Lines = new string[0];
            this.tbSoTien.Location = new System.Drawing.Point(104, 162);
            this.tbSoTien.MaxLength = 32767;
            this.tbSoTien.Name = "tbSoTien";
            this.tbSoTien.PasswordChar = '\0';
            this.tbSoTien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSoTien.SelectedText = "";
            this.tbSoTien.Size = new System.Drawing.Size(287, 23);
            this.tbSoTien.TabIndex = 5;
            this.tbSoTien.UseSelectable = true;
            this.tbSoTien.TextChanged += new System.EventHandler(this.tbSoTien_TextChanged);
            // 
            // btLapPhieu
            // 
            this.btLapPhieu.Location = new System.Drawing.Point(322, 221);
            this.btLapPhieu.Name = "btLapPhieu";
            this.btLapPhieu.Size = new System.Drawing.Size(75, 23);
            this.btLapPhieu.TabIndex = 6;
            this.btLapPhieu.Text = "Lập Phiếu";
            this.btLapPhieu.UseSelectable = true;
            this.btLapPhieu.Click += new System.EventHandler(this.btLapPhieu_Click);
            // 
            // btDanhSachDoiTac
            // 
            this.btDanhSachDoiTac.Location = new System.Drawing.Point(231, 133);
            this.btDanhSachDoiTac.Name = "btDanhSachDoiTac";
            this.btDanhSachDoiTac.Size = new System.Drawing.Size(109, 23);
            this.btDanhSachDoiTac.TabIndex = 7;
            this.btDanhSachDoiTac.Text = "Danh Sách Đối Tác";
            this.btDanhSachDoiTac.UseSelectable = true;
            this.btDanhSachDoiTac.Click += new System.EventHandler(this.btDanhSachDoiTac_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 196);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Tổng Nợ";
            // 
            // tbTongNo
            // 
            this.tbTongNo.Lines = new string[0];
            this.tbTongNo.Location = new System.Drawing.Point(104, 192);
            this.tbTongNo.MaxLength = 32767;
            this.tbTongNo.Name = "tbTongNo";
            this.tbTongNo.PasswordChar = '\0';
            this.tbTongNo.ReadOnly = true;
            this.tbTongNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTongNo.SelectedText = "";
            this.tbTongNo.Size = new System.Drawing.Size(287, 23);
            this.tbTongNo.TabIndex = 5;
            this.tbTongNo.UseSelectable = true;
            // 
            // UILapPhieuThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 276);
            this.Controls.Add(this.btDanhSachDoiTac);
            this.Controls.Add(this.btLapPhieu);
            this.Controls.Add(this.tbTongNo);
            this.Controls.Add(this.tbSoTien);
            this.Controls.Add(this.datNgayLap);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cbMaDoiTac);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbSoPhieu);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.metroLabel4);
            this.MaximizeBox = false;
            this.Name = "UILapPhieuThuChi";
            this.Text = "Lập Phiếu Thu Chi";
            this.Load += new System.EventHandler(this.UILapPhieuThuChi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbSoPhieu;
        private MetroFramework.Controls.MetroLabel label;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbMaDoiTac;
        private MetroFramework.Controls.MetroDateTime datNgayLap;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbSoTien;
        private MetroFramework.Controls.MetroButton btLapPhieu;
        private MetroFramework.Controls.MetroButton btDanhSachDoiTac;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbTongNo;
    }
}