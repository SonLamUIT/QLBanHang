using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace UI
{
    public partial class Panel : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void metroTileItem1_Click(object sender, EventArgs e)
        {

        }

        private void metroTileItem13_Click(object sender, EventArgs e)
        {

        }

        private void metroTileItem11_Click(object sender, EventArgs e)
        {

        }

        private void mttDoiTac_Click(object sender, EventArgs e)
        {
            frm_DoiTac frmdt = new frm_DoiTac();
            frmdt.ShowDialog();
        }

        private void mttMatHang_Click(object sender, EventArgs e)
        {
            frm_MatHang frmmh = new frm_MatHang();
            frmmh.ShowDialog();
        }

        private void mttHoaDon_Click(object sender, EventArgs e)
        {
            frm_HoaDonBanLe frmhdbl = new frm_HoaDonBanLe();
            frmhdbl.ShowDialog();
        }

        private void mttDonDatHang_Click(object sender, EventArgs e)
        {
            
        }

        private void mttQuyDinh_Click(object sender, EventArgs e)
        {
            frm_ThayDoiQuyDinh frmtdqd = new frm_ThayDoiQuyDinh();
            frmtdqd.ShowDialog();
        }
    }
}