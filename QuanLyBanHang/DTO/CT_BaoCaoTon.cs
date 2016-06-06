using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_BaoCaoTon
    {
        public string MaBCT { get; set; }
        public string MaMatHang { get; set; }
        public int TonDauKy { get; set; }
        public int SoLuongNhap { get; set; }
        public int SoLuongXuat { get; set; }
        public int TonCuoiKy { get; set; }
        public CT_BaoCaoTon() { }
        public CT_BaoCaoTon(string mabct, string mamathang, int tondau, int slnhap, int slxuat, int toncuoi)
        {
            MaBCT = mabct;
            MaMatHang = mamathang;
            TonDauKy = tondau;
            SoLuongNhap = slnhap;
            SoLuongXuat = slxuat;
            TonCuoiKy = toncuoi;
        }
    }
}
