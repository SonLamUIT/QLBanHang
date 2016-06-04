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
    public partial class UILapPhieuNhapHang : MetroFramework.Forms.MetroForm
    {
        DTO.PhieuNhapHang dtopnh;
        DBConnection db;
        DAOPhieuNhapHang daopnh;
        public UILapPhieuNhapHang()
        {
            db = new DBConnection();
            daopnh = new DAOPhieuNhapHang();
            dtopnh = new DTO.PhieuNhapHang();
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            
            if (tbSoPhieuNhapHang.Text.ToString() == "" ||
                cbSoDonDatHangNCC.SelectedItem.ToString() == "" ||
                datNgayNhap.Text.ToString() == "" ||
                tbTongTien.Text.ToString() == "" ||
                tbThanhToan.Text.ToString() == "" ||               
                Convert.ToUInt64(tbTongTien.Text.ToString()) < 0 ||
                Convert.ToUInt64(tbThanhToan.Text.ToString()) < 0 ||
                ((Convert.ToUInt64(tbTongTien.Text.ToString()) - Convert.ToUInt64(tbThanhToan.Text.ToString()))<0)  
                //|| Main.IsNumeric(tbThanhToan.Text.ToString()) ||
                //Main.IsNumeric(tbTongTien.Text.ToString())
                )
                MessageBox.Show("Nhập lại thông tin chính xác!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (daopnh.KiemTraSoPhieuNhapHangDaTonTai("exec KiemTraSoPhieuNhapHangTrongPhieuNhapHang '0'",tbSoPhieuNhapHang.Text.ToString()))
                    MessageBox.Show("Mã phiếu nhập hàng đã tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
            {
                dtopnh.SoPNH = tbSoPhieuNhapHang.Text.ToString();
                dtopnh.SoDDH_NCC = cbSoDonDatHangNCC.Text;
                dtopnh.TongTien = Convert.ToUInt64(tbTongTien.Text.ToString());
                dtopnh.ThanhToan = Convert.ToUInt64(tbThanhToan.Text.ToString());
                dtopnh.ConLai = dtopnh.TongTien - dtopnh.ThanhToan;
                dtopnh.NgayNhap = datNgayNhap.Value.ToString("dd/MM/yyyy hh:mm:ss");
                if (daopnh.LuuPhieuNhapHang(dtopnh))
                {
                    MessageBox.Show("Đã lập phiếu nhập hàng thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Đã lập phiếu nhập hàng không thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                



                /*
                string SoPhieuNhapHang = tbSoPhieuNhapHang.Text.ToString();
                string SoDonDatHangNCC = tbSoDonDatHangNCC.Text.ToString();
                string NgayNhap = datNgayNhap.Text.ToString();
                ulong TongTien = Convert.ToUInt64(tbTongTien.Text.ToString());
                ulong ThanhToan = Convert.ToUInt64(tbThanhToan.Text.ToString());
                ulong ConLai = Convert.ToUInt64(tbConLai.Text.ToString()); 
                */
        }

        private void UILapPhieuNhapHang_Load(object sender, EventArgs e)
        {
            cbSoDonDatHangNCC.DataSource = daopnh.LayDanhSachDonDatHangNCC();
            cbSoDonDatHangNCC.DisplayMember = "SoDDH_NCC";
            cbSoDonDatHangNCC.ValueMember = "SoDDH_NCC";
            cbSoDonDatHangNCC.SelectedIndex = -1;
        }

        private void tbTongTien_TextChanged(object sender, EventArgs e)
        {
            if (tbTongTien.Text.ToString() != "" && tbThanhToan.Text.ToString() != "" && Main.IsNumeric(tbThanhToan.Text.ToString()) && Main.IsNumeric(tbTongTien.Text.ToString())&& (Convert.ToUInt64(tbTongTien.Text) - Convert.ToUInt64(tbThanhToan.Text)) >= 0)
                tbConLai.Text = Convert.ToString(Convert.ToUInt64(tbTongTien.Text) - Convert.ToUInt64(tbThanhToan.Text));
        }

        private void tbThanhToan_TextChanged(object sender, EventArgs e)
        {
            if (tbTongTien.Text.ToString() != "" && tbThanhToan.Text.ToString() != "" && Main.IsNumeric(tbThanhToan.Text.ToString()) && Main.IsNumeric(tbTongTien.Text.ToString())&& (Convert.ToUInt64(tbTongTien.Text) - Convert.ToUInt64(tbThanhToan.Text)) >= 0)
                tbConLai.Text = Convert.ToString(Convert.ToUInt64(tbTongTien.Text) - Convert.ToUInt64(tbThanhToan.Text));
        }
    }
}


