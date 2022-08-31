using System;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter C# Mark");
            //double cs = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter SQL Mark");
            //double sql = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter ASP Mark");
            //double asp = Convert.ToDouble(Console.ReadLine());

            //double average = (cs + sql + asp) / 3;
            //Console.WriteLine("the average is "+average);


            Console.WriteLine("Enter C# Mark");
            float cs = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter SQL Mark");
            float sql = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter ASP Mark");
            float asp = Convert.ToSingle(Console.ReadLine());

            float average = (cs + sql + asp) / 3;
            Console.WriteLine("the average is " + average);
        }
    }
}
