using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonDatHang_NCC
    {
        public string SoDDH_NCC { get; set; }
        public string MaDoiTac { get; set; }
        public DateTime NgayLap { get; set; }
        public DonDatHang_NCC() { }
        public DonDatHang_NCC(string shd, string ma, DateTime nl) {
            SoDDH_NCC = shd;
            MaDoiTac = ma;
            NgayLap = nl;
        }
    }
}
