using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuGiaoHang
    {
        public string SoPGH { get; set; }
        public string SoDDH_KH { get; set; }
        public DateTime NgayGiao { get; set; }
        public double TongTien { get; set; }
        public double ThanhToan { get; set; }
        public double ConLai { get; set; }
        public PhieuGiaoHang() { }
        public PhieuGiaoHang(string sopgh, string soddh, DateTime ngaygiao, double tongtien, double thanhtoan, double conlai)
        {
            SoPGH = sopgh;
            SoDDH_KH = soddh;
            NgayGiao = ngaygiao;
            TongTien = tongtien;
            ThanhToan = thanhtoan;
            ConLai = conlai;
        }
    }
}
