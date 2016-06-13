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
    public class BaoCaoCongNoKH_DAO:DBConnection
    {
        DataProvider dataProvider = new DataProvider();
        public string layTongConLaiTheoSoDDH(string soddh, int thang, int nam)
        {
            return dataProvider.layDuLieuString("select sum(ConLai)[Con lai] from PHIEUGIAOHANG where SoDDH_KH = '{0}' and MONTH(NgayGiao) = {1} and YEAR(NgayGiao) = {2}", soddh, thang, nam, "Con Lai");
        }

        public bool capNhatSoTienNo(double sotienno, string maDT)
        {
            return dataProvider.capNhat1ThamSo("update DOITAC set SoTienNo = {0} where MaDoiTac = '{1}'", sotienno, maDT);
        }

        //public string layNoDauKi(string soddh)
        //{

        //}
        public void runProcThemBCNN(int Thang, int Nam, string MaLoaiDoiTac)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("prc_InsertBAOCAOCONGNO {0}, {1}, N'{2}'", Thang, Nam, MaLoaiDoiTac), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                conn.Close();

            }
        }
        public bool capNhatBaoCaoCongNo(int thang, int nam, string maBCCN)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(string.Format("Update BAOCAOCONGNO set Thang = {0}, Nam = {1} where MaBCCN = '{2}'", thang, nam, maBCCN), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }
        public string layMaBCCNTheoMaDoiTac(string maDT)
        {
            return dataProvider.layDuLieuString("select c.MaBCCN from DOITAC d, CT_BAOCAOCONGNO c where c.MaDoiTac = d.MaDoiTac and d.MaDoiTac = N'{0}'", maDT, "MaBCCN");
        }

        public DataTable baoCaoCongNo(string maDT)
        {
            return dataProvider.layTatCaDuLieu("select d.MaDoiTac[Mã đối tác], d.TenDoiTac [Tên đối tác], l.TenLoai [Loại đối tác], SDT, DiaChi [Địa chỉ], Thang [Tháng], Nam [Năm], NoDauKy [Nợ đầu kỳ], PhatSinh [Phát Sinh], NoCuoiKy [Nợ cuối kỳ] from DOITAC d, LOAIDOITAC l, BAOCAOCONGNO b, CT_BAOCAOCONGNO c where d.MaLoaiDoiTac = l.MaLoaiDoiTac and d.MaDoiTac = c.MaDoiTac and c.MaBCCN = b.MaBCCN and d.MaDoiTac = '{0}'",maDT);
        }

    }
}
