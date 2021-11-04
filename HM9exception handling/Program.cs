using ClassLibrary;
using System;

namespace HM9exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            Check check = new Check();
            string username;
            string password;


            try
            {
                do
                {
                    Console.WriteLine("username:");
                    username = Console.ReadLine();

                } while (username.Length < 6 || username.Length > 25);
                User user = new User(username);

            }
            catch (InvalidUserNameException)
            {
                Console.WriteLine("partdadi");
            }
            catch (Exception)
            {

                Console.WriteLine("Bilinmeyen bir xeta bas verdi!!!");
            }


            try
            {
                do
                {
                    password = Console.ReadLine();

                } while (!check.HasDigit(password) || !check.HasLower(password) || !check.HasUpper(password) || password.Length < 6 || password.Length > 25);


            }
            catch (PasswordIncorrectException)
            {
                Console.WriteLine("duzgun daxil edilmedi diye error");
            }

            catch (Exception)
            {

                Console.WriteLine("Bilinmeyen bir xeta bas verdi!!!");
            }

        }
    }
}
