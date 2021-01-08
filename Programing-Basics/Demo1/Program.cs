using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
              
            //3. print format bgn -> 2 

            double usd = double.Parse(Console.ReadLine());
            double bgn  = usd * 1.79549;
            Console.WriteLine($"{bgn:F2}");

        }
    }
}
