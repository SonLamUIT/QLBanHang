using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DAO;
using System.IO;
namespace UI
{
    public partial class frmPhucHoiDuLieu : MetroForm
    {
        public frmPhucHoiDuLieu()
        {
            InitializeComponent();
        }
        private void frmPhucHoiDuLieu_Load(object sender, EventArgs e)
        {

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
        public string GetFileName(string path)
        {
            int Nameindex = path.LastIndexOf('\\');
            return path.Substring(Nameindex + 1);
        }
        public string GetTypeinfo(string path)
        {
            string FType;
            FType = Path.GetExtension(path);
            return FType;
        }
        public string GetSizeinfo(string path)
        {
            FileInfo fi = new FileInfo(path);
            long size = fi.Length;
            string txtsize = "";
            if (size < 1024)
            {
                txtsize = "byte";
            }
            else if (size > 1024)
            {
                size = size / 1024;
                txtsize = "Kb";
            }
            if (size > 1024)
            {
                size = size / 1024;
                txtsize = "Mb";
            }
            if (size > 1024)
            {
                size = size / 1024;
                txtsize = "Gb";
            }
            return size + " " + txtsize;
        }
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                tbxTenFile.Clear();
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
                listView1.Clear();
                listView1.Columns.Add("Name", 255);
                listView1.Columns.Add("Size", 100);
                listView1.Columns.Add("Type", 80);
                foreach (string Dname in Directories)
                {
                    subinfo[0] = GetFileName(Dname);
                    subinfo[1] = "";
                    subinfo[2] = "FOLDER";
                    ListViewItem DItems = new ListViewItem(subinfo);
                    listView1.Items.Add(DItems);
                    tbxPath.Text = path.ToString();
                }
                foreach (string Fname in Files)
                {
                    subinfo[0] = GetFileName(Fname);
                    subinfo[1] = GetSizeinfo(Fname);
                    subinfo[2] = GetTypeinfo(Fname);
                    ListViewItem FItems = new ListViewItem(subinfo);
                    listView1.Items.Add(FItems);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!");
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem item = listView1.SelectedItems[0];
            //fill the text boxes
            tbxTenFile.Text = item.Text;
        }
        private void btPhucHoi_Click(object sender, EventArgs e)
        {
            DAO_SaoLuuDuLieu dl = new DAO_SaoLuuDuLieu();
            string path1;
            if ((tbxPath.Text == "") || (tbxTenFile.Text == "") || (GetTypeinfo(tbxTenFile.Text) == "mdf") || (GetTypeinfo(tbxTenFile.Text) == "MDF"))
            {
                path1 = tbxPath.Text + tbxTenFile.Text;
                MessageBox.Show("Hãy chọn đúng file cần phục hồi", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                path1 = tbxPath.Text + tbxTenFile.Text;
                dl.PhucHoiDuLieuDAO(path1);
                MessageBox.Show("Phục hồi thành công", "Thông Báo", MessageBoxButtons.OK);
                tbxTenFile.Clear();
            }
        }
    }
}
