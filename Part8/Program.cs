using System;

namespace Part8
{
    class Program
    {
        //nested if
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();
            if (username=="admin")
            {
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();

                if (password=="123")
                {
                    Console.Clear();
                    Console.WriteLine("Welcome To My App");
                }
                else
                {
                    Console.WriteLine("Password Not Valid");
                }
            }
            else
            {
                Console.WriteLine("Username Not Found");
            }
        }
    }
}
