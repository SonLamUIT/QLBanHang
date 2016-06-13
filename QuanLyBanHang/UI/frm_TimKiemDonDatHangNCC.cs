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
    public partial class frm_TimKiemDonDatHangNCC : MetroForm
    {
        DonDatHang_DAO obj_DonDatHang_DAO = new DonDatHang_DAO();
        int selectIndex;
        public frm_TimKiemDonDatHangNCC(int selectIndex)
        {
            InitializeComponent();
            this.selectIndex = selectIndex;
        }

        private void cbx_Ncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_SoDDH.DataSource = obj_DonDatHang_DAO.layTatCaSoDDH_NCCTheoNCC(cbx_Ncc.GetItemText(cbx_Ncc.SelectedItem));
            cbx_SoDDH.DisplayMember = "SoDDH_NCC";
            cbx_SoDDH.ValueMember = "SoDDH_NCC";
        }

        private void frm_TimKiemDonDatHangNCC_Load(object sender, EventArgs e)
        {
            cbx_Ncc.DataSource = obj_DonDatHang_DAO.layTatcaNCC();
            cbx_Ncc.DisplayMember = "TenDoiTac";
            cbx_Ncc.ValueMember = "TenDoiTac";
            cbx_Ncc.SelectedIndex = 0;
        }

        private void cbx_SoDDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgrid_TimKiemHDBL.DataSource = obj_DonDatHang_DAO.timKiemThongTinKH(cbx_Ncc.GetItemText(cbx_Ncc.SelectedItem), cbx_SoDDH.GetItemText(cbx_SoDDH.SelectedItem));
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
