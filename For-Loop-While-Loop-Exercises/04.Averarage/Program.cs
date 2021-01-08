using System;

namespace _04.Averarage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0.0;
            double average = 0.0;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
                average = sum / (double)n;
            }
            Console.WriteLine($"{average:f2}");
        }
    }
}
