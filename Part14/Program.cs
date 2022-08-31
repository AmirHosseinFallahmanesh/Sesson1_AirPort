using System;

namespace Part14
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (input !="q")
            {
                Console.WriteLine("Enter text or Press q tp exit");
                input = Console.ReadLine();
                Console.WriteLine("You Enterd "+input);
            }
            Console.WriteLine("End of Loop");

            while (true)
            {
                Random randomMachine = new Random();
                int value = randomMachine.Next(1, 1000);
                Console.Write("*");
                if (value>998)
                {
                    break;
                }
            }
        }
    }
}
