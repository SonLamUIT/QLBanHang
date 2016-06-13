using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThamSo
    {
        public Double TiLeGiaLe { get; set; }
        public Double TiLeGiaSi { get; set; }
        
        public ThamSo() { }
        public ThamSo(Double tlgiale, Double tlgiasi)
        {
            TiLeGiaLe = tlgiale;
            TiLeGiaSi = tlgiasi;
        }
    }
}
