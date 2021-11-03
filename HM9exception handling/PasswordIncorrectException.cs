using System;
using System.Collections.Generic;
using System.Text;

namespace HM9exception_handling
{
    class PasswordIncorrectException : Exception
    {
        public PasswordIncorrectException(string? msg) : base(msg)
        {

        }
    }
}
