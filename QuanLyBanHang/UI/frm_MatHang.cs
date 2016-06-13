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
    public partial class frm_MatHang : MetroForm
    {


        public frm_MatHang()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            MatHang obj_MatHang = new MatHang();
            MatHang_DAO obj_MH_DAO = new MatHang_DAO();
            obj_MatHang.TenMatHang = tbx_tenmathang.Text;
            //obj_MatHang.SoLuongTon = Convert.ToInt32(tbx_soluongton.Text);

            
            if (tbx_tenmathang.Text == "" || cbx_dvt.SelectedIndex == -1)
            {
                MessageBox.Show("Các trường không được để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_MatHang.MaDVT = obj_MH_DAO.Get_MaDVT(get_DVT());
                try
                {
                    if (obj_MH_DAO.Lay_Ten_Mat_Hang(tbx_tenmathang.Text) == null)
                    {
                        obj_MH_DAO.Run_Procedure_Ins_MatHang(tbx_tenmathang.Text, 0, obj_MatHang.MaDVT);
                        MessageBox.Show("Thêm mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgrid_mathang.DataSource = obj_MH_DAO.Lay_Tat_Ca_Mat_Hang();
                    }
                    else
                    {
                        MessageBox.Show("Mặt hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                tbx_tenmathang.Text = "";
                cbx_dvt.SelectedIndex = -1;

            }

        }
        public String get_DVT()
        {
            return cbx_dvt.GetItemText(cbx_dvt.SelectedItem);
        }

        public String get_TenMatHang()
        {
            return tbx_tenmathang.Text;
        }

        private void Them_MatHang_Load(object sender, EventArgs e)
        {
            MatHang_DAO obj_MatHang_DAO = new MatHang_DAO();
            cbx_dvt.DataSource = obj_MatHang_DAO.Lay_Tatca_DVT();
            cbx_dvt.DisplayMember = "TenDVT";
            cbx_dvt.ValueMember = "TenDVT";
            cbx_dvt.SelectedIndex = -1;
            //Du lieu cho bang datagridview
            dtgrid_mathang.DataSource = obj_MatHang_DAO.Lay_Tat_Ca_Mat_Hang();
            //button tim kiem
            btn_TimKiem.Enabled = false;
            dtgrid_mathang.ReadOnly = true;
        }

        private void dtgrid_mathang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_tenmathang.Text = dtgrid_mathang.CurrentRow.Cells[1].Value.ToString();
            cbx_dvt.SelectedValue = dtgrid_mathang.CurrentRow.Cells[3].Value;
        }

        private void check_box_TimKiem_CheckedChanged(object sender, EventArgs e)
        {
            MatHang_DAO obj_MatHang_DAO = new MatHang_DAO();
            if (check_box_TimKiem.Checked)
            {

                btn_TimKiem.Enabled = true;
                cbx_dvt.Enabled = false;
                btn_them.Enabled = false;
                dtgrid_mathang.ReadOnly = true;

            }
            else
            {
                tbx_tenmathang.ResetText();
                btn_TimKiem.Enabled = false;
                dtgrid_mathang.DataSource = obj_MatHang_DAO.Lay_Tat_Ca_Mat_Hang();
                cbx_dvt.Enabled = true;
                btn_them.Enabled = true;
                dtgrid_mathang.Enabled = true;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            MatHang_DAO obj_MatHang_DAO = new MatHang_DAO();
            dtgrid_mathang.DataSource = obj_MatHang_DAO.Lay_Mat_Hang_Tim_Kiem(tbx_tenmathang.Text);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            MatHang_DAO obj_MatHang_DAO = new MatHang_DAO();
            DialogResult dio_result = MessageBox.Show("Bạn có chắc muốn xóa mặt hàng đã chọn?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dio_result == DialogResult.Cancel)
            {
                return;
            }
            if (dio_result == DialogResult.OK) ;
            {
                obj_MatHang_DAO.Xoa_MatHang(tbx_tenmathang.Text);
                dtgrid_mathang.DataSource = obj_MatHang_DAO.Lay_Tat_Ca_Mat_Hang();
                return;
            }

        }




    }
}
