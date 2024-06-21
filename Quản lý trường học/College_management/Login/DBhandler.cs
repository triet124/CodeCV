using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class DBhandler
    {
        public static String Login(String username, String password)
        {

            using (COLLEGE_MANAGEMENTEntities1 csharpDB = new COLLEGE_MANAGEMENTEntities1())
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    return null;
                }

                tai_khoan found = csharpDB.tai_khoan
                    .FirstOrDefault(row => row.USERNAME.Equals(username.Trim()));

                if (found != null && found.PASS.Trim().Equals(password))
                {
                    string phanquyen = found.VAITRO.Trim();
                    return phanquyen;
                }
                return null;
            }
        }

    }
}
