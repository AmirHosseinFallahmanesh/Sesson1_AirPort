using System;

namespace Part11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomMchine = new Random();

            int caseSwitch = randomMchine.Next(0,9);
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    Console.WriteLine("Case 3");
                    Console.WriteLine("Case 3");
                    break;
                default:
                    Console.WriteLine("Value didn't match earlier.");
                    break;
            }
        }
    }
}
