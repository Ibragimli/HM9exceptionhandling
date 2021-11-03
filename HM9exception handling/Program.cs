using ClassLibrary;
using System;

namespace HM9exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("salam");
            Check check = new Check();
            string username;
            string password;
            do
            {
                username = Console.ReadLine();

            } while (username.Length < 6 || username.Length >25);

            password = Console.ReadLine();



        }
    }
}
