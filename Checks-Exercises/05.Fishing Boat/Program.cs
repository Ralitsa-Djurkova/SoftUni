using System;
using System.Xml.Schema;

namespace _05.Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numFisherman = int.Parse(Console.ReadLine());

            double rent = 0;
            double discount = 0;
            double totalRent = rent - discount;
            double leftMoney = totalRent - budget;

            if ((numFisherman <= 6 && numFisherman % 2 == 0) && season == "Spring")
            {
                rent = 3000;
                totalRent = totalRent - 0.10 * totalRent;

            }
            if ((numFisherman <= 7 || numFisherman >= 11 && numFisherman % 2 == 0) && season == "summer" && season == "outumn")
            {
                rent = 4200;
                totalRent = totalRent - 0.15 * totalRent;
            }

            else if ((numFisherman >= 12) && season == "winter")
            {
                rent = 2600;
                totalRent = totalRent - 0.25 * totalRent;
            }
            if (budget > leftMoney)
            {
                Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
            }
            if (budget < leftMoney)
            {
                Console.WriteLine($"Not enough money! You need {leftMoney:F2} leva.");
            }






