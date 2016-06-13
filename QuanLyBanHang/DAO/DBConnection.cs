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
        public static SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=QuanLyBanHang;Integrated Security=True");
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
                cmd.ExecuteNonQuery();
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
                cmd.ExecuteNonQuery();
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
        public bool KiemTraDuLieuTonTai_1ThamSo(string proc, string var)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(String.Format(proc,var), conn);
                cmd.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                if (dt != null) return true;                               
            }
            catch (Exception)
            {
                conn.Close();
            }  
            return false;         
        }
     
    }
}
