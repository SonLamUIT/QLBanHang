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
        public static DataTable LoadDuLieu(string commandText)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(commandText, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
        public bool Them(String function)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(String.Format(function), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                //Console.WriteLine("CCCCCCCCCCCCCCCCCCCCCCCCC"+ex);
                return false;
            }
        }
        public string LayDuLieu_String(string function, string thamso, string ketqua)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                { conn.Open(); }

                SqlCommand cmd = new SqlCommand(string.Format(function, thamso), conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    return rd[ketqua].ToString();
                }
                rd.Close();
            }
            catch (Exception)
            {
                conn.Close();
            }
            return null;
        }
        
    }
}
