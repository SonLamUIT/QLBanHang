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
    public partial class frm_KiemTraSoDDH_KH : MetroForm
    {
        String tenkh, sohd;
        PhieuGiaoHang_DAO obj_PGH_DAO = new PhieuGiaoHang_DAO();
        public frm_KiemTraSoDDH_KH()
        {
            InitializeComponent();
        }
        public frm_KiemTraSoDDH_KH(string txt_ten, string txt_soddh)
        {
            InitializeComponent();
            tenkh = txt_ten;
            sohd = txt_soddh;
        }

        private void frm_KiemTraSoDDH_KH_Load(object sender, EventArgs e)
        {
            tbx_khachang.Text = tenkh;
            tbx_SoDonDatHang.Text = sohd;
            dtgrid_KtDonDatHang.DataSource = obj_PGH_DAO.layTatCaDDHTheoTenSoDDH(tbx_khachang.Text, tbx_SoDonDatHang.Text);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
