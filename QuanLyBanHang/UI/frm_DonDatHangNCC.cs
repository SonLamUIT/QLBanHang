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
    public partial class frm_DonDatHangNCC : MetroForm
    {
        DonDatHang_DAO obj_DonDatHang_DAO = new DonDatHang_DAO();
        MatHang_DAO obj_MatHang_DAO = new MatHang_DAO();

        public frm_DonDatHangNCC()
        {
            InitializeComponent();
            dtgrid_mathang.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dtgrid_mathang_EditingControlShowing);
        }

        private void dtgrid_mathang_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox cb;
            if (dtgrid_mathang.CurrentCell is DataGridViewComboBoxCell)
            {
                cb = e.Control as ComboBox;

                if (cb == null)
                    return;

                //// first remove event handler to keep from attaching multiple:
                //cb.SelectedIndexChanged -= new
                //EventHandler(cb_SelectedIndexChanged);


                // now attach the event handler
                cb.SelectedIndexChanged += cb_SelectedIndexChanged;
            }
        }

        void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cl_TenMH.Items.RemoveAt(1);
            ComboBox cmbBox = (ComboBox)sender;
            if (cmbBox.SelectedValue != null)
            {
                //MessageBox.Show(cmbBox.SelectedValue.ToString());  //testing
                //cl_TenMH.Items.Remove(cmbBox.SelectedValue);   //this removes it from the current combobox as well, no good.  Also run time error when clicking into a different combobox
                //cl_TenMH.Items.Add(cmbBox.SelectedValue.ToString());
            }
        }

        private void DonDatHang_Load(object sender, EventArgs e)
        {
            

            cbx_NCC.DataSource = obj_DonDatHang_DAO.layTatcaNCC();
            cbx_NCC.DisplayMember = "TenDoiTac";
            cbx_NCC.ValueMember = "TenDoiTac";
            cbx_NCC.SelectedIndex = 0;

            cl_TenMH.DataSource = obj_MatHang_DAO.Lay_Tat_Ca_Mat_Hang();
            //cl_TenMH.Items.AddRange();
            //var stringArr = obj_MatHang_DAO.Lay_Tat_Ca_Mat_Hang().Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
            //var stringArr = obj_MatHang_DAO.Lay_Tat_Ca_Mat_Hang().Columns[0];
            //cl_TenMH.Items.AddRange(obj_MatHang_DAO.Lay_Tat_Ca_Mat_Hang().Columns[0]);
            
            cl_TenMH.DisplayMember = "Tên mặt hàng";
            cl_TenMH.ValueMember = "Tên mặt hàng";

            //foreach (var row in obj_MatHang_DAO.Lay_Tat_Ca_Mat_Hang().Rows)//or similar
            //{
            //    cl_TenMH.Items.Add();
            //}




        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void dtgrid_mathang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dtgrid_mathang.Rows[e.RowIndex].Cells["cl_TenMH"].Value.ToString());
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool addDonDatHang_NCC = false;
            bool addCT_DDH_NCC = false;
            try
            {
                /// thêm vào bảng DonDatHang_NCC
                if (obj_DonDatHang_DAO.runProcedureInsDonDatHang_NCC(obj_DonDatHang_DAO.layMaDoiTac(cbx_NCC.Text), dtime_NgayLap.Value.Date.ToString("dd/MM/yyyy")))
                    addDonDatHang_NCC = true;

                /// thêm vào bảng chi tiết DonDatHang_NCC
                for (int row = 0; row < dtgrid_mathang.RowCount - 1; row++)
                {
                    if (addDonDatHang_NCC)
                    {
                        if (obj_DonDatHang_DAO.runProcedureInsCT_DDH_NCC(obj_DonDatHang_DAO.laySoDDH_NCCLast()
                            , obj_MatHang_DAO.Lay_MaMatHang(dtgrid_mathang.Rows[row].Cells["cl_TenMH"].Value.ToString())
                            , Int32.Parse(dtgrid_mathang.Rows[row].Cells["cl_SoLuongDat"].Value.ToString())))
                        {
                            addCT_DDH_NCC = true;
                        }
                        else
                            addCT_DDH_NCC = false;
                    }

                }
                cbx_NCC.SelectedIndex = -1;
                dtgrid_mathang.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (addDonDatHang_NCC && addCT_DDH_NCC)
                MessageBox.Show("Thêm thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbx_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgrid_mathang_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgrid_mathang_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["cl_SoLuongDaNhap"].Value = 0;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            frm_TimKiemDonDatHangNCC f = new frm_TimKiemDonDatHangNCC(cbx_NCC.SelectedIndex);
            f.ShowDialog();
        }
    }
}
