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
    public class DoiTac_DAO: DBConnection
    {
        DBConnection con = new DBConnection();
        DoiTac obj_DoiTac_DTO = new DoiTac();
        public DataTable Lay_Tatca_TenDoiTac()
        {
            return con.Lay_TatCa_DuLieu("select * from LOAIDOITAC ORDER BY MaLoaiDoiTac ASC");
        }
        public String Get_MaLoaiDoiTac(string str)
        {

            obj_DoiTac_DTO.MaLoaiDoiTac = con.LayDuLieu_String("select * from LOAIDOITAC where TenLoai = N'{0}'", str, "MaLoaiDoiTac");
            return obj_DoiTac_DTO.MaLoaiDoiTac.ToString();
        }
        public void Run_Procedure_Ins_DoiTac(String TenDoiTac, String maloaidoitac, String sdt, String diachi, double sotienno)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("prc_InsertDoiTac N'{0}', '{1}', '{2}', N'{3}', '{4}'", TenDoiTac, maloaidoitac, sdt, diachi, sotienno), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                conn.Close();

            }
        }
        public DataTable Lay_Tat_Ca_DoiTac()
        {
            return con.Lay_TatCa_DuLieu("select distinct MaDoiTac[Mã đối tác], TenDoiTac[Tên đối tác], d.MaLoaiDoiTac[Mã loại đối tác], SDT,DiaChi[Địa chỉ], SoTienNo[Số tiền nợ], TenLoai[Tên loại] from DOITAC d,LOAIDOITAC ldt where d.MaLoaiDoiTac = ldt.MaLoaiDoiTac");
        }
        public DataTable Lay_Doi_Tac_Tim_Kiem(string s1, string s2, string s3, string s4)
        {
            return con.Lay_TatCa_DuLieu_4ThamSo("exec prc_SearchDoiTac N'{0}', N'{1}', '{2}', N'{3}'", s1,s2,s3,s4);
        }
        public bool Update_DoiTac(string s1, string s2, string s3, string s4, string s5)
        {
            return con.Capnhat_DoiTac_5thamso("EXEC prc_UpdateDoiTac N'{0}', N'{1}', '{2}', N'{3}', N'{4}'",s1, s2, s3, s4, s5);
        }
    }
}
