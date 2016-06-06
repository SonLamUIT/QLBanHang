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
namespace UI.UIPhieuThuChi
{
    public partial class UILapPhieuThuChi : MetroFramework.Forms.MetroForm
    {        
        DAOThuChi daotc;
        PhieuThuChi dtoptc;
        public UILapPhieuThuChi()
        {
            InitializeComponent();
            daotc = new DAOThuChi();
            dtoptc = new PhieuThuChi();
        }

        private void btLapPhieu_Click(object sender, EventArgs e)
        {
            if (    //(rbPhieuChi.Checked || rbPhieuThu.Checked) ||
                tbSoPhieu.Text.ToString() == "" || 
                cbMaDoiTac.Text == "" ||                 
                datNgayLap.Text.ToString() == "" || 
                tbSoTien.Text.ToString() == ""||                
                Convert.ToInt64(tbSoTien.Text.ToString())<0
                )
                MessageBox.Show("Nhập thông tin sai!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                if(daotc.KiemTraSoPhieuThuChiDaTonTai(tbSoPhieu.Text.ToString()))
                    MessageBox.Show("Mã phiếu đã tồn tại!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (rbPhieuChi.Checked)
                    dtoptc.LaPhieuThuHayChi = "C";
                else
                    if (rbPhieuThu.Checked)
                    dtoptc.LaPhieuThuHayChi = "T";
                dtoptc.SoPTC = tbSoPhieu.Text.ToString();
                dtoptc.NgayLap = datNgayLap.Value.ToString("dd/MM/yyyy hh:mm:ss");
                dtoptc.MaDoiTac = cbMaDoiTac.Text;
                dtoptc.SoTien=Convert.ToInt64(tbSoTien.Text.ToString());
                dtoptc.TongNo = 0;
                if (daotc.LapPhieuThuChi(dtoptc))
                {
                    MessageBox.Show("Đã thêm phiếu thu chi " + dtoptc.SoPTC + " thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Đã thêm phiếu thu chi " + dtoptc.SoPTC + " không thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }               
        }
        private void rbPhieuThu_CheckedChanged(object sender, EventArgs e)
        {                   
        }
        private void rbPhieuChi_CheckedChanged(object sender, EventArgs e)
        {          
        }
        private void UILapPhieuThuChi_Load(object sender, EventArgs e)
        {
            cbMaDoiTac.DataSource = daotc.LayDanhSachDoiTac();
            cbMaDoiTac.ValueMember = "MaDoiTac";
            cbMaDoiTac.DisplayMember = "MaDoiTac";
        }

        private void btDanhSachDoiTac_Click(object sender, EventArgs e)
        {
            UIDanhSachDoiTac uidsdt = new UIDanhSachDoiTac();
            uidsdt.ShowDialog();
        }
    }
}
