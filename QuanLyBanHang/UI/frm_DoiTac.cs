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
    public partial class frm_DoiTac : MetroForm
    {
        DoiTac_DAO obj_DoiTac_DAO = new DoiTac_DAO();
//      Bien luu MaDoiTac khi click vao cell click
        String ma_Doi_Tac_CellClick;
        public void set_ma_DoiTac_CellClick(string m)
        {
            ma_Doi_Tac_CellClick = m;
        }
        public String get_ma_DoiTac_CellClick()
        {
            return ma_Doi_Tac_CellClick;
        }
        public frm_DoiTac()
        {
            InitializeComponent();
        }

        private void frm_DoiTac_Load(object sender, EventArgs e)
        {
            cbx_LoaiDoiTac.DataSource = obj_DoiTac_DAO.Lay_Tatca_TenDoiTac();
            cbx_LoaiDoiTac.DisplayMember = "TenLoai";
            cbx_LoaiDoiTac.ValueMember = "TenLoai";
            cbx_LoaiDoiTac.SelectedIndex = -1;
            dtgrid_doitac.DataSource = obj_DoiTac_DAO.Lay_Tat_Ca_DoiTac();
            //button Tim kiem disable
            btn_TimKiem.Enabled = false;

            dtgrid_doitac.ReadOnly = true;

            //Automatically resize form size
            //float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1280;
            //float heightRatio = Screen.PrimaryScreen.Bounds.Height / 800f;
            //SizeF scale = new SizeF(widthRatio, heightRatio);
            //this.Scale(scale);
            //foreach (Control control in this.Controls)
            //{
            //    control.Font = new Font("Times New Roman", control.Font.SizeInPoints * heightRatio * widthRatio);
            //}
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DoiTac obj_DoiTac = new DoiTac();
            obj_DoiTac.TenDoiTac = tbx_TenDoiTac.Text;
            obj_DoiTac.SDT = tbx_Sdt.Text;
            obj_DoiTac.DiaChi = tbx_DiaChi.Text;
            if (get_TenLoaiDoiTac() == "")
            {
                MessageBox.Show("Loại đối tác không được để trống!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            obj_DoiTac.MaLoaiDoiTac = obj_DoiTac_DAO.Get_MaLoaiDoiTac(get_TenLoaiDoiTac());
            if ((tbx_TenDoiTac.Text != "") && (tbx_Sdt.Text != "") && (tbx_DiaChi.Text != ""))
            {
                try
                {
                    obj_DoiTac_DAO.Run_Procedure_Ins_DoiTac(tbx_TenDoiTac.Text, obj_DoiTac.MaLoaiDoiTac, tbx_Sdt.Text, tbx_DiaChi.Text, 0);
                    MessageBox.Show("Thêm đối tác thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgrid_doitac.DataSource = obj_DoiTac_DAO.Lay_Tat_Ca_DoiTac();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Các trường không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }
        public String get_TenLoaiDoiTac()
        {
            return cbx_LoaiDoiTac.GetItemText(cbx_LoaiDoiTac.SelectedItem);
        }

        private void check_box_TimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (check_box_TimKiem.Checked)
            {

                btn_TimKiem.Enabled = true;
                btn_them.Enabled = false;
                dtgrid_doitac.ReadOnly = true;

            }
            else
            {
                tbx_TenDoiTac.ResetText();
                tbx_Sdt.ResetText();
                tbx_DiaChi.ResetText();
                dtgrid_doitac.DataSource = obj_DoiTac_DAO.Lay_Tat_Ca_DoiTac();
                
                btn_them.Enabled = true;
                dtgrid_doitac.Enabled = true;
                btn_TimKiem.Enabled = false;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dtgrid_doitac.DataSource = obj_DoiTac_DAO.Lay_Doi_Tac_Tim_Kiem(tbx_TenDoiTac.Text, cbx_LoaiDoiTac.Text, tbx_Sdt.Text, tbx_DiaChi.Text);
        }

        private void dtgrid_doitac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_TenDoiTac.Text = dtgrid_doitac.CurrentRow.Cells[1].Value.ToString();
            cbx_LoaiDoiTac.SelectedValue = dtgrid_doitac.CurrentRow.Cells[6].Value;
            tbx_DiaChi.Text = dtgrid_doitac.CurrentRow.Cells[4].Value.ToString();
            tbx_Sdt.Text = dtgrid_doitac.CurrentRow.Cells[3].Value.ToString();
            set_ma_DoiTac_CellClick(dtgrid_doitac.CurrentRow.Cells[0].Value.ToString());
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (tbx_TenDoiTac.Text != "" && cbx_LoaiDoiTac.GetItemText(cbx_LoaiDoiTac.SelectedItem) != "" && tbx_Sdt.Text != "" && tbx_DiaChi.Text != "")
            {
                obj_DoiTac_DAO.Update_DoiTac(tbx_TenDoiTac.Text, obj_DoiTac_DAO.Get_MaLoaiDoiTac(get_TenLoaiDoiTac()), tbx_Sdt.Text, tbx_DiaChi.Text, get_ma_DoiTac_CellClick());
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgrid_doitac.DataSource = obj_DoiTac_DAO.Lay_Tat_Ca_DoiTac();
            }
            else
            {
                MessageBox.Show("Các trường không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void tbx_Sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
