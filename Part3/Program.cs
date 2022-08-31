using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5%2);
            Console.WriteLine("*******************");
            int a = 10;
            a = a + 10;
            a += 10;
            a += 1;
            a++;
            ++a;

            //***********************************
            int x = 10;
            int y = 10;
            Console.WriteLine("x "+x++);
            Console.WriteLine("y "+ ++y);
            Console.WriteLine("final result x "+x+" y "+y);
        } 
    }
}
