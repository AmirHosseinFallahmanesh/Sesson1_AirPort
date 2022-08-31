using System;

namespace Part10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c");
            int c = Convert.ToInt32(Console.ReadLine());

            int delta = (b * b) - (4 * a * c);

            if (delta > 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("root 1 is "+root1);
                Console.WriteLine("root 2 is "+root2);
            }
            else if (delta == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("root  is " + root);
            }
            else
            {
                Console.WriteLine("has no roots");
            }

        }
    }
}
