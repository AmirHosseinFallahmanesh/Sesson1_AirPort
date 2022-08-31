using System;
using System.Diagnostics;

namespace Part7
{//username admin 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            if (username=="admin" && password=="123")
            {
                Console.WriteLine("Welcome To My App");
                Process.Start("notepad");
            }
            else
            {
                Console.WriteLine("Username or password not vaild");
            }
        }
    }
}
