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
    public partial class frm_BaoCaoCongNoKH : MetroForm
    {
        PhieuGiaoHang_DAO obj_PGH_DAO = new PhieuGiaoHang_DAO();
        BaoCaoCongNoKH_DAO obj_BCCN_DAO = new BaoCaoCongNoKH_DAO();
        CT_BaoCaoCongNo_DAO obj_CTBCCN_DAO = new CT_BaoCaoCongNo_DAO();
        string maDT;
        public frm_BaoCaoCongNoKH()
        {
            InitializeComponent();
        }

        private void frm_BaoCaoCongNo_Load(object sender, EventArgs e)
        {
            cbx_tenkhachhang.ValueMember = "TenDoiTac";
            cbx_tenkhachhang.DisplayMember = "TenDoiTac";
            cbx_tenkhachhang.DataSource = obj_PGH_DAO.layTatCaKHDaDatHang();

            
        }

        private void cbx_tenkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            maDT = obj_PGH_DAO.layMaDoiTacTheoTenDoiTac(cbx_tenkhachhang.GetItemText(cbx_tenkhachhang.SelectedItem));
            cbx_sodondathang.DisplayMember = "SoDDH_KH";
            cbx_sodondathang.DataSource = obj_PGH_DAO.layTatCaSoDDHKH(maDT);
            cbx_sodondathang.ValueMember = "SoDDH_KH";
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            if (tbx_Thang.Text == "" || tbx_Nam.Text == "")
            {
                MessageBox.Show("Các trường không được để trống! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int thang = Int32.Parse(tbx_Thang.Text);
            int nam = Int32.Parse(tbx_Nam.Text);
            //if()
            string tongCL;
            if ((tongCL = obj_BCCN_DAO.layTongConLaiTheoSoDDH(cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem), Int32.Parse(tbx_Thang.Text), Int32.Parse(tbx_Nam.Text))) == "")
            {
                tongCL = "0";
                MessageBox.Show("Khách hàng " + cbx_tenkhachhang.GetItemText(cbx_tenkhachhang.SelectedItem) + " chưa được giao hàng! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //if(tongCL != "")
            obj_BCCN_DAO.capNhatSoTienNo(Double.Parse(tongCL), maDT);
            //No dau ki = Tong Con Lai cua thang truoc do
            //Phat sinh la Tong gia tri mua hang hoac tong no phat sinh trong thang
            //No cuoi ki = No dau ki + Phat sinh


            string maBCCNcuoi = obj_CTBCCN_DAO.layMaBCCNLast();
            obj_BCCN_DAO.capNhatBaoCaoCongNo(thang, nam, maBCCNcuoi);

            double noDauKi;
            double phatSinh;

            if (obj_CTBCCN_DAO.tinhTongConLaiTheoThangNamMaDT(maDT, thang - 1, nam) == "")
            {
                noDauKi = 0;
            }
            else
            {
               
                noDauKi = Double.Parse(obj_CTBCCN_DAO.tinhTongConLaiTheoThangNamMaDT(maDT, thang - 1, nam));
            }

            if (obj_CTBCCN_DAO.tinhTongTongTienTheoThangNamMaDT(maDT, thang, nam) == "")
            {
                phatSinh = 0;
            }
            else
            {
                phatSinh = Double.Parse(obj_CTBCCN_DAO.tinhTongTongTienTheoThangNamMaDT(maDT, thang, nam));
            }

            if (obj_CTBCCN_DAO.capNhatCT_BCCNTheoMaDT(noDauKi, phatSinh, maDT))
            {
                MessageBox.Show("Thống kê đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Thống kê đã cập nhật thất bại! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string maBCCN = obj_BCCN_DAO.layMaBCCNTheoMaDoiTac(maDT);
            obj_BCCN_DAO.capNhatBaoCaoCongNo(thang, nam, maBCCN);

            dtgrid_BCCN.DataSource = obj_BCCN_DAO.baoCaoCongNo(maDT);
        }

        private void tbx_Thang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // only allow one decimal point
        }

        private void tbx_Nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbx_Thang_Validated(object sender, EventArgs e)
        {
            if (Int32.Parse(tbx_Thang.Text) > 12 || Int32.Parse(tbx_Thang.Text) < 0)
            {
                MessageBox.Show("Tháng nhập phải lớn hơn 0 và nhỏ hơn 12! Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_Thang.Text = "0";
            }
        }

        private void tbx_Nam_Validated(object sender, EventArgs e)
        {
            if (Int32.Parse(tbx_Nam.Text) < 2000)
            {
                MessageBox.Show("Năm nhập phải lớn hơn 2000!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_Nam.Text = "0";
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
