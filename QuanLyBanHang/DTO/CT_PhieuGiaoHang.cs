using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_PhieuGiaoHang
    {
    //SoLuongChuaGia		int,
        public string SoPGH { get; set; }
        public string MaMatHang { get; set; }
        public int SoLuongChuaGiao { get; set; }
        public int SoLuongDaGiao { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get; set; }
        public CT_PhieuGiaoHang() { }
        public CT_PhieuGiaoHang(string so, string ma, int slchuagiao, int sldagiao, double dg, double tt)
        {
            SoPGH = so;
            MaMatHang = ma;
            SoLuongChuaGiao = slchuagiao;
            SoLuongDaGiao = sldagiao;
            DonGia = dg;
            ThanhTien = tt;
        }

    }
}
