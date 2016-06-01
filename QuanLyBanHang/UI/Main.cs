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
namespace UI
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        DBConnection db;
        public Main()
        {
            db = new DBConnection();
            InitializeComponent();
            
        }
        private void btCapNhatDanhSachPhieuNhapHang_Click(object sender, EventArgs e)
        {
            dgvDanhSachPhieuNhapHang.DataSource = db.Lay_TatCa_DuLieu("exec LayDanhSachPhieuNhapHang");
        }
        private void btCapNhatDanhSachChiTietPhieuNhapHang_Click(object sender, EventArgs e)
        {
            dgvDanhSachChiTietPhieuNhapHang.DataSource = db.Lay_TatCa_DuLieu("exec LayDanhSachChiTietPhieuNhapHang");
        }

        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void btThemPhieuNhapHang_Click(object sender, EventArgs e)
        {
            UI.UIPhieuNhapHang.UILapPhieuNhapHang lpnh = new UIPhieuNhapHang.UILapPhieuNhapHang();
            lpnh.ShowDialog();
        }

        private void btThemChiTietPhieuNhapHang_Click(object sender, EventArgs e)
        {
            UI.UIPhieuNhapHang.UILapChiTietPhieuNhapHang lctpnh = new UIPhieuNhapHang.UILapChiTietPhieuNhapHang();
            lctpnh.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dgvDanhSachPhieuNhapHang.DataSource = db.Lay_TatCa_DuLieu("exec LayDanhSachPhieuNhapHang");
            dgvDanhSachChiTietPhieuNhapHang.DataSource = db.Lay_TatCa_DuLieu("exec LayDanhSachChiTietPhieuNhapHang");
        }
    }
}
