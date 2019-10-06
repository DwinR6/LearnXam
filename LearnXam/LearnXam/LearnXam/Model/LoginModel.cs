using System;
using System.Collections.Generic;
using System.Text;

namespace LearnXam.Model
{
   public class LoginModel
    {
        public LoginModel(string user, string pass)
        {
            this.user = user.ToLower();
            this.pass = pass;
        }

        public string Validate()
        {
            while (user != "kricia")
            {
                return "User or pass is incorrect";
            }

            return "";
        }

        string user;
        string pass;       
    }
}
