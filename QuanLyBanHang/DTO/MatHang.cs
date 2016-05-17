using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MatHang
    {
        public string MaMatHang { get; set; }
        public string TenMatHang { get; set; }
        public double DonGiaNhap { get; set; }
        public int SoLuongTon { get; set; }
        public string MaDVT { get; set; }
        public MatHang() { }
        public MatHang(string Ma, string ten, double dongia, int sl, string madvt)
        {
            MaMatHang = Ma;
            TenMatHang = ten;
            DonGiaNhap = dongia;
            SoLuongTon = sl;
            MaDVT = madvt;
        }
    }
}
