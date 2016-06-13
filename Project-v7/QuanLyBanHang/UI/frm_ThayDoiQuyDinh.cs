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
    public partial class frm_ThayDoiQuyDinh : MetroForm
    {
        ThamSo_DAO obj_TS_DAO = new ThamSo_DAO();
        ThamSo ts = new ThamSo();
        public frm_ThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            ts.TiLeGiaLe = Double.Parse(tbx_HeSoBanLe.Text);
            ts.TiLeGiaSi = Double.Parse(tbx_HeSoBanSi.Text);
            

            DialogResult dio_result = MessageBox.Show("Bạn có chắc muốn cập nhật tỉ lệ bán sỉ và tỉ lệ bán lẻ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dio_result == DialogResult.Cancel)
            {
                return;
            }
            if (dio_result == DialogResult.OK) ;
            {
                obj_TS_DAO.UpdateThamSo(ts);
                return;
            }
        }

        private void tbx_HeSoBanSi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbx_HeSoBanLe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
