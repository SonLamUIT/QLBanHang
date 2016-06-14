using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using DAO;
using DTO;
namespace UI
{
    public partial class frmSaoLuu : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmSaoLuu()
        {
            InitializeComponent();
        }
          private void frmChonFolder_Load(object sender, EventArgs e)
        {

            tbxTenFile.Clear();
            foreach (DriveInfo drv in DriveInfo.GetDrives())
            {
                if (drv.IsReady)
                {
                    TreeNode t2 = new TreeNode();
                    t2.Text = drv.Name;
                    t2.Nodes.Add("");
                    treeView1.Nodes.Add(t2);
                }
            }
        }
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                TreeNode parentnode = e.Node;
                DirectoryInfo dr = new DirectoryInfo(parentnode.FullPath);
                parentnode.Nodes.Clear();
                foreach (DirectoryInfo dir in dr.GetDirectories())
                {
                    TreeNode node = new TreeNode();
                    node.Text = dir.Name;
                    node.Nodes.Add("");
                    parentnode.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!");
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode current = e.Node;
                string path = current.FullPath;
                string[] Files = Directory.GetFiles(path);
                string[] Directories = Directory.GetDirectories(path);
                string[] subinfo = new string[3];
                tbxPath.Text = path.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!");
            }
        }
        private void btSaoLuu_Click(object sender, EventArgs e)
        {
            DAO_SaoLuuDuLieu dl = new DAO_SaoLuuDuLieu();            
            if (tbxPath.Text == "" || tbxTenFile.Text == "")
                MessageBox.Show("Hãy chọn nơi cần lưu và nhập tên cho tập tin sao lưu", "Thông báo", MessageBoxButtons.OK);
            else
            {   
                string filePath = tbxPath.Text.ToString() + tbxTenFile.Text.ToString()+".mdf";
                    if (System.IO.File.Exists(filePath))
                    {
                        MessageBox.Show("Tên file đã tồn tại","Thông Báo",MessageBoxButtons.OK);
                    }
                    else
                    {
                        dl.SaoLuuDuLieuDAO(tbxPath.Text.ToString(), tbxTenFile.Text.ToString());
                      
                        if (System.IO.File.Exists(filePath))
                        {
                            MessageBox.Show("Sao lưu thành công", "Thông Báo", MessageBoxButtons.OK);
                            tbxTenFile.Clear();
                        }
                        else
                            MessageBox.Show("Sao lưu không thành công", "Thông Báo", MessageBoxButtons.OK);
                    } 
            }
                
        }

       
    }
}