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
    public partial class Them_MatHang : MetroForm
    {
        
  
        public Them_MatHang()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            MatHang obj_MatHang = new MatHang();
            MatHang_DAO obj_MH_DAO = new MatHang_DAO();
            obj_MatHang.TenMatHang = tbx_tenmathang.Text;
            obj_MatHang.SoLuongTon = Convert.ToInt32(tbx_soluongton.Text);
            obj_MatHang.MaDVT = obj_MH_DAO.Get_MaDVT(get_DVT());
            try
            {
                obj_MH_DAO.Run_Procedure_Ins_MatHang(tbx_tenmathang.Text, obj_MatHang.SoLuongTon, obj_MatHang.MaDVT);
                MessageBox.Show("Them mat hang thanh cong.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public String get_DVT()
        {
            return tbx_donvitinh.Text;
        }

        public String get_TenMatHang()
        {
            return tbx_tenmathang.Text;
        }
        public int get_SoLuongTon()
        {
            return Convert.ToInt32(tbx_soluongton.Text);
        }
        

    }
}
