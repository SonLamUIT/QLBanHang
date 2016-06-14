namespace UI
{
    partial class frmSaoLuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaoLuu));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btSaoLuu = new MetroFramework.Controls.MetroButton();
            this.tbxPath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbxTenFile = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(11, 121);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(574, 339);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btSaoLuu
            // 
            this.btSaoLuu.Location = new System.Drawing.Point(501, 512);
            this.btSaoLuu.Name = "btSaoLuu";
            this.btSaoLuu.Size = new System.Drawing.Size(75, 23);
            this.btSaoLuu.TabIndex = 2;
            this.btSaoLuu.Text = "Sao Lưu";
            this.btSaoLuu.UseSelectable = true;
            this.btSaoLuu.Click += new System.EventHandler(this.btSaoLuu_Click);
            // 
            // tbxPath
            // 
            this.tbxPath.Lines = new string[0];
            this.tbxPath.Location = new System.Drawing.Point(93, 82);
            this.tbxPath.MaxLength = 32767;
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.PasswordChar = '\0';
            this.tbxPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPath.SelectedText = "";
            this.tbxPath.Size = new System.Drawing.Size(492, 23);
            this.tbxPath.TabIndex = 4;
            this.tbxPath.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Đường Dẫn";
            // 
            // tbxTenFile
            // 
            this.tbxTenFile.Lines = new string[0];
            this.tbxTenFile.Location = new System.Drawing.Point(69, 475);
            this.tbxTenFile.MaxLength = 32767;
            this.tbxTenFile.Name = "tbxTenFile";
            this.tbxTenFile.PasswordChar = '\0';
            this.tbxTenFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxTenFile.SelectedText = "";
            this.tbxTenFile.Size = new System.Drawing.Size(299, 23);
            this.tbxTenFile.TabIndex = 1;
            this.tbxTenFile.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 475);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Tên File";
            // 
            // frmSaoLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(599, 558);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tbxTenFile);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.btSaoLuu);
            this.Controls.Add(this.treeView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSaoLuu";
            this.Text = "Sao Lưu Dữ Liệu";
            this.Load += new System.EventHandler(this.frmChonFolder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private MetroFramework.Controls.MetroButton btSaoLuu;
        private MetroFramework.Controls.MetroTextBox tbxPath;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbxTenFile;
        private MetroFramework.Controls.MetroLabel metroLabel2;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
       
        }

        #endregion
    }
