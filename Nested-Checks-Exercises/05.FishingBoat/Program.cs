using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFisherman = int.Parse(Console.ReadLine());

            double boatPrice = 0.0;
            double discount = 0.0;

            switch (season)
            {
                case "Spring":
                    boatPrice = 3000;
                    break;
                case "Summer":
                    boatPrice = 4200;
                    break;
                case "Autumn":
                    boatPrice = 4200;
                    break;
                case "Winter":
                    boatPrice = 2600;
                    break;

            }
            
            if(countFisherman <= 6)
            {
                discount = boatPrice -  (boatPrice * 0.1);
            }
            else if(countFisherman <= 7 || countFisherman <= 11)
            {
                discount = boatPrice - (boatPrice * 0.15);
            }
            else if(countFisherman > 12)
            {
                discount = boatPrice - (boatPrice * 0.25);
            }

            if(countFisherman %2 == 0 && season != "Autumn")
            {
                discount = discount * 0.95;
            }
            if(budget >= discount)
            {
                double leftManey = budget - discount;
                Console.WriteLine($"Yes! You have {leftManey:f2} leva left.");
            }
            else
            {
                double levaMore = discount - budget;
                Console.WriteLine($"Not enough money! You need {levaMore:f2} leva.");
            }
        }
    }
}
