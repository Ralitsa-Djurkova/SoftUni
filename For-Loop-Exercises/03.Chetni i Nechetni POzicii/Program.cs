﻿using System;

namespace _03.Chetni_i_Nechetni_POzicii
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0.0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue; 
            double evenSum = 0.0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for(int  i = 1; i <= n; i++)
            {
                double currNumber = double.Parse(Console.ReadLine());

                if(i % 2 == 0)
                {
                    evenSum += currNumber;

                    if(currNumber < evenMin)
                    {
                        evenMin = currNumber;
                    }
                    if(currNumber > evenMax)
                    {
                        evenMax = currNumber;
                    }
                }
                else
                {
                    oddSum += currNumber;
                    if (currNumber < oddMin)
                    {
                        oddMin = currNumber;
                    }
                    if (currNumber > oddMax)
                    {
                        oddMax = currNumber;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if(oddSum == 0)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if(evenSum == 0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
           
        }
    }
}