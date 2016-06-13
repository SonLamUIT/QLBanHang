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
    public class CT_BaoCaoCongNoNCC_DAO: DBConnection
    {
        DataProvider dataProvider = new DataProvider();
        public string layMaBCCNLast()
        {
            return dataProvider.layDuLieuString("select top 1 MaBCCN from BAOCAOCONGNO order by MaBCCN DESC", "MaBCCN");
        }
        public string tinhTongConLaiTheoThangNamMaDT(string maDT, int thang, int nam)
        {
            return dataProvider.layDuLieuString("select sum(ConLai)[Con Lai] from PHIEUNHAPHANG p, DONDATHANG_NCC d where p.SoDDH_NCC = d.SODDH_NCC and MaDoiTac = '{0}' and MONTH(p.NgayNhap) = {1} and YEAR(p.NgayNhap) = {2}", maDT, thang, nam, "Con Lai");
        }
        public string tinhTongTongTienTheoThangNamMaDT(string maDT, int thang, int nam)
        {
            return dataProvider.layDuLieuString("select sum(TongTien)[Tong Tien] from PHIEUNHAPHANG p, DONDATHANG_NCC d where p.SoDDH_NCC = d.SODDH_NCC and MaDoiTac = '{0}' and MONTH(p.NgayNhap) = {1} and YEAR(p.NgayNhap) = {2}", maDT, thang, nam, "Tong Tien");
        }
        public bool capNhatCT_BCCNTheoMaDT(double noDauki, double phatSinh, string maDT)
        {
            if (dataProvider.capNhat("update CT_BAOCAOCONGNO set NoDauKy = {0}, PhatSinh = {1}, NoCuoiKy = {0}+{1} where MaDoiTac = '{2}'", noDauki, phatSinh, maDT))
            {
                return true;
            }
            return false;
        }
    }
}
