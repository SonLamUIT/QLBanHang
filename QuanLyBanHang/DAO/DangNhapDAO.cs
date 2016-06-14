using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DangNhapDAO : DBConnection
    {
        public DangNhapDAO() : base() { }
        public bool DangNhap_Select_DAO(string TenTaiKhoan, string MatKhau)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(string.Format("exec KiemTraDangNhap '{0}','{1}'", TenTaiKhoan, MatKhau), conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {                    
                    SqlCommand cmd1 = new SqlCommand(string.Format("insert into LichSuDuLieu values ('{0}',N'{1}')", DateTime.Now.ToString("dd/mm/yyyy HH:mm"), TenTaiKhoan + " đã đăng nhập."), conn);
                    cmd1.ExecuteNonQuery();
                    return true;
                }
                conn.Close();
                return false;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }

    }
}
