using System;

namespace _02.SystemOtchet
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double sumIncash = 0;
            double sumInCard = 0;
            int countCash = 0;
            int countCard = 0;
            int numOfPayment = 0;
            while (command != "End")
            {
                double priceProduct = double.Parse(command);
                numOfPayment++;
                if (numOfPayment % 2 != 0)
                {
                    if (priceProduct > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        countCash++;
                        sumIncash += priceProduct;
                        Console.WriteLine("Product sold!");
                    }

                }
                else
                {
                    if (priceProduct < 10)
                    {

                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        countCard++;
                        sumInCard += priceProduct;
                        Console.WriteLine("Product sold!");

                    }
                }
                double totalSum = sumIncash + sumInCard;
                if (totalSum >= sum)
                {
                    double averageCard = sumInCard / (double)countCard;
                    double averageCash = sumIncash / (double)countCash;
                    Console.WriteLine($"Average CS: {averageCash:f2}");
                    Console.WriteLine($"Average CC: {averageCard:f2}");
                    break;
                }
                command = Console.ReadLine();

            }
            if (command == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");

            }
        }
    }
}
