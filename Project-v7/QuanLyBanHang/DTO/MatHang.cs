using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MatHang
    {
        public string MaMatHang { get; set; }
        public string TenMatHang { get; set; }
        public int SoLuongTon { get; set; }
        public string MaDVT { get; set; }
        public MatHang() { }
        public MatHang(string ten, int sl, string madvt)
        {         
            TenMatHang = ten;
            SoLuongTon = sl;
            MaDVT = madvt;
        }
    }
}
