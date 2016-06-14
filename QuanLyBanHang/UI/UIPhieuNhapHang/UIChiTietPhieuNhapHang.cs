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
    public partial class UIChiTietPhieuNhapHang : MetroFramework.Forms.MetroForm
    {
        DataProvider dp;
        public UIChiTietPhieuNhapHang()
        {
            dp = new DataProvider();
            InitializeComponent();
            dgvDanhSachChiTietPhieuNhapHang.DataSource = dp.layTatCaDuLieu("exec LayDanhSachChiTietPhieuNhapHang");
        }
    }
}
