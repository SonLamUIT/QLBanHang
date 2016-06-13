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
    public class DonDatHang_DAO:DBConnection
    {
        DataProvider dataProvider = new DataProvider();

        public DataTable layTatCaMatHang()
        {
            return dataProvider.layTatCaDuLieu("select * from MATHANG ORDER BY TenMatHang ASC");
        }

        public DataTable layTatcaNCC()
        {
            return dataProvider.layTatCaDuLieu("select * from DOITAC WHERE MaLoaiDoiTac='LDT02' ORDER BY TenDoiTac ASC");
        }

        public String layMaDoiTac(String name)
        {
            return dataProvider.layDuLieuString("select * from DOITAC where TenDoiTac = N'{0}'", name, "MaDoiTac");
        }

        public String laySoDDH_NCC(String maDoiTac)
        {
            return dataProvider.layDuLieuString("select * from DONDATHANG_NCC where MaDoiTac = N'{0}'", maDoiTac, "SoDDH_NCC");
        }

        public String laySoDDH_NCCLast()
        {
            return dataProvider.layDuLieuString("select top 1 SoDDH_NCC from DONDATHANG_NCC order by SoDDH_NCC DESC", "SoDDH_NCC");
        }

        public bool runProcedureInsDonDatHang_NCC(String MaDoiTac, String NgayLap)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
               SqlCommand cmd1 = new SqlCommand(string.Format("SET DATEFORMAT DMY"),conn);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand(string.Format("prc_InsertDonDatHang_NCC N'{0}', '{1}'", MaDoiTac, NgayLap), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(e);
                conn.Close();
                return false;
            }
            
        }

        public bool runProcedureInsCT_DDH_NCC(String So_DDH_NCC, String MaMatHang,int SoLuongDat)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("prc_InsertCT_DDH_NCC N'{0}', N'{1}',{2},{3}", So_DDH_NCC, MaMatHang, SoLuongDat,0), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                conn.Close();
                return false;
            }
        }
        public DataTable layTatCaSoDDH_NCCTheoNCC(string tenNCC)
        {
            return dataProvider.layTatCaDuLieu("select * from DOITAC dt, DONDATHANG_NCC dd where dt.MaDoiTac = dd.MaDoiTac and TenDoiTac = N'{0}'",tenNCC);
        }

        public DataTable timKiemThongTinKH(string tenNCC, string SoDDH_NCC)
        {
            return dataProvider.layTatCaDuLieu("select m.TenMatHang [Mặt hàng], c.SoLuongDat[Số lượng đặt], c.SoLuongDaNhap[Số lượng nhập] from DONDATHANG_NCC d, CT_DDH_NCC c, DOITAC dt, MATHANG m where dt.MaDoiTac = d.MaDoiTac and d.SoDDH_NCC = c.SoDDH_NCC and m.MaMatHang = c.MaMatHang and TenDoiTac = N'{0}'  and c.SoDDH_NCC = '{1}'", tenNCC, SoDDH_NCC);
        }
        public string layMaDoiTacTheoTenDoiTac(string tendoitac)
        {
            return dataProvider.layDuLieuString("select MaDoiTac from DOITAC where TenDoiTac = N'{0}'", tendoitac, "MaDoiTac");
        }
    }
}
