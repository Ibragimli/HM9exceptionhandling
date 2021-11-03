using System;
using System.Collections.Generic;
using System.Text;

namespace HM9exception_handling
{
    class InvalidUserNameException : Exception
    {
        public InvalidUserNameException(string? msg) : base(msg)
        {

        }
    }
}
