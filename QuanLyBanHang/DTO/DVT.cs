using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DVT
    {
        public string MaDVT { get; set; }
        public string TenDVT { get; set; }
        public DVT() { }
        public DVT(string Ma, string ten)
        {
            MaDVT = Ma;
            TenDVT = ten;
        }
    }
}
