using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using MetroFramework.Forms;
using DAO;

namespace UI
{
    public partial class frm_TimKiemHDBL : MetroForm
    {
        HoaDonBanLe_DAO obj_HDBL_DAO = new HoaDonBanLe_DAO();
        public frm_TimKiemHDBL()
        {
            InitializeComponent();
        }

        private void frm_TimKiemHDBL_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dtgrid_TimKiemHDBL.DataSource = obj_HDBL_DAO.timKiemThongTinKH(tbx_khachhang.Text);
        }

        private void frm_TimKiemHDBL_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
