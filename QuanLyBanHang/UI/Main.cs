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
using DTO;
namespace UI
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        

        DataProvider dp;
        public static bool IsNumeric(object Expression)
        {
            double retNum;
            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
        public Main()
        {
            dp = new DataProvider();
            InitializeComponent();
            
        }
        private void btCapNhatDanhSachPhieuNhapHang_Click(object sender, EventArgs e)
        {
            dgvDanhSachPhieuNhapHang.DataSource = dp.layTatCaDuLieu("exec LayDanhSachPhieuNhapHang");
        }
        private void btCapNhatDanhSachChiTietPhieuNhapHang_Click(object sender, EventArgs e)
        {
            dgvDanhSachChiTietPhieuNhapHang.DataSource = dp.layTatCaDuLieu("exec LayDanhSachChiTietPhieuNhapHang");
        }

        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void btThemPhieuNhapHang_Click(object sender, EventArgs e)
        {
            UI.UIPhieuNhapHang.UILapPhieuNhapHang lpnh = new UIPhieuNhapHang.UILapPhieuNhapHang();
            lpnh.ShowDialog();
            dgvDanhSachPhieuNhapHang.DataSource = dp.layTatCaDuLieu("exec LayDanhSachPhieuNhapHang");
        }

        private void btThemChiTietPhieuNhapHang_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            //nạp dữ liệu lúc chương trình khởi động, dữ liệu bao gồm các bảng lưu trong cơ sở dữ liệu
            dgvDanhSachPhieuNhapHang.DataSource = dp.layTatCaDuLieu("exec LayDanhSachPhieuNhapHang");
            dgvDanhSachChiTietPhieuNhapHang.DataSource = dp.layTatCaDuLieu("exec LayDanhSachChiTietPhieuNhapHang");
            dgvThuChi.DataSource = dp.layTatCaDuLieu("SELECT SoPTC [Số Phiếu Thu Chi],NgayLap [Ngày Lập], MaDoiTac [Mã Đối Tác], TongNo [Tổng Nợ], SoTien [Số Tiền] FROM PHIEUTHUCHI");
        
        }

        private void btSuaCTPNH_Click(object sender, EventArgs e)
        {

        }

        //Sửa phiếu nhập hàng
        private void btSuaPNH_Click(object sender, EventArgs e)
        {

            PhieuNhapHang dtopnh = new PhieuNhapHang();
            DAOPhieuNhapHang daopnh = new DAOPhieuNhapHang();            
            if (dgvDanhSachPhieuNhapHang.CurrentRow.Cells[0].Value.ToString()==""|| dgvDanhSachPhieuNhapHang.CurrentRow.Cells[1].Value.ToString()==null)
                MessageBox.Show("DỮ liệu rỗng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dtopnh.SoPNH= dgvDanhSachPhieuNhapHang.CurrentRow.Cells[0].Value.ToString();
                dtopnh.SoDDH_NCC = dgvDanhSachPhieuNhapHang.CurrentRow.Cells[1].Value.ToString();
                dtopnh.NgayNhap= dgvDanhSachPhieuNhapHang.CurrentRow.Cells[2].Value.ToString();
                dtopnh.TongTien= Convert.ToInt64(dgvDanhSachPhieuNhapHang.CurrentRow.Cells[3].Value);
                dtopnh.ThanhToan = Convert.ToInt64(dgvDanhSachPhieuNhapHang.CurrentRow.Cells[4].Value);
                dtopnh.ConLai = Convert.ToInt64(dgvDanhSachPhieuNhapHang.CurrentRow.Cells[5].Value);
                UI.UIPhieuNhapHang.UISuaPhieuNhapHang spnh = new UIPhieuNhapHang.UISuaPhieuNhapHang(dtopnh);
                spnh.ShowDialog();
            }
            dgvDanhSachPhieuNhapHang.DataSource= dp.layTatCaDuLieu("exec LayDanhSachPhieuNhapHang");
        }

        //cập nhật danh sách phiếu thu chi
        private void btCapNhatPhieuThuChi_Click(object sender, EventArgs e)
        {
            dgvThuChi.DataSource = dp.layTatCaDuLieu("SELECT SoPTC [Số Phiếu Thu Chi],NgayLap [Ngày Lập], MaDoiTac [Mã Đối Tác], TongNo [Tổng Nợ], SoTien [Số Tiền] FROM PHIEUTHUCHI");
        }

        private void btThemPhieuThuChi_Click(object sender, EventArgs e)
        {
            UI.UIPhieuThuChi.UILapPhieuThuChi uilptc = new UIPhieuThuChi.UILapPhieuThuChi();
            uilptc.ShowDialog();
            dgvThuChi.DataSource = dp.layTatCaDuLieu("SELECT SoPTC [Số Phiếu Thu Chi],NgayLap [Ngày Lập], MaDoiTac [Mã Đối Tác], TongNo [Tổng Nợ], SoTien [Số Tiền] FROM PHIEUTHUCHI");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            UI.BaoCao.BaoCaoDoanhThuTheoMatHang bcdttmh = new BaoCao.BaoCaoDoanhThuTheoMatHang();
            bcdttmh.ShowDialog();
        }
        private void btCapNhatThuChi_Click(object sender, EventArgs e)
        {
            dgvThuChi.DataSource = dp.layTatCaDuLieu("SELECT SoPTC [Số Phiếu Thu Chi],NgayLap [Ngày Lập], MaDoiTac [Mã Đối Tác], TongNo [Tổng Nợ], SoTien [Số Tiền] FROM PHIEUTHUCHI");
        }

        private void btThemThuChi_Click(object sender, EventArgs e)
        {
            UI.UIPhieuThuChi.UILapPhieuThuChi uilptc = new UIPhieuThuChi.UILapPhieuThuChi();
            uilptc.ShowDialog();
            dgvThuChi.DataSource = dp.layTatCaDuLieu("SELECT SoPTC [Số Phiếu Thu Chi],NgayLap [Ngày Lập], MaDoiTac [Mã Đối Tác], TongNo [Tổng Nợ], SoTien [Số Tiền] FROM PHIEUTHUCHI");
        }

        private void btBaoCaoDoanhThuTheoMatHang_Click(object sender, EventArgs e)
        {
            UI.BaoCao.BaoCaoDoanhThuTheoMatHang bcdttmh = new BaoCao.BaoCaoDoanhThuTheoMatHang();
            bcdttmh.ShowDialog();
        }

        private void dgvDanhSachChiTietPhieuNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
