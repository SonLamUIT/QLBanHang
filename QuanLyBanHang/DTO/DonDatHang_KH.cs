using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonDatHang_KH
    {
        public string SoDDH_KH { get; set; }
        public string MaDoiTac { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public DonDatHang_KH() { }
        public DonDatHang_KH(string so, string ma, DateTime ngaylap, DateTime ngaygiao)
        {
            SoDDH_KH = so;
            MaDoiTac = ma;
            NgayLap = ngaylap;
            NgayGiaoHang = ngaygiao;
        }
    }
}
