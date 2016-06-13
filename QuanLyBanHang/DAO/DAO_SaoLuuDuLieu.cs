using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DAO_SaoLuuDuLieu : DataProvider
    {
        public DAO_SaoLuuDuLieu() : base() { }
        public void SaoLuuDuLieuDAO(string path, string name)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format(@"exec backupdatabse QuanLyBanHang,'{0}{1}.mdf'", path, name), conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
            }
        }
        public void PhucHoiDuLieuDAO(string path)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                //ALTER DATABASE QuanLyThuVien SET OFFILNE WITH ROLLBACK IMMEDIATE USE master RESTORE DATABASE QuanLyThuVien FROM DISK = '" + filename + "' WITH REPLACE ALTER DATABASE QuanLyThuVien SET ONLINE
                //SqlCommand cmd = new SqlCommand(string.Format(@"exec restoredatabse QUANLYKHACHSAN, '{0}'", path), conn);
                SqlCommand cmd = new SqlCommand(string.Format(@"ALTER DATABASE QuanLyBanHang SET OFFLINE WITH ROLLBACK IMMEDIATE USE master RESTORE DATABASE QuanLyBanHang FROM DISK = '{0}' WITH REPLACE ALTER DATABASE QuanLyBanHang SET ONLINE", path), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
            }
        }
    }
}