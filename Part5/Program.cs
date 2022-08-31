using System;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Mark");
            short mark = Convert.ToInt16(Console.ReadLine());
            if (mark>=10)
            {
                Console.WriteLine("You Passed");
            }
            else
            {
                Console.WriteLine("You Failed");
            }
        }
    }
}
