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
    public partial class frm_ChiTietPhieuNhapHang : MetroFramework.Forms.MetroForm
    {
        DataProvider dp;
        string SoPhieuNhapHang;
        public frm_ChiTietPhieuNhapHang(string SoPhieuNhapHang)
        {
            InitializeComponent();
            dp = new DataProvider();
            this.SoPhieuNhapHang = SoPhieuNhapHang;
        }

        private void btCapNhatDanhSachChiTietPhieuNhapHang_Click(object sender, EventArgs e)
        {
            dgvDanhSachChiTietPhieuNhapHang.DataSource = dp.layTatCaDuLieu(string.Format(
"select SoPNH [Số Phiếu Nhập Hàng], MaMatHang [Mã Mặt Hàng], SoLuongChuaNhap [Số Lượng Chưa Nhập], SoLuongNhap [Số Lượng Nhập], DonGiaNhap [Đơn Giá Nhập], ThanhTien [Thành Tiền] from CT_PNH where SoPNH='{0}' ORDER BY SoPNH ASC",this.SoPhieuNhapHang));
        }

        private void btThemChiTietPhieuNhapHang_Click(object sender, EventArgs e)
        {
            UILapChiTietPhieuNhapHang lctpnh = new UILapChiTietPhieuNhapHang(this.SoPhieuNhapHang);
            lctpnh.ShowDialog();
            dgvDanhSachChiTietPhieuNhapHang.DataSource = dp.layTatCaDuLieu("SELECT * FROM DBO.CT_PNH");
        }

        private void frm_ChiTietPhieuNhapHang_Load(object sender, EventArgs e)
        {
            dgvDanhSachChiTietPhieuNhapHang.DataSource = dp.layTatCaDuLieu(string.Format(
"select SoPNH [Số Phiếu Nhập Hàng], MaMatHang [Mã Mặt Hàng], SoLuongChuaNhap [Số Lượng Chưa Nhập], SoLuongNhap [Số Lượng Nhập], DonGiaNhap [Đơn Giá Nhập], ThanhTien [Thành Tiền] from CT_PNH where SoPNH='{0}' ORDER BY SoPNH ASC", this.SoPhieuNhapHang));
        }

        private void dgvDanhSachChiTietPhieuNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
