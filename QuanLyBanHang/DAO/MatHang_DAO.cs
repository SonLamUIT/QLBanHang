using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class MatHang_DAO: DBConnection
    {
        DataProvider dataProvider = new DataProvider();
        MatHang obj_MH_DTO = new MatHang();
        
        public String Get_MaDVT(string str)
        {
            
            obj_MH_DTO.MaDVT =dataProvider.layDuLieuString("select * from DVT where TenDVT = N'{0}'", str, "MaDVT");
            return obj_MH_DTO.MaDVT.ToString();
        }
        
        public void Run_Procedure_Ins_MatHang(String TenMatHang, int Soluongton, String madvt)
        {
            try 
            { 
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("prc_InsertMatHang N'{0}', {1}, '{2}'", TenMatHang, Soluongton, madvt),conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                conn.Close();

            }
        }
        public DataTable Lay_Tatca_DVT()
        {
            return dataProvider.layTatCaDuLieu("select * from DVT ORDER BY TenDVT ASC");
        }
        public DataTable Lay_Tat_Ca_Mat_Hang()
        {
            return dataProvider.layTatCaDuLieu("select distinct MaMatHang[Mã mặt hàng], TenMatHang[Tên mặt hàng], SoLuongTon[Số lượng tồn], TenDVT[Tên đơn vị tính], m.MaDVT [Mã đơn vị tính] from MATHANG m,DVT d where m.MaDVT = d.MaDVT");
        }
        public DataTable Lay_Mat_Hang_Tim_Kiem(string str)
        {
            return dataProvider.layTatCaDuLieu("select distinct MaMatHang[Mã mặt hàng], TenMatHang[Tên mặt hàng], SoLuongTon[Số lượng tồn], TenDVT[Tên đơn vị tính], m.MaDVT [Mã đơn vị tính] from MATHANG m,DVT d where m.MaDVT = d.MaDVT and TenMatHang = N'{0}'", str);
        }
        public void Xoa_MatHang(string ma)
        {
            dataProvider.xoa("DELETE FROM MATHANG WHERE TenMatHang = N'{0}'", ma);
        }

        public String Lay_Ten_Mat_Hang(string str)
        {
            
            return dataProvider.layDuLieuString("select * from MATHANG where TenMatHang = N'{0}'", str, "TenMatHang");
        }

        public String Lay_MaMatHang(string str)
        {

            return dataProvider.layDuLieuString("select * from MATHANG where TenMatHang = N'{0}'", str, "MaMatHang");
        }
    }
}
