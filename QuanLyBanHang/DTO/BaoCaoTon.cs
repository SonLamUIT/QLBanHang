using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoTon
    {
        public string MaBCT { get; set; }
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public BaoCaoTon() { }
        public BaoCaoTon(string ma, int ngay, int thang, int nam)
        {
            MaBCT = ma;
            Ngay = ngay;
            Thang = thang;
            Nam = nam;
        }
    }
}
