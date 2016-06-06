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
        DBConnection con = new DBConnection();
        MatHang obj_MH_DTO = new MatHang();
        
        public String Get_MaDVT(string str)
        {
            
            obj_MH_DTO.MaDVT =con.LayDuLieu_String("select * from DVT where TenDVT = N'{0}'", str, "MaDVT");
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
            return con.Lay_TatCa_DuLieu("select * from DVT ORDER BY TenDVT ASC");
        }
        public DataTable Lay_Tat_Ca_Mat_Hang()
        {
            return con.Lay_TatCa_DuLieu("select distinct MaMatHang[Mã mặt hàng], TenMatHang[Tên mặt hàng], SoLuongTon[Số lượng tồn], TenDVT[Tên đơn vị tính], m.MaDVT [Mã đơn vị tính] from MATHANG m,DVT d where m.MaDVT = d.MaDVT");
        }
        public DataTable Lay_Mat_Hang_Tim_Kiem(string str)
        {
            return con.Lay_TatCa_DuLieu_1ThamSo("select distinct MaMatHang[Mã mặt hàng], TenMatHang[Tên mặt hàng], SoLuongTon[Số lượng tồn], TenDVT[Tên đơn vị tính], m.MaDVT [Mã đơn vị tính] from MATHANG m,DVT d where m.MaDVT = d.MaDVT and TenMatHang = N'{0}'", str);
        }
        public void Xoa_MatHang(string ma)
        {
            con.Xoa_1thamSo("DELETE FROM MATHANG WHERE TenMatHang = N'{0}'", ma);
        }

        public String Lay_Ten_Mat_Hang(string str)
        {
            
            return con.LayDuLieu_String("select * from MATHANG where TenMatHang = N'{0}'", str, "TenMatHang");
        }
    }
}
