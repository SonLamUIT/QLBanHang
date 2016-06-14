using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using MetroFramework.Forms;
namespace UI
{
    public partial class frmDangNhap : MetroForm
    {
        DangNhapDAO dangnhapquyenadminbus = new DangNhapDAO();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            tbxTenDangNhap.Focus();
            this.AcceptButton = btDangNhap;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (tbxTenDangNhap.Text.Length == 0 || tbxMatKhau.Text.Length == 0)
            {
                lbTinhTrang.ForeColor = Color.Red;
                lbTinhTrang.Text = "Bạn chưa nhập tên tài khoản hoặc mật khẩu";
            }
            if (dangnhapquyenadminbus.DangNhap_Select_DAO(tbxTenDangNhap.Text.ToString(), tbxMatKhau.Text.ToString()))
            {
                Hide();
                Panel f = new Panel();
                f.ShowDialog();
                Close();
            }
            else
            {
                lbTinhTrang.ForeColor = Color.Red;
                lbTinhTrang.Text = "Sai mật khẩu hoặc tên tài khoản";
                tbxTenDangNhap.Clear();
                tbxTenDangNhap.Focus();
                tbxMatKhau.Clear();
            }
        }

    }
}
