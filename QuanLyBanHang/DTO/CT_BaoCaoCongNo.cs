using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_BaoCaoCongNo
    {
    //    MaBBCN				nvarchar(10) foreign key references BAOCAOCONGNO(MaBBCN),
        public string MaBCCN { get; set; }
        public string MaDoiTac { get; set; }
        public double NoDauKy { get; set; }
        public double PhatSinh { get; set; }
        public double NoCuoiKy { get; set; }
        public CT_BaoCaoCongNo() { }
        public CT_BaoCaoCongNo(string mamccn, string madoitac, double nodauky, double phatsinh, double nocuoiky)
        {
            MaBCCN = mamccn;
            MaDoiTac = madoitac;
            NoDauKy = nodauky;
            PhatSinh = phatsinh;
            NoCuoiKy = nocuoiky;
        }
    }
}
