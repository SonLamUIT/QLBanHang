using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoiTac
    {
        public string MaDoiTac { get; set; }
        public string TenDoiTac { get; set; }
        public string MaLoaiDoiTac { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public double SoTienNo { get; set; }
        public DoiTac() { }
        public DoiTac(string mdt, string tendt, string ml, string sdt, string dc, double no)
        {
            MaDoiTac = mdt;
            TenDoiTac = tendt;
            MaLoaiDoiTac = ml;
            SDT = sdt;
            DiaChi = dc;
            SoTienNo = no;
        }
    }
}
