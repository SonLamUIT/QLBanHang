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
        public string NgayNhap { get; set; }
        public Int64 TongTien { get; set; }
        public Int64 ThanhToan { get; set; }
        public Int64 ConLai { get; set; }
        public PhieuNhapHang()
        {

        }
        public PhieuNhapHang(string sopnh, string sddh, string ngay, Int64 tong, Int64 thanhtoan, Int64 conlai)
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
