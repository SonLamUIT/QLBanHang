namespace UI
{
    partial class frm_ThayDoiQuyDinh
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
            this.tbx_HeSoBanSi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_HeSoBanLe = new System.Windows.Forms.TextBox();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_HeSoBanSi
            // 
            this.tbx_HeSoBanSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_HeSoBanSi.Location = new System.Drawing.Point(229, 83);
            this.tbx_HeSoBanSi.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_HeSoBanSi.Name = "tbx_HeSoBanSi";
            this.tbx_HeSoBanSi.Size = new System.Drawing.Size(148, 23);
            this.tbx_HeSoBanSi.TabIndex = 20;
            this.tbx_HeSoBanSi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_HeSoBanSi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hệ số bán sỉ";
            // 
            // tbx_HeSoBanLe
            // 
            this.tbx_HeSoBanLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_HeSoBanLe.Location = new System.Drawing.Point(229, 127);
            this.tbx_HeSoBanLe.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_HeSoBanLe.Name = "tbx_HeSoBanLe";
            this.tbx_HeSoBanLe.Size = new System.Drawing.Size(148, 23);
            this.tbx_HeSoBanLe.TabIndex = 22;
            this.tbx_HeSoBanLe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_HeSoBanLe_KeyPress);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Location = new System.Drawing.Point(244, 256);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(100, 28);
            this.btn_CapNhat.TabIndex = 23;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(352, 256);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(100, 28);
            this.btn_Dong.TabIndex = 24;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hệ số bán lẻ";
            // 
            // frm_ThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 308);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.tbx_HeSoBanLe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_HeSoBanSi);
            this.Controls.Add(this.label3);
            this.Name = "frm_ThayDoiQuyDinh";
            this.Text = "Thay Đổi Quy Định";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_HeSoBanSi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_HeSoBanLe;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Label label1;
    }
}