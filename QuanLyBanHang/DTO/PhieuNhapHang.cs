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
        public UInt64 TongTien { get; set; }
        public UInt64 ThanhToan { get; set; }
        public UInt64 ConLai { get; set; }
        public PhieuNhapHang()
        {

        }
        public PhieuNhapHang(string sopnh, string sddh, DateTime ngay, UInt64 tong, UInt64 thanhtoan, UInt64 conlai)
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
