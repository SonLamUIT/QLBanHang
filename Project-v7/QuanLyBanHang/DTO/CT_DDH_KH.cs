using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_DDH_KH
    {
        public string SoDDH_KH { get; set; }
        public string MaMatHang { get; set; }
        public int SoLuongDat { get; set; }
        public int SoLuongGiao { get; set; }
        public CT_DDH_KH() { }
        public CT_DDH_KH(string so, string ma, int soluongdat, int soluonggiao)
        {
            SoDDH_KH = so;
            MaMatHang = ma;
            SoLuongDat = soluongdat;
            SoLuongGiao = soluonggiao;
        }
    }
}
