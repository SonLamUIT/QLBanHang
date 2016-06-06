using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDoiTac
    {

        public string MaLoaiDoiTac { get; set; }
        public string TenLoai { get; set; }
        public LoaiDoiTac()
        { }
        public LoaiDoiTac(string ml, string tl)
        {
            MaLoaiDoiTac = ml;
            TenLoai = tl;
        }
    }
}
