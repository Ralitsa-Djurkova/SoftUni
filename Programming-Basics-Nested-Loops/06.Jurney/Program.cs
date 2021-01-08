using System;
using System.Diagnostics.CodeAnalysis;

namespace _06.Jurney
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            bool isFound = false;
            int counter = 0;

            for(int num1 = start; num1 <= end; num1++)
            {
                for(int num2 = start; num2 <= end; num2++)
                {
                    counter++;
                    int sum = num1 + num2;

                    if(sum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({num1} + {num2} = {magicNum})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }

        }
    }
}
