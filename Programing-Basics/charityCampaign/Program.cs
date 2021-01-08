using System;

namespace charityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesProfit = cakes * 45 ;
            double wafflesProfit = waffles * 5.80 ;
            double pancakesProfit = pancakes * 3.20;
           

            double profitPerDayByOne = cakesProfit + wafflesProfit + pancakesProfit;
            double profitPerDayByAll = profitPerDayByOne * bakers;
            
            double totalProfit = profitPerDayByAll * days;
            
            double expenses = totalProfit / 8;

            double finalProfit = totalProfit - expenses;

            Console.WriteLine($"{finalProfit:F2}");
        }
    }
}
