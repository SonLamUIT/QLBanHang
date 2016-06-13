using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoLoiNhuan
    {
        public string MaBCLN { get; set; }
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public double TongLoiNhuan { get; set; }
        public BaoCaoLoiNhuan() { }
        public BaoCaoLoiNhuan(string ma, int ngay, int thang, int nam, double tong)
        {
            MaBCLN = ma;
            Ngay = ngay;
            Thang = thang;
            Nam = nam;
            TongLoiNhuan = tong;
        }
    }
}
