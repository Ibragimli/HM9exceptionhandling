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
        public string UserName
        {
            get => this.UserName;

            set
            {
                if (!string.IsNullOrWhiteSpace(value) || value.Length > 6 && value.Length < 25)
                {
                    UserName = value;
                }
                else
                {
                    throw new InvalidUserNameException("Passworda teleb olunan deyerleri odemedi! ,Xeta bas verdi!");
                }
            }
        }

        Check check = new Check();

        public string Password
        {
            get => this.Password;

            set
            {

                if (!string.IsNullOrWhiteSpace(value) || value.Length > 8 || value.Length < 25 || check.HasUpper(value) || check.HasLower(value) || check.HasDigit(value))
                {
                    Password = value;
                }
                else
                {
                    throw new PasswordIncorrectException("Password deyeri daxil edilende xeta bas verdi!");
                }
            }
        }

    }
}
