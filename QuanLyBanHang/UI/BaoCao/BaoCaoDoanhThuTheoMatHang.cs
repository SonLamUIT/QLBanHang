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
using System.Data.SqlClient;
using MetroFramework;
using CrystalDecisions.CrystalReports.Engine;
namespace UI.BaoCao
{
    public partial class BaoCaoDoanhThuTheoMatHang : MetroFramework.Forms.MetroForm
    {
        DAOBaoCao daobc;
        DataSet ds;
        public BaoCaoDoanhThuTheoMatHang()
        {
            InitializeComponent();
            daobc = new DAOBaoCao();     
        }
        private void BaoCaoDoanhThuTheoMatHang_Load(object sender, EventArgs e)
        {
           
        }
        private void btXuatBaoCao_Click(object sender, EventArgs e)
        {
            dgvBaoCao.DataSource = daobc.layTatCaDuLieu(string.Format("exec BaoCaoLoiNhuanTheoMatHangTheoThoiGian '{0}'", datNgayLap.Value.ToString("dd/mm/yyyy")));
            daobc.ThuThiQuerry(datNgayLap.Value.ToString("dd/mm/yyyy"));
            ReportDocument crystalReport = new ReportDocument();
            crystalReport.Load(@"D:\Term VI\Phân tích thiết kế hệ thống\QLBanHang\QuanLyBanHang\UI\BaoCao\CRBaoCaoDoanhThu.rpt");
            crbc.ReportSource = crystalReport;
            crbc.Refresh();
        }
    }
}
