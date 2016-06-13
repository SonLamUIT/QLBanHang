
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class CT_DDH_NCC
    {
        public string SoDDH_NCC { get; set; }
        public string MaMatHang { get; set; }
        public int SoLuongDat { get; set; }
        public int SoLuongDaNhap { get; set; }
        public CT_DDH_NCC()
        {

        }
        public CT_DDH_NCC(string sddh, string mamh, int sld, int sldnh)
        {
            SoDDH_NCC = sddh;
            MaMatHang = mamh;
            SoLuongDat = sld;
            SoLuongDaNhap = sldnh;
        }
    }
}
