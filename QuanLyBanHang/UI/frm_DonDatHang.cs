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
namespace UI
{
    public partial class frm_DonDatHang : MetroFramework.Forms.MetroForm
    {
        DataProvider dp;
        public frm_DonDatHang()
        {
            InitializeComponent();
            dp = new DataProvider();
        }
        private void frm_DonDatHang_Load(object sender, EventArgs e)
        {
            dgvDonDatHangNCC.DataSource = dp.layTatCaDuLieu("SELECT SoDDH_NCC [Số Đơn Đặt Hàng Nhà Cung Cấp], MaDoiTac [Mã Đối Tác], Ngaylap [Ngày Lập]  FROM[QuanLyBanHang].[dbo].[DONDATHANG_NCC]");
            dvgDonDatHangKH.DataSource = dp.layTatCaDuLieu("SELECT SoDDH_KH [Số Đơn Đặt Hàng Khách Hàng], MaDoiTac [Mã Đối Tác], NgayLap [Ngày Lập], NgayGiaoHangDuKien [Ngày Giao Hàng Dự Kiến] FROM[QuanLyBanHang].[dbo].[DONDATHANG_KH]");
        }
        private void btLamMoi_Click(object sender, EventArgs e)
        {
            dgvDonDatHangNCC.DataSource = dp.layTatCaDuLieu("SELECT SoDDH_NCC [Số Đơn Đặt Hàng Nhà Cung Cấp], MaDoiTac [Mã Đối Tác], Ngaylap [Ngày Lập]  FROM[QuanLyBanHang].[dbo].[DONDATHANG_NCC]");
            dvgDonDatHangKH.DataSource = dp.layTatCaDuLieu("SELECT SoDDH_KH [Số Đơn Đặt Hàng Khách Hàng], MaDoiTac [Mã Đối Tác], NgayLap [Ngày Lập], NgayGiaoHangDuKien [Ngày Giao Hàng Dự Kiến] FROM[QuanLyBanHang].[dbo].[DONDATHANG_KH]");
        }

        private void btDDHKH_Click(object sender, EventArgs e)
        {
            frm_DonDatHangKH kh = new frm_DonDatHangKH();
            kh.ShowDialog();
        }
        private void btDDHNCC_Click(object sender, EventArgs e)
        {
            frm_DonDatHangNCC ncc = new frm_DonDatHangNCC();
            ncc.ShowDialog();
        }
    }
}
