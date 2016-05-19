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
        
    }
}
