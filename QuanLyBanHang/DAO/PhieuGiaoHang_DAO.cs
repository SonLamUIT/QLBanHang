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
    public class PhieuGiaoHang_DAO:DBConnection
    {
        DataProvider dataProvider = new DataProvider();
        public DataTable layTatCaKHDaDatHang()
        {
            return dataProvider.layTatCaDuLieu("SELECT DISTINCT D.TenDoiTac FROM DOITAC D, DONDATHANG_KH ddh WHERE D.MaDoiTac = ddh.MaDoiTac");
            //AND (d.MaDoiTac not in (select MaDoiTac from DONDATHANG_KH))
        }
        public DataTable layTatCaSoDDHKH(string madoitac)
        {
            return dataProvider.layTatCaDuLieu("select SoDDH_KH from DONDATHANG_KH where MaDoiTac = '{0}'", madoitac);
            //AND (d.MaDoiTac not in (select MaDoiTac from DONDATHANG_KH))
        }
        public string layMaDoiTacTheoTenDoiTac(string tendoitac)
        {
            return dataProvider.layDuLieuString("select MaDoiTac from DOITAC where TenDoiTac = N'{0}'", tendoitac, "MaDoiTac");
        }
        public DataTable layTatCaDDHTheoTenSoDDH(string tenkh, string sddh)
        {
            return dataProvider.layTatCaDuLieu("select m.TenMatHang [Mặt hàng], TenDVT [Đơn vị tính], c.SoLuongDat [Số lượng đặt], c.SoLuongDaGiao [Số lượng đã giao], d.NgayLap [Ngày lập], d.NgayGiaoHangDuKien [Ngày giao (dự kiến)] from DONDATHANG_KH d, CT_DDH_KH c, MATHANG m, DVT dvt, DOITAC dt where m.MaMatHang = c.MaMatHang AND c.SoDDH_KH = d.SoDDH_KH AND dvt.MaDVT = m.MaDVT AND dt.MaDoiTac = d.MaDoiTac AND TenDoiTac = N'{0}' AND d.SoDDH_KH = N'{1}'", tenkh, sddh);
        }
        public bool themPhieuGiaoHang(string soddh_kh, DateTime ngaygiao, double tongtien, double thanhtoan, double conlai)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(string.Format("prc_InsertPHIEUGIAOHANG N'{0}', '{1}', {2}, {3}, {4}", soddh_kh, ngaygiao, tongtien, thanhtoan, conlai), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();

            }
            return false;
        }
        public DataTable layCTPhieuGiaoHang(string sddh)
        {
            return dataProvider.layTatCaDuLieu("select m.MaMatHang [Mã mặt hàng], m.TenMatHang [Mặt hàng], c.SoLuongDat [Số lượng đặt] from CT_DDH_KH c, MATHANG m  where m.MaMatHang = c.MaMatHang AND c.SoDDH_KH = N'{0}'", sddh);
        }
        public string laySoPGHCuoi()
        {
            return dataProvider.layDuLieuString("select top 1 SoPGH from PHIEUGIAOHANG order by SoPGH DESC", "SoPGH");
        }
        public bool capNhatTongTien(double tongtien, string soddhkh)
        {
            if (dataProvider.capNhat1ThamSo("update PHIEUGIAOHANG set TongTien = {0} where (SoDDH_KH = N'{1}' and SoPGH in (select top 1 SoPGH from PHIEUGIAOHANG order by SoPGH DESC))", tongtien, soddhkh))
            {
                return true;
            }
            return false;
        }
        public bool capNhatCTDDHKH_SoLuongDaGiao(int sldagiao, string soddhkh, string maMH)
        {
            if (dataProvider.capNhat("update CT_DDH_KH set SoLuongDaGiao = {0} where (SoDDH_KH = N'{1}' and MaMatHang = '{2}')", sldagiao, soddhkh, maMH))
            {
                return true;
            }
            return false;
        }
        public bool capNhatThanhToan(double thanhtoan, string soddhkh)
        {
            if (dataProvider.capNhat1ThamSo("update PHIEUGIAOHANG set ThanhToan = {0} where (SoDDH_KH = N'{1}' and SoPGH in (select top 1 SoPGH from PHIEUGIAOHANG order by SoPGH DESC))", thanhtoan, soddhkh))
            {
                return true;
            }
            return false;
        }
        public bool capNhatConLai(double conlai, string soddhkh)
        {
            if (dataProvider.capNhat1ThamSo("update PHIEUGIAOHANG set ConLai = {0} where (SoDDH_KH = N'{1}' and SoPGH in (select top 1 SoPGH from PHIEUGIAOHANG order by SoPGH DESC))", conlai, soddhkh))
            {
                return true;
            }
            return false;
        }
        public string laySoLuongDaGiao(string dk1, string dk2)
        {
            return dataProvider.layDuLieuString("select * from CT_DDH_KH where SoDDH_KH = '{0}' and MaMatHang = '{1}'", dk1, dk2, "SoLuongDaGiao");
        }

        public string layTongSoLuongDat(string dk1)
        {
            return dataProvider.layDuLieuString("select SoLuongDat from CT_DDH_KH c, DONDATHANG_KH d where c.SoDDH_KH = d.SoDDH_KH and c.MaMatHang = '{0}'", dk1, "SoLuongDat");
        }

        public string layTongSoLuongDaGiao(string dk1, string dk2)
        {
            return dataProvider.layDuLieuString("select sum(c.SoLuongDaGiao)[Số lượng đã giao] from CT_PHIEUGIAOHANG c, PHIEUGIAOHANG p where c.MaMatHang = '{0}' AND c.SoPGH = p.SoPGH AND p.SoDDH_KH = '{1}'", dk1, dk2, "Số lượng đã giao");
        }
        public string layTongConLai(string dk1)
        {
            return dataProvider.layDuLieuString("select sum(ConLai)[Con Lai] from PHIEUGIAOHANG p, DONDATHANG_KH d where p.SoDDH_KH = d.SODDH_KH and p.SoDDH_KH = '{0}'", dk1, "Con Lai");
        }
    }
}
