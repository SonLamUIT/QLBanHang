using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DataProvider:DBConnection
    {
        public string layDuLieuString(string function, string thamso, string ketqua)
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
        public DataTable layTatCaDuLieu(string function)
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
        public DataTable layTatCaDuLieu(string function, string thamso)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format(function, thamso), conn);
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
        public DataTable layTatCaDuLieu(string function, string ts1, string ts2, string ts3, string ts4)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format(function, ts1, ts2, ts3, ts4), conn);
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
        public bool xoa(string fuction, string thamso)
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
        public bool capNhatDoiTac(string function, string ts1, string ts2, string ts3, string ts4, string ts5)
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
        public string layDuLieuString(string query, string ketQua)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                { conn.Open(); }

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    return rd[ketQua].ToString();
                }
                rd.Close();
            }
            catch (Exception)
            {
                conn.Close();
            }
            return null;
        }
        public bool them5ThamSo(string query, string ts1, string ts2, int ts3, double ts4, double ts5)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(string.Format(query, ts1, ts2, ts3, ts4, ts5), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();
                
            }
            return false;
        }
        public bool capNhat1ThamSo(string query, double value, string dk)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(string.Format(query, value, dk), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();

            }
            return false;
        }
        public bool them4ThamSo(string query, string ts1, string ts2, int ts3, int ts4)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(string.Format(query, ts1, ts2, ts3, ts4), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();

            }
            return false;
        }
        public DataTable layTatCaDuLieu(string function, string ts1, string ts2)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format(function, ts1, ts2), conn);
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
        public bool them6ThamSo(string query, string ts1, string ts2, int ts3, int ts4, double ts5, double ts6)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(string.Format(query, ts1, ts2, ts3, ts4, ts5, ts6), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();

            }
            return false;
        }
        public bool capNhat(string query, int value, string dk1, string dk2)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(string.Format(query, value, dk1, dk2), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();

            }
            return false;
        }
        public string layDuLieuString(string query, string ts1, string ts2, string ketqua)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                { conn.Open(); }

                SqlCommand cmd = new SqlCommand(string.Format(query, ts1, ts2), conn);
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
        public string layDuLieuString(string query, string ts1, int ts2, int ts3, string ketqua)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                { conn.Open(); }

                SqlCommand cmd = new SqlCommand(string.Format(query, ts1, ts2, ts3), conn);
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
        public bool capNhat(string query, double value1, double value2, string dk)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(string.Format(query, value1, value2, dk), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();

            }
            return false;
        }
    }
}
