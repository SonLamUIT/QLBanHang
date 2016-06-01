using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using DAO;
namespace UI.UIPhieuNhapHang
{
    public partial class UILapChiTietPhieuNhapHang : MetroFramework.Forms.MetroForm
    {
        DAOPhieuNhapHang daopnh;
        public UILapChiTietPhieuNhapHang()
        {
            InitializeComponent();
            daopnh = new DAOPhieuNhapHang();
        }

        private void UILapChiTietPhieuNhapHang_Load(object sender, EventArgs e)
        {
            cbSoPhieuNhapHang.DataSource = daopnh.LayDanhSachSoPhieuNhapHang();
            cbSoPhieuNhapHang.DisplayMember = "SoPNH";
            cbSoPhieuNhapHang.ValueMember = "SoPNH";
            cbMaMatHang.DataSource = daopnh.LayDanhSachMaMatHang();
            cbMaMatHang.DisplayMember = "MaMatHang";
            cbMaMatHang.ValueMember = "MaMatHang";
        }
    }
}
