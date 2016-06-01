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
        DBConnection db;
        public UIChiTietPhieuNhapHang()
        {
            db = new DBConnection();
            InitializeComponent();
            dgvDanhSachChiTietPhieuNhapHang.DataSource = db.Lay_TatCa_DuLieu("exec LayDanhSachChiTietPhieuNhapHang");
        }
    }
}
