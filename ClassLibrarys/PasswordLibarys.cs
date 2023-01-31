using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarys
{
    public class PasswordLibarys
    {

        public bool Passwordslib(string username, string password) {


            bool symbol = false;
            foreach (char c in password)
            {
                
                if (!char.IsLetterOrDigit(c))
                {
                    //Check if there is a symbol in the password
                    symbol = true; 
                }
            }

                bool respund = true;
                if (password.Length < 12)
                {
                // password is less then 12
                    respund = false;
                }

                if (password == password.ToUpper() || password == password.ToLower())
                {
                //Password dont have atleast one uppercase and lowercade
                    respund = false;
                }

               if (symbol == false)
                {

                //If there is not a symbol in the password
                    respund = false;

                }
                
                if (password.Contains(" "))
                {
                // if there is a sapce in the password
                    respund = false;
                }

                if (char.IsDigit(password[0]) || char.IsDigit(password.Last()))
                {
                //If the first and last charter is a number
                    respund = false;
                }
                if (username.ToLower() == password.ToLower())
                {
                //If the password and username is the same
                    respund = false;
                }

            



            return respund;
        
        }
    }
}
