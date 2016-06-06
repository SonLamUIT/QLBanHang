using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_HDBL
    {
    //DonGia				int,
    //ThanhTien			int,
        public string SoHD { get; set; }
        public string MaMatHang { get; set; }
        public string LoaiHoaDon { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get; set; }
        public CT_HDBL() { }
        public CT_HDBL(string so, string ma, string loai, int soluong, double dongia, double thanhtien)
        {
            SoHD = so;
            MaMatHang = ma;
            LoaiHoaDon = loai;
            SoLuong = soluong;
            DonGia = dongia;
            ThanhTien = thanhtien;
        }
    }
}
