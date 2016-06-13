namespace UI
{
    partial class frmPhucHoiDuLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhucHoiDuLieu));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbxPath = new MetroFramework.Controls.MetroTextBox();
            this.btPhucHoi = new MetroFramework.Controls.MetroButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbxTenFile = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Đường Dẫn";
            // 
            // tbxPath
            // 
            this.tbxPath.Lines = new string[0];
            this.tbxPath.Location = new System.Drawing.Point(105, 63);
            this.tbxPath.MaxLength = 32767;
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.PasswordChar = '\0';
            this.tbxPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPath.SelectedText = "";
            this.tbxPath.Size = new System.Drawing.Size(492, 23);
            this.tbxPath.TabIndex = 8;
            this.tbxPath.UseSelectable = true;
            // 
            // btPhucHoi
            // 
            this.btPhucHoi.Location = new System.Drawing.Point(938, 457);
            this.btPhucHoi.Name = "btPhucHoi";
            this.btPhucHoi.Size = new System.Drawing.Size(75, 23);
            this.btPhucHoi.TabIndex = 7;
            this.btPhucHoi.Text = "Phục Hồi";
            this.btPhucHoi.UseSelectable = true;
            this.btPhucHoi.Click += new System.EventHandler(this.btPhucHoi_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(23, 102);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(574, 339);
            this.treeView1.TabIndex = 6;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(603, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(413, 339);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(604, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Tên File";
            // 
            // tbxTenFile
            // 
            this.tbxTenFile.Lines = new string[0];
            this.tbxTenFile.Location = new System.Drawing.Point(662, 63);
            this.tbxTenFile.MaxLength = 32767;
            this.tbxTenFile.Name = "tbxTenFile";
            this.tbxTenFile.PasswordChar = '\0';
            this.tbxTenFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxTenFile.SelectedText = "";
            this.tbxTenFile.Size = new System.Drawing.Size(354, 23);
            this.tbxTenFile.TabIndex = 8;
            this.tbxTenFile.UseSelectable = true;
            // 
            // frmPhucHoiDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 503);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbxTenFile);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.btPhucHoi);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPhucHoiDuLieu";
            this.Text = "Phục Hồi Dữ Liệu";
            this.Load += new System.EventHandler(this.frmPhucHoiDuLieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbxPath;
        private MetroFramework.Controls.MetroButton btPhucHoi;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbxTenFile;

    }
}