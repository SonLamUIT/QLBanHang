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
    public class DonDatHangKH_DAO:DBConnection
    {
        DataProvider dataProvider = new DataProvider();
        public DataTable layTatCaDoiTacKH()
        {
            return dataProvider.layTatCaDuLieu("SELECT * FROM DOITAC D, LOAIDOITAC L WHERE D.MaLoaiDoiTac = L.MaLoaiDoiTac AND TenLoai = N'Khách hàng'");
            //AND (d.MaDoiTac not in (select MaDoiTac from DONDATHANG_KH))
        }
        public bool insertDDH_KH(String madoitac, DateTime ngaylap, DateTime ngaygiaodukien)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("prc_InsertDONDATHANG_KH N'{0}', '{1}', '{2}'", madoitac, ngaylap, ngaygiaodukien), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();

            }
            return false;
        }
        public String layMaDoiTacTheoTenDT(string tendt)
        {
            return dataProvider.layDuLieuString("select MaDoiTac from LOAIDOITAC l, DOITAC d where l.MaLoaiDoiTac = d.MaLoaiDoiTac AND l.TenLoai = N'Khách hàng' AND TenDoiTac = N'{0}'", tendt, "MaDoiTac");
        }
        public DataTable layTatCaTenMatHang()
        {
            return dataProvider.layTatCaDuLieu("select * from MATHANG ORDER BY TenMatHang ASC");
        }
        public string laySoDDHKHCuoi()
        {
            return dataProvider.layDuLieuString("select top 1 SoDDH_KH from DONDATHANG_KH order by SoDDH_KH DESC", "SoDDH_KH");
        }
        public String layMaMHTheoTenMatHang(string tenmathang)
        {

            return dataProvider.layDuLieuString("select * from MATHANG where TenMatHang = N'{0}'", tenmathang, "MaMatHang");
        }
        
    }
}
