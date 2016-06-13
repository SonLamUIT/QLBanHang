using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class CTDDH_KH_DAO:DBConnection
    {
        DataProvider dataProvider = new DataProvider();
        public bool themCT_DDHKH(string soddhKH, string mamh, int sldat, int slgiao)
        {
            if (dataProvider.them4ThamSo("INSERT INTO CT_DDH_KH VALUES ('{0}', '{1}', {2}, {3})", soddhKH, mamh, sldat, slgiao))
            {
                return true;
            }
            return false;
        }
    }
}
