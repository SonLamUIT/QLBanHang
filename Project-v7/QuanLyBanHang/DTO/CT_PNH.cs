using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_PNH
    {
        public string SoPNH { get; set; }
        public string MaMatHang { get; set; }
        public int SoLuongChuaNhap { get; set; }
        public int SoLuongNhap { get; set; }
        public double DonGiaNhap { get; set; }
        public double ThanhTien { get; set; }
        public CT_PNH()
        {

        }
        public CT_PNH(string so, string ma, int soluongchuanhap, int soluongnhap, double dongia, double thanhtien)
        {
            SoPNH = so;
            MaMatHang = ma;
            SoLuongChuaNhap = soluongchuanhap;
            SoLuongNhap = soluongnhap;
            DonGiaNhap = dongia;
            ThanhTien = thanhtien;
        }
    }
}
