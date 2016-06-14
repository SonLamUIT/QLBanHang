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
namespace UI.UIPhieuThuChi
{
    public partial class frm_ThuChi : MetroFramework.Forms.MetroForm
    {
        DataProvider dp;
        public frm_ThuChi()
        {
            InitializeComponent();
            dp = new DataProvider();                    
        }       
        private void frm_ThuChi_Load(object sender, EventArgs e)
        {
            dgvThuChi.DataSource = dp.layTatCaDuLieu("SELECT SoPTC [Số Phiếu Thu Chi],NgayLap [Ngày Lập], MaDoiTac [Mã Đối Tác], TongNo [Tổng Nợ], SoTien [Số Tiền] FROM PHIEUTHUCHI");
        }
        private void btCapNhatThuChi_Click(object sender, EventArgs e)
        {
            dgvThuChi.DataSource = dp.layTatCaDuLieu("SELECT SoPTC [Số Phiếu Thu Chi],NgayLap [Ngày Lập], MaDoiTac [Mã Đối Tác], TongNo [Tổng Nợ], SoTien [Số Tiền] FROM PHIEUTHUCHI");
        }
        private void btThemThuChi_Click(object sender, EventArgs e)
        {
            UI.UIPhieuThuChi.UILapPhieuThuChi lptc = new UILapPhieuThuChi();
            lptc.ShowDialog();
        }
        private void datNgayLap_ValueChanged(object sender, EventArgs e)
        {
            string ngayLap;
            ngayLap = datNgayLap.Value.ToString("dd/mm/yyyy");
            dgvThuChi.DataSource = dp.layTatCaDuLieu(string.Format("SELECT SoPTC [Số Phiếu Thu Chi],NgayLap [Ngày Lập], MaDoiTac [Mã Đối Tác], TongNo [Tổng Nợ], SoTien [Số Tiền] FROM PHIEUTHUCHI WHRE NgayLap='{0}'", ngayLap));
        }
    }
}
