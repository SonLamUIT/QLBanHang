using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonBanLe
    {
        public string SoHD { get; set; }
        public string MaDoiTac { get; set; }
        public DateTime NgayLap { get; set; }
        public double TongThanhTien { get; set; }
        public HoaDonBanLe()
        {

        }
        public HoaDonBanLe(string so, string ma, DateTime ngaylap, double tong)
        {
            SoHD = so;
            MaDoiTac = ma;
            NgayLap = ngaylap;
            TongThanhTien = tong;
        }
    }
}
