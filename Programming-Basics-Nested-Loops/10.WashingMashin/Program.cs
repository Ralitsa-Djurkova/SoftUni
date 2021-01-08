using System;

namespace _10.WashingMashin
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBottls = int.Parse(Console.ReadLine());
            double bottls = 750;
            double dishes = 5;
            double pots = 15;
            string command = " ";

            while (command != "End")
            {
                int countSadove = int.Parse(Console.ReadLine());
                double totalpreparat = countBottls * 750;
                if (countSadove % 3 == 0)
                {
                    pots = countBottls * 15;
                    totalpreparat -= pots;
                }
                else
                {
                    dishes = dishes * 5;
                    totalpreparat -= dishes;
                }

                if (command == "End")
                {
                    Console.WriteLine("Detergent was enough!");
                    Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                    Console.WriteLine($"Leftover detergent {} ml.");
                }
                
            }
        }
    } 
