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
    public class CT_PhieuGiaoHang_DAO:DBConnection
    {
        DataProvider dataProvider = new DataProvider();

        public bool themCT_PhieuGiaoHang(string sopgh, string mamh, int soluongchuagiao, int soluongdagiao, double dongia, double thanhtien)
        {
            if (dataProvider.them6ThamSo("INSERT INTO CT_PHIEUGIAOHANG VALUES ('{0}', '{1}', {2}, {3}, {4}, {5})", sopgh, mamh, soluongchuagiao, soluongdagiao, dongia, thanhtien))
            {
                return true;
            }
            return false;
        }
        public string tinhTongThanhTien(string sopgh)
        {
            return dataProvider.layDuLieuString("SELECT SUM(ThanhTien) [Tong Thanh Tien] FROM CT_PHIEUGIAOHANG where SoHD = '{0}'", sopgh, "Tong Thanh Tien");
        }
    }
}
