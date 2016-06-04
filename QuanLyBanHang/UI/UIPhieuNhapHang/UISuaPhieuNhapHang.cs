using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using MetroFramework;
namespace UI.UIPhieuNhapHang
{
    public partial class UISuaPhieuNhapHang : MetroFramework.Forms.MetroForm
    {
        DAOPhieuNhapHang daopnh;
        string SoPhieuNhapHang1;
        public UISuaPhieuNhapHang(PhieuNhapHang pnh)
        {
            InitializeComponent();
            daopnh = new DAOPhieuNhapHang();
            SoPhieuNhapHang1 = pnh.SoPNH;
            tbSoPhieuNhapHang.Text = pnh.SoPNH;
            tbSoDDH_NCC.Text = pnh.SoDDH_NCC;
            datNgayNhap.Value = Convert.ToDateTime(pnh.NgayNhap);
            tbTongTien.Text = pnh.TongTien.ToString();
            tbThanhToan.Text = pnh.ThanhToan.ToString();
            tbConLai.Text = pnh.ConLai.ToString();
        }
        public void layDoiTuongPhieuNhapHangCanSua(PhieuNhapHang pnh)
        {
            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if(daopnh.ThayDoiPhieuNhapHang(SoPhieuNhapHang1,tbSoPhieuNhapHang.Text.ToString(),tbSoDDH_NCC.Text.ToString(),datNgayNhap.Value.ToString(),Convert.ToUInt64(tbTongTien.Text),Convert.ToUInt64(tbThanhToan.Text),Convert.ToUInt64(tbConLai.Text)));
            MessageBox.Show("Đã sửa thành công phiếu nhập hàng " + tbSoPhieuNhapHang.Text.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void tbTongTien_TextChanged(object sender, EventArgs e)
        {
            if (tbTongTien.Text.ToString() != "" && tbThanhToan.Text.ToString() != "" && Main.IsNumeric(tbThanhToan.Text.ToString()) && Main.IsNumeric(tbTongTien.Text.ToString()) && (Convert.ToUInt64(tbTongTien.Text) - Convert.ToUInt64(tbThanhToan.Text))>=0)
                tbConLai.Text = Convert.ToString(Convert.ToUInt64(tbTongTien.Text) - Convert.ToUInt64(tbThanhToan.Text));
        }

        private void tbThanhToan_TextChanged(object sender, EventArgs e)
        {
            if (tbTongTien.Text.ToString() != "" && tbThanhToan.Text.ToString() != "" && Main.IsNumeric(tbThanhToan.Text.ToString()) && Main.IsNumeric(tbTongTien.Text.ToString())&& (Convert.ToUInt64(tbTongTien.Text) - Convert.ToUInt64(tbThanhToan.Text)) >= 0)
                tbConLai.Text = Convert.ToString(Convert.ToUInt64(tbTongTien.Text) - Convert.ToUInt64(tbThanhToan.Text));
        }
    }
}
