using System;

namespace ClassLibrary
{
    public class Check
    {

        public  bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public  bool HasUpper(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public  bool HasLower(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
