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
        public UInt64 DonGiaNhap { get; set; }
        public UInt64 ThanhTien { get; set; }
        public CT_PNH()
        {

        }
        public CT_PNH(string so, string ma, int soluongchuanhap, int soluongnhap, UInt64 dongia, UInt64 thanhtien)
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
