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
    public class DAOThuChi: DBConnection
    {
        public bool KiemTraSoPhieuThuChiDaTonTai(string var)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("select * from PHIEUTHUCHI where SoPTC='{0}'", var), conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                if (dt != null)
                    if(dt.Rows.Count>0)
                        return true;
            }
            catch (Exception)
            {
                conn.Close();
            }
            return false;
        }
        public bool LapPhieuThuChi(PhieuThuChi ptc)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("ThemPhieuThuChi '{0}', '{1}', '{2}', {3}, {4}",ptc.SoPTC, ptc.NgayLap, ptc.MaDoiTac, ptc.TongNo, ptc.SoTien), conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand(string.Format("select * from PHIEUTHUCHI where SoPTC='{0}'", ptc.SoPTC), conn);
                cmd1.ExecuteNonQuery();      
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null) return true;
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
            }
            return false;
        }
        public string LayTongNoDoiTac(string MaDoiTac)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("select SoTienNo from DOITAC where MaDoiTac='{0}'",MaDoiTac), conn);
                cmd.ExecuteNonQuery();                              
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return Convert.ToString(dt.Rows[0][0]);                              
            }
            catch (Exception)
            {
                conn.Close();
            }
            return null;
        }
        public DataTable LayDanhSachDoiTac()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("select MaDoiTac from DOITAC"), conn);
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
        public bool KiemTraLoaiDoiTacLaNCCHayKhacHang(string MaDoiTac)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("select dt.MaLoaiDoiTac from DOITAC dt,LOAIDOITAC ldt where dt.MaLoaiDoiTac=ldt.MaLoaiDoiTac and dt.MaDoiTac='{0}'", MaDoiTac), conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                if (dt.Rows[0][0].ToString() == "NCC") return true;               
            }
            catch (Exception)
            {
                conn.Close();
            }
            return false;         
        }
    }
}
