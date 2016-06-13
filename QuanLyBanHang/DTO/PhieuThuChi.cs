using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThuChi
    {
        public string SoPTC { get; set; }
        public string NgayLap { get; set; }
        public string MaDoiTac { get; set; }
        public Int64 TongNo { get; set; }
        public Int64 SoTien { get; set; }        
        public PhieuThuChi()
        {

        }
        public PhieuThuChi(string so, string ngay, string ma, Int64 tongno, Int64 sotien)
        {
            SoPTC = so;
            NgayLap = ngay;
            MaDoiTac = ma;
            TongNo = tongno;
            SoTien = sotien;            
        }
    }
}
