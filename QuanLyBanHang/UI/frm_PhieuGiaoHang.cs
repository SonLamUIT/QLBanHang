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
    public partial class frm_PhieuGiaoHang : MetroForm
    {
        PhieuGiaoHang_DAO obj_PGH_DAO = new PhieuGiaoHang_DAO();
        CT_PhieuGiaoHang_DAO obj_CTPGH_DAO = new CT_PhieuGiaoHang_DAO();
        DoiTac_DAO obj_DoiTac_DAO = new DoiTac_DAO();
        ThamSo_DAO obj_TS_DAO = new ThamSo_DAO();
        Double TLGiaSi;
        Double TLGiaLe;
        
        string tenkh, soddh;
        public frm_PhieuGiaoHang()
        {
            InitializeComponent();
            dtgrid_CTphieugiaohang.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dtgrid_CTphieugiaohang_EditingControlShowing);

            //dtgrid_CTphieugiaohang.DefaultValuesNeeded += new DataGridViewRowEventHandler(dtgrid_CTphieugiaohang_DefaultValuesNeeded);
        }

        private void frm_PhieuGiaoHang_Load(object sender, EventArgs e)
        {

            cbx_tenkhachhang.ValueMember = "TenDoiTac";
            cbx_tenkhachhang.DisplayMember = "TenDoiTac";


            cbx_tenkhachhang.DataSource = obj_PGH_DAO.layTatCaKHDaDatHang();
            //cbx_tenkhachhang.SelectedIndex = 1;

            for (int row = 0; row < dtgrid_CTphieugiaohang.RowCount; row++)
            {
                dtgrid_CTphieugiaohang.Rows[row].Cells["column_SoLuongDaGiao"].Value = 0;
                dtgrid_CTphieugiaohang.Rows[row].Cells["column_SoLuongChuaGiao"].Value = 0;
                dtgrid_CTphieugiaohang.Rows[row].Cells["column_DonGia"].Value = 0;
                dtgrid_CTphieugiaohang.Rows[row].Cells["column_ThanhTien"].Value = 0;
            }
            //Mau cua column So luong da giao va Thanh tien
            dtgrid_CTphieugiaohang.Columns["column_SoLuongChuaGiao"].DefaultCellStyle.BackColor = Color.LightGray;
            dtgrid_CTphieugiaohang.Columns["column_ThanhTien"].DefaultCellStyle.BackColor = Color.LightGray;
            //Ko cho phep chinh sua cot ten mat hang va ma mat hang
            dtgrid_CTphieugiaohang.Columns["Mặt hàng"].ReadOnly = true;
            dtgrid_CTphieugiaohang.Columns["Mã mặt hàng"].ReadOnly = true;
            dtgrid_CTphieugiaohang.Columns["Số lượng đặt"].ReadOnly = true;

            tbx_TongTien.Text = 0.ToString();
            tbx_ThanhToan.Text = 0.ToString();
            tbx_ConLai.Text = 0.ToString();

            //Ti le gia si va ti le gia le
            TLGiaLe = Double.Parse(obj_TS_DAO.layTiLeGiaLe());
            TLGiaSi = Double.Parse(obj_TS_DAO.layTiLeGiaSi());

        }

        private void cbx_tenkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbx_tenkhachhang.SelectedIndex = 1;
            string maDT = obj_PGH_DAO.layMaDoiTacTheoTenDoiTac(cbx_tenkhachhang.GetItemText(cbx_tenkhachhang.SelectedItem));


            cbx_sodondathang.DisplayMember = "SoDDH_KH";
            cbx_sodondathang.DataSource = obj_PGH_DAO.layTatCaSoDDHKH(maDT);

            cbx_sodondathang.ValueMember = "SoDDH_KH";
            //cbx_sodondathang.SelectedIndex = 0; 
        }

        private void btn_kiemtradondathang_Click(object sender, EventArgs e)
        {
            tenkh = cbx_tenkhachhang.GetItemText(cbx_tenkhachhang.SelectedItem);
            soddh = cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem);
            frm_KiemTraSoDDH_KH fkiemtraSoDDH = new frm_KiemTraSoDDH_KH(tenkh, soddh);

            fkiemtraSoDDH.Show();
        }

        private void btn_GiaoHang_Click(object sender, EventArgs e)
        {
            //tbx_ThanhToan.Text = 0.ToString();
            double tongtien = 0;
            string sddhkh = cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem);
            DateTime ngaygiao = dateTime_NgayGiao.Value;

            if (Double.Parse(tbx_TongTien.Text) >= Double.Parse(tbx_ThanhToan.Text))
            {
                if (obj_PGH_DAO.themPhieuGiaoHang(sddhkh, ngaygiao, 0, 0, 0))
                {
                    for (int row = 0; row < dtgrid_CTphieugiaohang.RowCount; row++)
                    {
                        string sopgh = obj_PGH_DAO.laySoPGHCuoi();
                        string maMH = dtgrid_CTphieugiaohang.Rows[row].Cells["Mã mặt hàng"].Value.ToString();
                        int sldagiao = Int32.Parse(dtgrid_CTphieugiaohang.Rows[row].Cells["column_SoLuongDaGiao"].Value.ToString());
                        obj_PGH_DAO.capNhatCTDDHKH_SoLuongDaGiao(sldagiao, sddhkh, maMH);


                        //if (Int32.Parse(obj_PGH_DAO.layTongSoLuongDat(maMH)) == Int32.Parse(obj_PGH_DAO.layTongSoLuongDaGiao(maMH, cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem))))
                        //{
                        //    dtgrid_CTphieugiaohang.Enabled = false;
                        //    MessageBox.Show("Mặt hàng này đã giao đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    break;
                        //}


                        //int slchuagiao = (Int32.Parse(dtgrid_CTphieugiaohang.Rows[row].Cells["Số lượng đặt"].Value.ToString())) - sldagiao;
                        string total_slGiao = obj_PGH_DAO.layTongSoLuongDaGiao(cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem), dtgrid_CTphieugiaohang.CurrentRow.Cells["Mã mặt hàng"].Value.ToString());
                        if (total_slGiao == "")
                        {
                            total_slGiao = 0.ToString();
                        }

                        int slchuagiao = (Int32.Parse(dtgrid_CTphieugiaohang.Rows[row].Cells["Số lượng đặt"].Value.ToString())) - Int32.Parse(total_slGiao);

                        double dongia = Double.Parse(dtgrid_CTphieugiaohang.Rows[row].Cells["column_DonGia"].Value.ToString());
                        double thanhtien = (dongia * sldagiao) + (dongia * sldagiao * TLGiaSi);
                        obj_CTPGH_DAO.themCT_PhieuGiaoHang(sopgh, maMH, slchuagiao, sldagiao, dongia, thanhtien);

                        tongtien += thanhtien;
                    }
                    //// Cai dat su kien thay doi gia tri cua textbox khi finish chinh sua datagridview
                    //tbx_TongTien.Text = tongtien.ToString();
                    obj_PGH_DAO.capNhatTongTien(Double.Parse(tbx_TongTien.Text), cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem));

                    Double tt = Double.Parse(tbx_ThanhToan.Text);
                    obj_PGH_DAO.capNhatThanhToan(tt, cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem));

                    //double conlai = Double.Parse(tbx_TongTien.Text) - Double.Parse(tbx_ThanhToan.Text);
                    double conlai = tongtien - Double.Parse(tbx_ThanhToan.Text);
                    obj_PGH_DAO.capNhatConLai(conlai, cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem));

                    //Khi giao thang xong. Cap nhat so tien no cua DOITAC la khach hang.
                    obj_DoiTac_DAO.capNhatSoTienNo(Double.Parse(obj_PGH_DAO.layTongConLai(cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem))), cbx_tenkhachhang.GetItemText(cbx_tenkhachhang.SelectedItem));
                }
            }

            else
            {
                MessageBox.Show("Số tiền thanh toán không được vượt quá Tổng Tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MessageBox.Show("Thanh toán thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //MessageBox.Show("Them thanh cong");
        }

        private void cbx_sodondathang_SelectedIndexChanged(object sender, EventArgs e)
        {

            dtgrid_CTphieugiaohang.DataSource = obj_PGH_DAO.layCTPhieuGiaoHang(cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem));
            AdjustColumnOrder();
            setColumnDefaultValue();
            //for (int row = 0; row < dtgrid_CTphieugiaohang.RowCount; row++)
            //{
            //    string maMH = dtgrid_CTphieugiaohang.Rows[row].Cells["Mã mặt hàng"].Value.ToString();
            //    if (Int32.Parse(obj_PGH_DAO.layTongSoLuongDat(maMH)) == Int32.Parse(obj_PGH_DAO.layTongSoLuongDaGiao(maMH, cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem))))
            //    {
            //        dtgrid_CTphieugiaohang.Enabled = false;
            //        MessageBox.Show("Mặt hàng này đã giao đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        break;
            //    }
            //}

        }
        //Sap xep thu tu cot trong datagridview
        private void AdjustColumnOrder()
        {
            dtgrid_CTphieugiaohang.Columns["Mã mặt hàng"].DisplayIndex = 0;
            dtgrid_CTphieugiaohang.Columns["Mặt hàng"].DisplayIndex = 1;
            dtgrid_CTphieugiaohang.Columns["Số lượng đặt"].DisplayIndex = 2;

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgrid_CTphieugiaohang_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

            //e.Row.Cells["column_SoLuongDaGiao"].Value = 0;
            //e.Row.Cells["column_SoLuongChuaGiao"].Value = 0;
            //e.Row.Cells["column_ThanhTien"].Value = 0;
            //e.Row.Cells["column_DonGia"].Value = 0;
        }
        //Tu dong thay doi gia tri cua cot thanh tien theo don gia va so luong da giao
        private void dtgrid_CTphieugiaohang_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int sldagiao = Int32.Parse(dtgrid_CTphieugiaohang.CurrentRow.Cells["column_SoLuongDaGiao"].Value.ToString());
                double dongia = Double.Parse(dtgrid_CTphieugiaohang.CurrentRow.Cells["column_DonGia"].Value.ToString());
                int sldat = Int32.Parse(dtgrid_CTphieugiaohang.CurrentRow.Cells["Số lượng đặt"].Value.ToString());
                if (obj_PGH_DAO.laySoLuongDaGiao(cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem), dtgrid_CTphieugiaohang.CurrentRow.Cells["Mã mặt hàng"].Value.ToString()) == "")
                {
                    MessageBox.Show("Chưa có mặt hàng nào được đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    if (sldagiao > (sldat - Int32.Parse(obj_PGH_DAO.laySoLuongDaGiao(cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem), dtgrid_CTphieugiaohang.CurrentRow.Cells["Mã mặt hàng"].Value.ToString()))))
                    {
                        MessageBox.Show("Chỉ còn " + (sldat - Int32.Parse(obj_PGH_DAO.laySoLuongDaGiao(cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem), dtgrid_CTphieugiaohang.CurrentRow.Cells["Mã mặt hàng"].Value.ToString()))) + " mặt hàng bạn chưa giao. Nhập lại số lượng giao!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                if (sldagiao > sldat)
                {
                    MessageBox.Show("Số lượng giao phải nhỏ hơn số lượng đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dtgrid_CTphieugiaohang.CurrentRow.Cells["column_SoLuongChuaGiao"].Value = sldat - sldagiao;
                //int slchuagiao = (Int32.Parse(dtgrid_CTphieugiaohang.CurrentRow.Cells["Số lượng đặt"].Value.ToString())) - Int32.Parse(obj_PGH_DAO.laySoLuongDaGiao(cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem), dtgrid_CTphieugiaohang.CurrentRow.Cells["Mã mặt hàng"].Value.ToString()));

                dtgrid_CTphieugiaohang.CurrentRow.Cells["column_ThanhTien"].Value = (sldagiao * dongia) + (dongia * sldagiao * TLGiaSi);
            }
            catch
            {
                MessageBox.Show("Hãy nhập thông tin cho các mặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Khong cho phep nhap so vao column So luong da giao va don gia
        private void dtgrid_CTphieugiaohang_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(columnSoLuongDaGiao_KeyPress);
            if (dtgrid_CTphieugiaohang.CurrentCell.ColumnIndex == 0) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(columnSoLuongDaGiao_KeyPress);
                }
            }

            e.Control.KeyPress -= new KeyPressEventHandler(columnDonGia_KeyPress);
            if (dtgrid_CTphieugiaohang.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(columnDonGia_KeyPress);
                }
            }
        }

        private void columnSoLuongDaGiao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void columnDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //Set gia tri mac dinh cho cac cot cua datagridview
        private void setColumnDefaultValue()
        {
            for (int row = 0; row < dtgrid_CTphieugiaohang.RowCount; row++)
            {
                dtgrid_CTphieugiaohang.Rows[row].Cells["column_SoLuongDaGiao"].Value = 0;
                dtgrid_CTphieugiaohang.Rows[row].Cells["column_SoLuongChuaGiao"].Value = 0;
                dtgrid_CTphieugiaohang.Rows[row].Cells["column_DonGia"].Value = 0;
                dtgrid_CTphieugiaohang.Rows[row].Cells["column_ThanhTien"].Value = 0;
            }
        }
        //Textbox Tong tien tu thay doi gia tri theo Thanh Tien cua datagridview
        private void dtgrid_CTphieugiaohang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Double total = 0;
            //Double total = Double.Parse(tbx_TongTien.Text);
            for (int row = 0; row < dtgrid_CTphieugiaohang.RowCount; row++)
            {
                int sldagiao = Int32.Parse(dtgrid_CTphieugiaohang.Rows[row].Cells["column_SoLuongDaGiao"].Value.ToString());
                double dongia = Double.Parse(dtgrid_CTphieugiaohang.Rows[row].Cells["column_DonGia"].Value.ToString());
                double thanhtien = (dongia * sldagiao) + (dongia * sldagiao * TLGiaSi);
                total += thanhtien;
            }
            tbx_TongTien.Text = total.ToString();
        }
        //Textbox Con lai = Tong Tien - Thanh Toan
        private void tbx_ThanhToan_TextChanged(object sender, EventArgs e)
        {

            if (tbx_ThanhToan.Text == "")
            {
                tbx_ThanhToan.Text = 0.ToString();
                tbx_ConLai.Text = (Double.Parse(tbx_TongTien.Text) - Double.Parse(tbx_ThanhToan.Text)).ToString();
            }
            else
                tbx_ConLai.Text = (Double.Parse(tbx_TongTien.Text) - Double.Parse(tbx_ThanhToan.Text)).ToString();
        }

    }
}
