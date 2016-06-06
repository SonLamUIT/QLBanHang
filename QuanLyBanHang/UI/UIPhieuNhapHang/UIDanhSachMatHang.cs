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
using MetroFramework;
namespace UI.UIPhieuNhapHang
{
    public partial class UIDanhSachMatHang : MetroFramework.Forms.MetroForm
    {
        DAOPhieuNhapHang daopnh;
        public UIDanhSachMatHang()
        {
            InitializeComponent();
            daopnh = new DAOPhieuNhapHang();
        }

        private void UIDanhSachMatHang_Load(object sender, EventArgs e)
        {
            dgvDanhSachMatHang.DataSource = daopnh.Lay_TatCa_DuLieu("SELECT * FROM dbo.MATHANG order by MaMatHang asc");
        }
    }
}
