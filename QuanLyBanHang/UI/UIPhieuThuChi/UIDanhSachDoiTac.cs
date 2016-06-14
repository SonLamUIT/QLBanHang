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
namespace UI.UIPhieuThuChi
{
    public partial class UIDanhSachDoiTac : MetroFramework.Forms.MetroForm
    {
        DAOThuChi daotc;
        
        public UIDanhSachDoiTac()
        {
            InitializeComponent();
            daotc = new DAOThuChi();
            
        }

        private void UIDanhSachDoiTac_Load(object sender, EventArgs e)
        {
            dgvDanhSachDoiTac.DataSource = daotc.layTatCaDuLieu("SELECT MaDoiTac [Mã Đối Tác], TenDoiTac [Tên Đối Tác],MaLoaiDoiTac [Mã Loại Đốc Tác], SDT [Số Điện Thoại], DiaChi [Địa Chỉ], SoTienNo [Số Tiền Nợ] FROM DOITAC");
        }
    }
}
