using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNTest.DAL;

namespace DNTest.BUS
{
    public class LoginBUS
    {
        Login obj = new Login();
        public int Get_LoginBUS(string User, string Password)
        {
            return obj.Get_Login(User, Password);
        }
    }
}
