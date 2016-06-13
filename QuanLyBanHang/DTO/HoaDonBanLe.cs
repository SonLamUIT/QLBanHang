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
        public string TenKH { get; set; }
        public DateTime NgayLap { get; set; }
        public double TongThanhTien { get; set; }
        public HoaDonBanLe()
        {

        }
        public HoaDonBanLe(string so, string ten, DateTime ngaylap, double tong)
        {
            SoHD = so;
            TenKH = ten;
            NgayLap = ngaylap;
            TongThanhTien = tong;
        }
    }
}
