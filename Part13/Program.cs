using System;

namespace Part13
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            Console.WriteLine("***************");
            Console.WriteLine("Enter Mark Count");
            float count = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            float sum = 0;
            bool error = false;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter Mark");
                float mark = Convert.ToSingle(Console.ReadLine());
                if (mark<0 || mark>20)
                {
                    error = true;
                    break;
                }


                sum += mark;
            }

            if (!error)
            {
                float average = sum / count;
                Console.WriteLine($"the averege is {average}");
            }
            else
            {
                Console.WriteLine("Invalid Mark ! Operation Stop.");
            }
           

         




        }
    }
}
