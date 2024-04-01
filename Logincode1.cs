using System;

namespace Logincode1
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempts = 3;

            while (attempts > 0)
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();

                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (username == "Admin" && password == "Admin1234!")
                {
                    Console.WriteLine("Login successful!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect credentials.");
                    attempts--;
                    Console.WriteLine("Remaining attempts: " + attempts + "\n");
                }
            }

            if (attempts == 0)
            {
                Console.WriteLine("Logging in failed! Maximum attempts reached, please try again later.");
            }
        }
    }
}
