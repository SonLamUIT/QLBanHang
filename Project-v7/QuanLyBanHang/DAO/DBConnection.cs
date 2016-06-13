using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class DBConnection
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=SONLAM;Initial Catalog=QuanLyBanHang;MultipleActiveResultSets = true;Integrated Security=True");
         
    }
}
