using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace HM9exception_handling
{
    class User
    {
        public User(string username)
        {
            this.UserName = username;
        }

        
        private string _userName;
        public string UserName
        {
            get =>_userName;

            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 6 && value.Length <= 25)
                {
                    _userName = value;
                }
                else
                {
                    throw new InvalidUserNameException("Username teleb olunan deyerleri odemedi! ,Xeta bas verdi!");
                }
            }
        }

        Check check = new Check();

        private string _password;
        public string Password
        {
            get => _password;

            set
            {

                if (!string.IsNullOrWhiteSpace(value) &&value.Length > 8 && value.Length < 25 && check.HasUpper(value) && check.HasLower(value) && check.HasDigit(value))
                {
                    _password = value;
                }
                else
                {
                    throw new PasswordIncorrectException("Password deyeri daxil edilende xeta bas verdi!");
                }
            }
        }

    }
}
