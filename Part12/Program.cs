using System;

namespace Part12
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade = 'a';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Well done");
                    break;
                case 'D':
                    Console.WriteLine("You passed");
                    break;
                case 'F':
                    Console.WriteLine("Better try again");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.WriteLine($"Your grade is [ {grade}  ]");
            Console.ReadLine();
        }
    }
}
