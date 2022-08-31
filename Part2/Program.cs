using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string staicName = "amir";
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Hello "+name+" "+ surname);


            Console.WriteLine("Enter Number 1");
            int number1 =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2;
            Console.WriteLine("the result is "+result);


        }
    }
}
