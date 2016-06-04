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
        

        DBConnection db;
        public static bool IsNumeric(object Expression)
        {
            double retNum;
            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
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
            dgvDanhSachPhieuNhapHang.DataSource = db.Lay_TatCa_DuLieu("exec LayDanhSachPhieuNhapHang");
        }

        private void btThemChiTietPhieuNhapHang_Click(object sender, EventArgs e)
        {
            UI.UIPhieuNhapHang.UILapChiTietPhieuNhapHang lctpnh = new UIPhieuNhapHang.UILapChiTietPhieuNhapHang();
            lctpnh.ShowDialog();
            dgvDanhSachChiTietPhieuNhapHang.DataSource = db.Lay_TatCa_DuLieu("SELECT * FROM DBO.CT_PNH");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dgvDanhSachPhieuNhapHang.DataSource = db.Lay_TatCa_DuLieu("exec LayDanhSachPhieuNhapHang");
            dgvDanhSachChiTietPhieuNhapHang.DataSource = db.Lay_TatCa_DuLieu("exec LayDanhSachChiTietPhieuNhapHang");
        }

        private void btSuaCTPNH_Click(object sender, EventArgs e)
        {

        }

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
                dtopnh.TongTien= Convert.ToUInt64(dgvDanhSachPhieuNhapHang.CurrentRow.Cells[3].Value);
                dtopnh.ThanhToan = Convert.ToUInt64(dgvDanhSachPhieuNhapHang.CurrentRow.Cells[4].Value);
                dtopnh.ConLai = Convert.ToUInt64(dgvDanhSachPhieuNhapHang.CurrentRow.Cells[5].Value);
                UI.UIPhieuNhapHang.UISuaPhieuNhapHang spnh = new UIPhieuNhapHang.UISuaPhieuNhapHang(dtopnh);
                spnh.ShowDialog();
            }
            dgvDanhSachPhieuNhapHang.DataSource= db.Lay_TatCa_DuLieu("exec LayDanhSachPhieuNhapHang");
        }
    }
}
