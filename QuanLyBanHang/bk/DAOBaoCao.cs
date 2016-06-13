using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class DAOBaoCao: DBConnection
    {
        //INSERT INTO BaoCaoDoanhThuTheoMatHang  Exec BaoCaoLoiNhuanTheoMatHangTheoThoiGian '11/01/2016'
        public void ThuThiQuerry(string date)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO BaoCaoDoanhThuTheoMatHang  Exec BaoCaoLoiNhuanTheoMatHangTheoThoiGian '{0}'",date), conn);
                cmd.ExecuteNonQuery();               
            }
            catch (Exception)
            {
                conn.Close();
            }           
        }
    }
}
