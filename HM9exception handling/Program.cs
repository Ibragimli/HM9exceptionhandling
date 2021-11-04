using ClassLibrary;
using System;

namespace HM9exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
                
            string username;
            string password;

            try
            {
                Console.WriteLine("username:");
                username = Console.ReadLine();

                Console.WriteLine("Password daxil edin");
                password = Console.ReadLine();
                User user = new User(username)
                {
                    Password = password
                };

            }
            catch (InvalidUserNameException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (PasswordIncorrectException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                    Console.WriteLine("Bilinmeyen bir xeta bas verdi!!!");
            }
        }
    }
}
