using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_10_1.Models
{
    public static class AuthModel
    {
        const string ValidUsername = "admin";
        const string ValidPassword = "12345";
        public static bool Authenticate(string username, string password)
        {
            return username.Equals(ValidUsername) && password.Equals(ValidPassword);
        }
    }

}
