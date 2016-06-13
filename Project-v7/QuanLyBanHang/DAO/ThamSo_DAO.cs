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
    public class ThamSo_DAO : DBConnection
    {
        DataProvider dataProvider = new DataProvider();


        public bool UpdateThamSo(ThamSo ts)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(String.Format("prc_UpdateThamSo {0}, {1}", ts.TiLeGiaLe, ts.TiLeGiaSi), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
        public string layTiLeGiaLe()        //Lay Ti le gia le
        {
            return dataProvider.layDuLieuString("select TiLeGiaLe from THAMSO", "TiLeGiaLe");
        }
        public string layTiLeGiaSi()        //Lay ti le gia si
        {
            return dataProvider.layDuLieuString("select TiLeGiaSi from THAMSO", "TiLeGiaSi");
        }
    }
}
