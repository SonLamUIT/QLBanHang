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
    public class CTHDBL_DAO:DBConnection
    {
        DataProvider dataProvider = new DataProvider();
        
        public bool themCTHDBL(string sohd, string mamh, int soluong, double dongia, double thanhtien)
        {
            if (dataProvider.them5ThamSo("INSERT INTO CT_HDBL VALUES ('{0}', '{1}', {2}, {3}, {4})", sohd, mamh, soluong, dongia, thanhtien))
            {
                return true;
            }
            return false;
        }
        public DataTable layTatCaTenMatHang()
        {
            return dataProvider.layTatCaDuLieu("select * from MATHANG ORDER BY TenMatHang ASC");
        }
        
    }
}
