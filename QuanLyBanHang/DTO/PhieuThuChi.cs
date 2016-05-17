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
        public DateTime NgayLap { get; set; }
        public string MaDoiTac { get; set; }
        public double TongNo { get; set; }
        public double SoTien { get; set; }
        public PhieuThuChi()
        {

        }
        public PhieuThuChi(string so, DateTime ngay, string ma, double tongno, double sotien)
        {
            SoPTC = so;
            NgayLap = ngay;
            MaDoiTac = ma;
            TongNo = tongno;
            SoTien = sotien;
        }
    }
}
