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
        public bool KiemTraSoPhieuNhapHangDaTonTai(string var)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("select * from PHIEUNHAPHANG where SoPNH='{0}'", var), conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                if (dt != null)
                    if (dt.Rows.Count > 0)
                        return true;
            }
            catch (Exception)
            {
                conn.Close();
            }
            return false;
        }
        public bool LuuPhieuNhapHang(PhieuNhapHang pnh)
        {
            try
            {                
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                } 
                SqlCommand cmd = new SqlCommand(string.Format("insert into dbo.PHIEUNHAPHANG values ('{0}','{1}','{2}',{3},{4},{5})", pnh.SoPNH,pnh.SoDDH_NCC,pnh.NgayNhap,pnh.TongTien,pnh.ThanhToan,pnh.ConLai),conn); //(SoPNH,SoDDH_NCC,NgayNhap,TongTien,ThanhToan)
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand(string.Format("select * from dbo.PHIEUNHAPHANG where SoPNH= '{0}'", pnh.SoPNH), conn);
                cmd1.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                    if (dt.Rows.Count > 0)
                        return true;
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
        public bool ThayDoiPhieuNhapHang(string SoPhieuNhapHang1,string SoPhieuNhapHang2, string SoDonDatHangNhaCungCap, string NgayNhap, UInt64 TongTien, UInt64 ThanhToan, UInt64 ConLai)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("UPDATE dbo.PHIEUNHAPHANG SET SoPNH ='{0}', SoDDH_NCC='{1}', NgayNhap='{2}', TongTien={3}, ThanhToan={4}, ConLai={5}  WHERE SoPNH='{6}'", SoPhieuNhapHang2, SoDonDatHangNhaCungCap, NgayNhap, TongTien, ThanhToan, ConLai, SoPhieuNhapHang1), conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand(string.Format("select * from dbo.PHIEUNHAPHANG where SoPNH= '{0}'", SoPhieuNhapHang2), conn);
                cmd1.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                    if (dt.Rows.Count > 0)
                        return true;
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
            }
            return false;
        }
        public bool LapChiTietPhieuNhapHang(CT_PNH ctpnh)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("insert into dbo.CT_PNH values ('{0}','{1}',{2},{3},{4},{5})", ctpnh.SoPNH,ctpnh.MaMatHang,ctpnh.SoLuongChuaNhap,ctpnh.SoLuongNhap,ctpnh.DonGiaNhap,ctpnh.ThanhTien), conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(string.Format("exec CapNhatTongTienPhieuNhapHang '{0}',{1}", ctpnh.SoPNH, ctpnh.ThanhTien), conn);
                cmd2.ExecuteNonQuery();                
                SqlCommand cmd1 = new SqlCommand(string.Format("select * from dbo.CT_PNH where SoPNH= '{0}'", ctpnh.SoPNH), conn);
                SqlCommand cmd3 = new SqlCommand(string.Format("exec CapNhatConLaiPhieuNhapHang '{0}'", ctpnh.SoPNH), conn);
                cmd3.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                    if (dt.Rows.Count > 0)
                        return true;
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
            }
            return false;
        }
    }
}
