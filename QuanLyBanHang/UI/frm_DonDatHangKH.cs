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
    public partial class frm_DonDatHangKH : MetroForm
    {
        DonDatHangKH_DAO obj_DDHKH_DAO = new DonDatHangKH_DAO();
        DonDatHang_KH obj_DDHKH_DTO = new DonDatHang_KH();
        CTDDH_KH_DAO obj_CTDDHKH_DAO = new CTDDH_KH_DAO();
        public frm_DonDatHangKH()
        {
            InitializeComponent();
            dtgrid_ctddhKH.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dtgrid_ctddhKH_EditingControlShowing);
        }

        private void frm_DonDatHangKH_Load(object sender, EventArgs e)
        {
            cbx_tenkhachhang.DataSource = obj_DDHKH_DAO.layTatCaDoiTacKH();
            cbx_tenkhachhang.DisplayMember = "TenDoiTac";
            cbx_tenkhachhang.ValueMember = "TenDoiTac";
            cbx_tenkhachhang.SelectedIndex = 0;


            cbx_mathang.DataSource = obj_DDHKH_DAO.layTatCaTenMatHang();
            cbx_mathang.DisplayMember = "TenMatHang";
            cbx_mathang.ValueMember = "TenMatHang";

            dtgrid_ctddhKH.Columns["column_soluongdagiao"].DefaultCellStyle.BackColor = Color.LightGray;
            dtgrid_ctddhKH.Columns["column_soluongchuagiao"].DefaultCellStyle.BackColor = Color.LightGray;
        }

        private void btn_dathang_Click(object sender, EventArgs e)
        {
            if (dateTime_ngaylap.Value.Date > dateTime_ngaygiaodukien.Value.Date)
            {
                MessageBox.Show("Ngày giao hàng phải sau này đặt hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            obj_DDHKH_DTO.MaDoiTac = obj_DDHKH_DAO.layMaDoiTacTheoTenDT(cbx_tenkhachhang.GetItemText(cbx_tenkhachhang.SelectedItem));
            obj_DDHKH_DTO.NgayLap = DateTime.Parse(dateTime_ngaygiaodukien.Text);
            obj_DDHKH_DTO.NgayGiaoHang = DateTime.Parse(dateTime_ngaygiaodukien.Text);
            try
            {
                //Kiem tra xem mat hang do khach hang da mua chua va cap nhat so luong dat
                //Lam chi tiet phieu giao hang

                if (obj_DDHKH_DAO.insertDDH_KH(obj_DDHKH_DTO.MaDoiTac, obj_DDHKH_DTO.NgayLap, obj_DDHKH_DTO.NgayGiaoHang))
                {
                    for (int row = 0; row < dtgrid_ctddhKH.RowCount - 1; row++)
                    {
                        string soddhKH = obj_DDHKH_DAO.laySoDDHKHCuoi();
                        string maMH = obj_DDHKH_DAO.layMaMHTheoTenMatHang(dtgrid_ctddhKH.Rows[row].Cells["cbx_mathang"].Value.ToString());
                        int sldat = Int32.Parse(dtgrid_ctddhKH.Rows[row].Cells["column_soluongdat"].Value.ToString());
                        int sldagiao = Int32.Parse(dtgrid_ctddhKH.Rows[row].Cells["column_soluongdagiao"].Value.ToString());
                        int slchuagiao = Int32.Parse(dtgrid_ctddhKH.Rows[row].Cells["column_soluongchuagiao"].Value.ToString());
                        obj_CTDDHKH_DAO.themCT_DDHKH(soddhKH, maMH, sldat, sldagiao);
                    }

                    MessageBox.Show("Đặt hàng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đặt hàng thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["column_soluongdat"].Value = 0;
            e.Row.Cells["column_soluongdagiao"].Value = 0;
            e.Row.Cells["column_soluongchuagiao"].Value = 0;
        }
        private void dtgrid_ctddhKH_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(columnSoLuong_KeyPress);
            if (dtgrid_ctddhKH.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(columnSoLuong_KeyPress);
                }
            }

            e.Control.KeyPress -= new KeyPressEventHandler(columnDonGia_KeyPress);
            if (dtgrid_ctddhKH.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(columnDonGia_KeyPress);
                }
            }
        }

        private void columnSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void columnDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fPhieuGiaoHang = new frm_PhieuGiaoHang();
            fPhieuGiaoHang.ShowDialog();
        }

        private void dtgrid_ctddhKH_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            int sldagiao =Int32.Parse(dtgrid_ctddhKH.CurrentRow.Cells["column_soluongdagiao"].Value.ToString());
            int sldat =Int32.Parse(dtgrid_ctddhKH.CurrentRow.Cells["column_soluongdat"].Value.ToString());
            dtgrid_ctddhKH.CurrentRow.Cells["column_soluongchuagiao"].Value = sldat - sldagiao;
        }
    }
}
