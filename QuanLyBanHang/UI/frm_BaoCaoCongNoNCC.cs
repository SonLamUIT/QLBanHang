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
    public partial class frm_BaoCaoCongNoNCC : MetroForm
    {
        //CHUA DEBUG

        DonDatHang_DAO obj_DDHNCC_DAO = new DonDatHang_DAO();
        BaoCaoCongNoNCC_DAO obj_BCCN_NCC_DAO = new BaoCaoCongNoNCC_DAO();
        CT_BaoCaoCongNoNCC_DAO obj_CTBCNN_NCC_DAO = new CT_BaoCaoCongNoNCC_DAO();
        string maDT;
        public frm_BaoCaoCongNoNCC()
        {
            InitializeComponent();
        }

        private void frm_BaoCaoCongNoNCC_Load(object sender, EventArgs e)
        {
            
            cbx_DoiTac.ValueMember = "TenDoiTac";
            cbx_DoiTac.DisplayMember = "TenDoiTac";
            cbx_DoiTac.DataSource = obj_DDHNCC_DAO.layTatcaNCC();
            
        }

        private void cbx_DoiTac_SelectedIndexChanged(object sender, EventArgs e)
        {
            maDT = obj_DDHNCC_DAO.layMaDoiTacTheoTenDoiTac(cbx_DoiTac.GetItemText(cbx_DoiTac.SelectedItem));
            cbx_sodondathang.DisplayMember = "SoDDH_NCC";
            cbx_sodondathang.DataSource = obj_DDHNCC_DAO.layTatCaSoDDH_NCCTheoNCC(cbx_DoiTac.GetItemText(cbx_DoiTac.SelectedItem));
            cbx_sodondathang.ValueMember = "SoDDH_NCC";
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
            if ((tongCL = obj_BCCN_NCC_DAO.layTongConLaiTheoSoDDH(cbx_sodondathang.GetItemText(cbx_sodondathang.SelectedItem), Int32.Parse(tbx_Thang.Text), Int32.Parse(tbx_Nam.Text))) == "")
            {
                tongCL = "0";
                MessageBox.Show("Khách hàng " + cbx_DoiTac.GetItemText(cbx_DoiTac.SelectedItem) + " chưa nhập hàng! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //if(tongCL != "")
            obj_BCCN_NCC_DAO.capNhatSoTienNo(Double.Parse(tongCL), maDT);
            //No dau ki = Tong Con Lai cua thang truoc do
            //Phat sinh la Tong gia tri mua hang hoac tong no phat sinh trong thang
            //No cuoi ki = No dau ki + Phat sinh


            string maBCCNcuoi = obj_CTBCNN_NCC_DAO.layMaBCCNLast();
            obj_BCCN_NCC_DAO.capNhatBaoCaoCongNo(thang, nam, maBCCNcuoi);

            double noDauKi;
            double phatSinh;

            if (obj_CTBCNN_NCC_DAO.tinhTongConLaiTheoThangNamMaDT(maDT, thang - 1, nam) == "")
            {
                noDauKi = 0;
            }
            else
            {

                noDauKi = Double.Parse(obj_CTBCNN_NCC_DAO.tinhTongConLaiTheoThangNamMaDT(maDT, thang - 1, nam));
            }

            if (obj_CTBCNN_NCC_DAO.tinhTongTongTienTheoThangNamMaDT(maDT, thang, nam) == "")
            {
                phatSinh = 0;
            }
            else
            {
                phatSinh = Double.Parse(obj_CTBCNN_NCC_DAO.tinhTongTongTienTheoThangNamMaDT(maDT, thang, nam));
            }

            if (obj_CTBCNN_NCC_DAO.capNhatCT_BCCNTheoMaDT(noDauKi, phatSinh, maDT))
            {
                MessageBox.Show("Thống kê đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Thống kê đã cập nhật thất bại! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string maBCCN = obj_BCCN_NCC_DAO.layMaBCCNTheoMaDoiTac(maDT);
            obj_BCCN_NCC_DAO.capNhatBaoCaoCongNo(thang, nam, maBCCN);

            dtgrid_BCCN.DataSource = obj_BCCN_NCC_DAO.baoCaoCongNo(maDT);
        }
    }
}
