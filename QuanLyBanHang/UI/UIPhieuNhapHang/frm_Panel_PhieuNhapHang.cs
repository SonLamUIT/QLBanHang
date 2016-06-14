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
using DTO;

namespace UI.UIPhieuNhapHang
{
    public partial class frm_Panel_PhieuNhapHang : MetroFramework.Forms.MetroForm
    {
        DataProvider dp; 
        public frm_Panel_PhieuNhapHang()
        {
            InitializeComponent();
            dp = new DataProvider();
        }
        private void frm_Panel_PhieuNhapHang_Load(object sender, EventArgs e)
        {
            dgvDanhSachPhieuNhapHang.DataSource = dp.layTatCaDuLieu("exec LayDanhSachPhieuNhapHang");
        }
        private void btCapNhatDanhSachPhieuNhapHang_Click(object sender, EventArgs e)
        {
            dgvDanhSachPhieuNhapHang.DataSource = dp.layTatCaDuLieu("exec LayDanhSachPhieuNhapHang");
        }
        private void btThemPhieuNhapHang_Click(object sender, EventArgs e)
        {
            UI.UIPhieuNhapHang.UILapPhieuNhapHang lpnh = new UIPhieuNhapHang.UILapPhieuNhapHang();
            lpnh.ShowDialog();
            dgvDanhSachPhieuNhapHang.DataSource = dp.layTatCaDuLieu("exec LayDanhSachPhieuNhapHang");
        }
        private void datNgapLap_ValueChanged(object sender, EventArgs e)
        {
            string date = datNgapLap.Value.ToString("dd/mm/yyyy");
            dp.layTatCaDuLieu("");
        }
        private void dgvDanhSachPhieuNhapHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_ChiTietPhieuNhapHang ctpnh = new frm_ChiTietPhieuNhapHang(dgvDanhSachPhieuNhapHang.CurrentRow.Cells[0].Value.ToString());
            ctpnh.ShowDialog();
            dgvDanhSachPhieuNhapHang.DataSource = dp.layTatCaDuLieu("exec LayDanhSachPhieuNhapHang");
        }
        private void dgvDanhSachPhieuNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_ChiTietPhieuNhapHang ctpnh = new frm_ChiTietPhieuNhapHang(dgvDanhSachPhieuNhapHang.CurrentRow.Cells[0].Value.ToString());
            ctpnh.ShowDialog();
            dgvDanhSachPhieuNhapHang.DataSource = dp.layTatCaDuLieu("exec LayDanhSachPhieuNhapHang");
        }
    }
}
