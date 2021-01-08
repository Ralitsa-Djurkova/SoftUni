using System;

namespace _02.ElementRavenNaSumata
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;

                if(number > maxNum)
                {
                    maxNum = number;
                }
               

            }
            sum -= maxNum;
            if (sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                int diff = Math.Abs(sum - maxNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
