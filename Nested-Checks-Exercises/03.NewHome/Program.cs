using System;

namespace _03.NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersTape = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double ssinglePrice = 0.0;
            double totalPrice = 0.0;

            switch (flowersTape)
            {
                case "Roses":
                    ssinglePrice = 5;
                    break;
                case "Dahlias":
                    ssinglePrice = 3.80;
                    break;
                case "Tulips":
                    ssinglePrice = 2.80;
                    break;
                case "Narcissus":
                    ssinglePrice = 3;
                    break;
                case "Gladiolus":
                    ssinglePrice = 2.50;
                    break;

            }
            totalPrice = ssinglePrice * countFlowers;

            if (countFlowers > 80 && flowersTape == "Roses")
            {
                totalPrice = totalPrice * 0.9;
            }
            else if (countFlowers > 90 && flowersTape == "Dahlias")
            {
                totalPrice = totalPrice - totalPrice * 0.15;
            }
            else if (countFlowers > 80 && flowersTape == "Tulips")
            {
                totalPrice = totalPrice - totalPrice * 0.15;
            }
            else if (countFlowers < 120 && flowersTape == "Narcissus")
            {
                totalPrice = totalPrice + totalPrice * 0.15;
            }
            else if (countFlowers < 80 && flowersTape == "Gladiolus")
            {
                totalPrice = totalPrice + totalPrice * 0.20;
            }

            if (budget >= totalPrice)
            {
                double levaLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {flowersTape} and {levaLeft:f2} leva left.");
            }
            else
            {
                double levaMore = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {levaMore:f2} leva more.");
            }
        }
    }
}
