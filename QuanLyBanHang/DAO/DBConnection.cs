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
        public DataTable Lay_TatCa_DuLieu(string function)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(function, conn);
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
        public DataTable Lay_TatCa_DuLieu_1ThamSo(string function, string thamso)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format(function,thamso), conn);
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
        public DataTable Lay_TatCa_DuLieu_4ThamSo(string function, string ts1, string ts2, string ts3, string ts4)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format(function, ts1,ts2,ts3,ts4), conn);
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
        public bool Xoa_1thamSo(string fuction, string thamso)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format(fuction, thamso), conn);
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
        public bool Capnhat_DoiTac_5thamso(string function, string ts1, string ts2, string ts3, string ts4, string ts5)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(string.Format("EXEC prc_UpdateDoiTac N'{0}', N'{1}', '{2}', N'{3}', N'{4}'", ts1, ts2, ts3, ts4, ts5), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }
        
        
    }
}
