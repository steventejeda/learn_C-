using System;

namespace LoginSystem
{
    class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }
        static void Register()
        {
            Console.WriteLine("Please enter username for registration:");
            username = Console.ReadLine();
            Console.WriteLine("Please enter password for registration:");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("--------------------------------------------------");
        }
        static void Login()
        {
            Console.WriteLine("User Login");
            if (username == Console.ReadLine())
            {
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Successfully logged in!");
                }
                else
                {
                    Console.WriteLine("Invalid Password, Restart program");
                }
            }
            else
            {
                Console.WriteLine("Invalid username, restart program");
            }
        }
    }
}