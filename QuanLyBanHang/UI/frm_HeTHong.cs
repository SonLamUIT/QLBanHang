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
namespace UI
{
    public partial class frm_HeTHong : MetroFramework.Forms.MetroForm
    {
        DataProvider dp;
        public frm_HeTHong()
        {
            InitializeComponent();
            dp = new DataProvider();
        }
        private void frm_HeTHong_Load(object sender, EventArgs e)
        {               
            dgvHeThong.DataSource = dp.layTatCaDuLieu("select * from LichSuDuLieu");
            dgvHeThong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void btLamMoi_Click(object sender, EventArgs e)
        {
            dgvHeThong.DataSource = dp.layTatCaDuLieu("select * from LichSuDuLieu");
        }
        private void btSaoLuu_Click(object sender, EventArgs e)
        {
            frmSaoLuu sl = new frmSaoLuu();
            sl.ShowDialog();
        }
        private void btPhucHoi_Click(object sender, EventArgs e)
        {
            frmPhucHoiDuLieu ph = new frmPhucHoiDuLieu();
            ph.ShowDialog();
        }
    }
}
