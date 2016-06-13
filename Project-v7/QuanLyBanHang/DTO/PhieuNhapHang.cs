using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapHang
    {
        public string SoPNH { get; set; }
        public string SoDDH_NCC { get; set; }
        public DateTime NgayNhap { get; set; }
        public double TongTien { get; set; }
        public double ThanhToan { get; set; }
        public double ConLai { get; set; }
        public PhieuNhapHang()
        {

        }
        public PhieuNhapHang(string sopnh, string sddh, DateTime ngay, double tong, double thanhtoan, double conlai)
        {
            SoPNH = sopnh;
            SoDDH_NCC = sddh;
            NgayNhap = ngay;
            TongTien = tong;
            ThanhToan = thanhtoan;
            ConLai = conlai;
        }
    }
}
