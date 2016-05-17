using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_BaoCaoLoiNhuan
    {
        public string MaBCLN { get; set; }
        public string MaMatHang { get; set; }
        public double DonGia { get; set; }
        public int SoLuongBanLe { get; set; }
        public int SoLuongBanSi { get; set; }
        public double LoiNhuan { get; set; }
        public float TiLe { get; set; }
        public CT_BaoCaoLoiNhuan() { }
        public CT_BaoCaoLoiNhuan(string mabc, string mahang, double dongia, int slle, int slsi, double LoiNhuan, float tile)
        {
            MaBCLN = mabc;
            MaMatHang = mahang;
            DonGia = dongia;
            SoLuongBanLe = slle;
            SoLuongBanSi = slsi;
            LoiNhuan = LoiNhuan;
            TiLe = tile;
        }
    }
}
