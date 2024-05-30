using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dangnhap
{
    class DBHandler
    {
        public static String Login(String username, String password)
        {
            
            using (QuanLyXeHoiEntities csharpDB = new QuanLyXeHoiEntities())
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    return null;
                }

                DangNhap found = csharpDB.DangNhaps
                    .FirstOrDefault(row => row.username.Equals(username.Trim()));

                if (found != null && found.matkhau.Trim().Equals(password))
                {
                    string phanquyen = found.PhanQuyen.Trim();
                    return phanquyen;
                }   
                return null;
            }
        }
    }
}
