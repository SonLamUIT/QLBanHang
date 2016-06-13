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
    public partial class frm_HoaDonBanLe : MetroForm
    {
        HoaDonBanLe_DAO obj_HDBL_DAO = new HoaDonBanLe_DAO();
        HoaDonBanLe obj_HDBL_DTO = new HoaDonBanLe();
        CTHDBL_DAO obj_CTHDBL_DAO = new CTHDBL_DAO();
        ThamSo_DAO obj_TS_DAO = new ThamSo_DAO();
        Double TLGiaSi;
        Double TLGiaLe;
        
        public frm_HoaDonBanLe()
        {
            InitializeComponent();
            dtgrid_mathang.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dtgrid_mathang_EditingControlShowing);
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            obj_HDBL_DTO.TenKH = tbx_khachhang.Text;
            obj_HDBL_DTO.NgayLap = DateTime.Parse(datetime_NgayLap.Text);
            try
            {
                if (obj_HDBL_DAO.runInsertHDBL(obj_HDBL_DTO.TenKH, obj_HDBL_DTO.NgayLap, 0))
                {
                    for (int row = 0; row < dtgrid_mathang.RowCount - 1; row++)
                    {
                        string soHD = obj_HDBL_DAO.laySoHDCuoi();
                        string maMH = obj_HDBL_DAO.layMaMHTheoTenMatHang(dtgrid_mathang.Rows[row].Cells["cbx_tenmathang"].Value.ToString());
                        int sl = Int32.Parse(dtgrid_mathang.Rows[row].Cells["column_SoLuong"].Value.ToString());
                        double dongia = Double.Parse(dtgrid_mathang.Rows[row].Cells["column_DonGia"].Value.ToString());
                        obj_CTHDBL_DAO.themCTHDBL(soHD, maMH, sl, dongia, ((sl * dongia * TLGiaLe) + (sl * dongia)));
                    }
                    tbx_tongthanhtien.Text = obj_HDBL_DAO.tinhTongThanhTien(obj_HDBL_DAO.laySoHDCuoi());
                    obj_HDBL_DAO.capNhatTongThanhTien(Double.Parse(tbx_tongthanhtien.Text), obj_HDBL_DAO.laySoHDCuoi());
                    MessageBox.Show("Thanh toán thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Reset textbox ten khach hang va datagridview
                    tbx_khachhang.ResetText();
                    dtgrid_mathang.Rows.Clear();
                }
            }catch(Exception){
                MessageBox.Show("Thanh toán thất bại! Vui lòng kiểm tra lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void frm_HoaDonBanLe_Load(object sender, EventArgs e)
        {
            
            cbx_tenmathang.DataSource = obj_CTHDBL_DAO.layTatCaTenMatHang();
            cbx_tenmathang.DisplayMember = "TenMatHang";
            cbx_tenmathang.ValueMember = "TenMatHang";

            btn_ThanhToan.Enabled = false;

            dtgrid_mathang.Columns["column_ThanhTien"].DefaultCellStyle.BackColor = Color.LightGray;

            TLGiaLe = Double.Parse(obj_TS_DAO.layTiLeGiaLe());
            TLGiaSi = Double.Parse(obj_TS_DAO.layTiLeGiaSi());
        }

        private void dtgrid_mathang_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            
            e.Row.Cells["column_SoLuong"].Value = 0;
            e.Row.Cells["column_DonGia"].Value = 0;
            e.Row.Cells["column_ThanhTien"].Value = 0;
        }
        private void dtgrid_mathang_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(columnSoLuong_KeyPress);
            if (dtgrid_mathang.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(columnSoLuong_KeyPress);
                }
            }

            e.Control.KeyPress -= new KeyPressEventHandler(columnDonGia_KeyPress);
            if (dtgrid_mathang.CurrentCell.ColumnIndex == 2) //Desired Column
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

        private void dtgrid_mathang_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            int sl = Int32.Parse(dtgrid_mathang.CurrentRow.Cells["column_SoLuong"].Value.ToString());
            double dongia = Double.Parse(dtgrid_mathang.CurrentRow.Cells["column_DonGia"].Value.ToString());

            dtgrid_mathang.CurrentRow.Cells["column_ThanhTien"].Value = (sl * dongia * TLGiaLe) + (sl * dongia);
        }

        private void tbx_khachhang_TextChanged(object sender, EventArgs e)
        {
            this.btn_ThanhToan.Enabled = !string.IsNullOrWhiteSpace(this.tbx_khachhang.Text);
        }

        private void check_box_TimKiem_CheckedChanged(object sender, EventArgs e)
        {
            Form fTimkiem = new frm_TimKiemHDBL();
            fTimkiem.ShowDialog();
        }
    }
}
