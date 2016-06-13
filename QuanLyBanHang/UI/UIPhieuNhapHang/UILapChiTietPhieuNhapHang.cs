using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using DAO;
using DTO;
namespace UI.UIPhieuNhapHang
{
    public partial class UILapChiTietPhieuNhapHang : MetroFramework.Forms.MetroForm
    {
        DAOPhieuNhapHang daopnh;
        CT_PNH ctpnh;
        public UILapChiTietPhieuNhapHang()
        {
            InitializeComponent();
            daopnh = new DAOPhieuNhapHang();
            ctpnh = new CT_PNH();
        }

        private void UILapChiTietPhieuNhapHang_Load(object sender, EventArgs e)
        {
            cbSoPhieuNhapHang.DataSource = daopnh.LayDanhSachSoPhieuNhapHang();
            cbSoPhieuNhapHang.DisplayMember = "SoPNH";
            cbSoPhieuNhapHang.ValueMember = "SoPNH";
            cbMaMatHang.DataSource = daopnh.LayDanhSachMaMatHang();
            cbMaMatHang.DisplayMember = "MaMatHang";
            cbMaMatHang.ValueMember = "MaMatHang";
            cbMaMatHang.SelectedIndex = -1;
            cbSoPhieuNhapHang.SelectedIndex = -1;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (Convert.ToUInt64(tbDonGiaNhap.Text) < 0 ||
                //Convert.ToUInt64(tbSoLuongChuaNhap.Text) < 0 ||
                Convert.ToUInt64(tbSoLuongNhap.Text) < 0 ||
                tbDonGiaNhap.Text.ToString() == "" ||
                //tbSoLuongChuaNhap.Text.ToString() == "" ||
                tbSoLuongNhap.Text.ToString() == "" ||
                cbMaMatHang.Text == "" ||
                cbSoPhieuNhapHang.Text == ""
                )
                MessageBox.Show("Dữ liệu không đúng đắn, mời nhập lại!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                ctpnh.SoPNH = cbSoPhieuNhapHang.Text.ToString();
                ctpnh.MaMatHang = cbMaMatHang.Text.ToString();
                ctpnh.SoLuongChuaNhap = Convert.ToInt32(tbSoLuongChuaNhap.Text.ToString())- Convert.ToInt32(tbSoLuongNhap.Text.ToString());
                ctpnh.SoLuongNhap = Convert.ToInt32(tbSoLuongNhap.Text.ToString());
                ctpnh.DonGiaNhap = Convert.ToUInt64(tbDonGiaNhap.Text.ToString());
                ctpnh.ThanhTien= Convert.ToUInt64(tbSoLuongNhap.Text.ToString()) * Convert.ToUInt64(tbDonGiaNhap.Text.ToString());
             
                if (daopnh.LapChiTietPhieuNhapHang(ctpnh))
                {
                    MessageBox.Show("Đã thêm chi tiết phiếu nhập hàng " + ctpnh.SoPNH, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết phiếu nhập hàng " + ctpnh.SoPNH + " không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                daopnh.CapNhatSoLuongNhap(daopnh.LaySoDDH_NCC(cbSoPhieuNhapHang.Text.ToString()), cbMaMatHang.Text, tbSoLuongNhap.Text.ToString());       
                
            }
        }

        private void btDanhSachMatHang_Click(object sender, EventArgs e)
        {
            UIDanhSachMatHang dsmh = new UIDanhSachMatHang();
            dsmh.ShowDialog();
        }

        private void tbDonGiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (tbSoLuongNhap.Text.ToString() != "" && tbDonGiaNhap.Text.ToString() != "" && Main.IsNumeric(tbSoLuongNhap.Text.ToString()) && Main.IsNumeric(tbDonGiaNhap.Text.ToString()))
                tbThanhTien.Text = Convert.ToString(Convert.ToUInt64(tbSoLuongNhap.Text) * Convert.ToUInt64(tbDonGiaNhap.Text));
        }

        private void tbSoLuongNhap_TextChanged(object sender, EventArgs e)
        {
            if (tbSoLuongNhap.Text.ToString() != "" && tbDonGiaNhap.Text.ToString() != "" && Main.IsNumeric(tbSoLuongNhap.Text.ToString()) && Main.IsNumeric(tbDonGiaNhap.Text.ToString()))
                tbThanhTien.Text = Convert.ToString(Convert.ToUInt64(tbSoLuongNhap.Text) * Convert.ToUInt64(tbDonGiaNhap.Text));

        }

        private void cbSoPhieuNhapHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaMatHang.SelectedIndex != -1)
                tbSoLuongChuaNhap.Text = Convert.ToString(daopnh.LaySoLuongChuaNhap(cbMaMatHang.Text.ToString(), cbSoPhieuNhapHang.Text.ToString()));
        }
        private void cbMaMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSoPhieuNhapHang.SelectedIndex != -1)
                tbSoLuongChuaNhap.Text = Convert.ToString(daopnh.LaySoLuongChuaNhap(cbMaMatHang.Text.ToString(), cbSoPhieuNhapHang.Text.ToString()));
        }
    }
}
