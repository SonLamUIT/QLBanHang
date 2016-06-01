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
    public class DAOPhieuNhapHang : DBConnection
    {
        public bool KiemTraSoPhieuNhapHangDaTonTai(string proc,string var)
        {
            return KiemTraDuLieuTonTai_1ThamSo(proc, var);
        }
        public bool LuuPhieuNhapHang(PhieuNhapHang pnh)
        {
            try
            {                
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("insert into dbo.PHIEUNHAPHANG values ({0},{1},{2},{3},{4},{5})", pnh.SoPNH,pnh.SoDDH_NCC,pnh.NgayNhap,pnh.TongTien,pnh.ThanhToan,pnh.ConLai),conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand(string.Format("select * from dbo.PHIEUNHAPHANG where SoPNH= {0}", pnh.SoPNH), conn);
                cmd.ExecuteNonQuery();
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
        public DataTable LayDanhSachDonDatHangNCC()
        {            
            try
            {
                
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("select SoDDH_NCC from dbo.DONDATHANG_NCC ORDER BY SoDDH_NCC ASC", conn);
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
        public DataTable LayDanhSachSoPhieuNhapHang()
        {
            try
            {

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("select SoPNH from dbo.PHIEUNHAPHANG ORDER BY SoPNH ASC", conn);
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
        public DataTable LayDanhSachMaMatHang()
        {            
            try
            {

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("select MaMatHang from dbo.MATHANG ORDER BY MaMatHang ASC", conn);
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
    }

}
