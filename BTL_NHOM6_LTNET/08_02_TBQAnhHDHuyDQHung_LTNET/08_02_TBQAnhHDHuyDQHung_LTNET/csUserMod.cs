using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Tên nhóm: TBQAnhHDHuyDQHung_08_QLNH
 * Họ và tên thành viên - MSV - Lớp
 * Tống Bá Quang Anh - 19103100162 - DHTI13A2HN
 * Hà Đăng Huy - 19103100085 - DHTI13A2HN
 * Đinh Quang Hưng - 19103100082 - DHTI13A2HN
 */

namespace _08_02_TBQAnhHDHuyDQHung_LTNET
{
    internal class csUserMod
    {
        public static string mod;
        public static string username;

        public void setMod(string modData)
        {
            mod = modData;
        }

        public string getMod()
        {
            return mod;
        }

        public void setUsername(string Data)
        {
            username = Data;
        }

        public string getUsername()
        {
            return username;
        }
    }
}
