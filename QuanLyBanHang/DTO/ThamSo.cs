using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThamSo
    {
        public string MaThamSo { get; set; }
        public string TenThamSo { get; set; }
        public double GiaTri { get; set; }
        public ThamSo() { }
        public ThamSo(string Ma, string Ten, double giatri)
        {
            MaThamSo = Ma;
            TenThamSo = Ten;
            GiaTri = giatri;
        }
    }
}
