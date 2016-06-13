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
    public class HoaDonBanLe_DAO:DBConnection
    {
        DataProvider dataProvider = new DataProvider();
        public bool runInsertHDBL(String tenkh, DateTime ngaylap, double tongthanhtien)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("prc_InsertHoaDonBanLe N'{0}', '{1}', {2}", tenkh, ngaylap, tongthanhtien), conn);
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
        public string laySoHDCuoi()
        {
            return dataProvider.layDuLieuString("select top 1 SoHD from HOADONBANLE order by SoHD DESC", "SoHD");
        }

        public String layMaMHTheoTenMatHang(string tenmathang)
        {

            return dataProvider.layDuLieuString("select * from MATHANG where TenMatHang = N'{0}'", tenmathang, "MaMatHang");
        }

        public string tinhTongThanhTien(string sohd)
        {
            return dataProvider.layDuLieuString("SELECT SUM(ThanhTien) [Tong Thanh Tien] FROM CT_HDBL where SoHD = '{0}'", sohd, "Tong Thanh Tien");
        }
        public bool capNhatTongThanhTien(double tongthanhtien, string sohd)
        {
            if (dataProvider.capNhat1ThamSo("UPDATE HOADONBANLE SET TongThanhTien = {0} WHERE SoHD = '{1}'", tongthanhtien, sohd))
            {
                return true;
            }
            return false;
        }
        public DataTable timKiemThongTinKH(string tenkh)
        {
            return dataProvider.layTatCaDuLieu("Select c.MaMatHang [Mã mặt hàng], TenMatHang [Tên mặt hàng], SoLuong [Số lượng], DonGia [Đơn giá], ThanhTien [Thành Tiền], NgayLap [Ngày lập] from MATHANG m, HOADONBANLE h, CT_HDBL c where m.MaMatHang = c.MaMatHang AND h.SoHD = c.SoHD AND TenKH = N'{0}'", tenkh);
        }
    }
}
