using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoCongNo
    {
    //    MaBBCN				nvarchar(10) primary key,
        public string MaCCN { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public string MaLoaiDoiTac { get; set; }
        public BaoCaoCongNo()
        {

        }
        public BaoCaoCongNo(string ma, int thang, int nam, string maloaidoitac)
        {
            MaCCN = ma;
            Thang = thang;
            Nam = nam;
            MaLoaiDoiTac = maloaidoitac;
        }
    }
}
