using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double priceType = 0.0;
            double area = rows * colums;

            if(type == "Premiere")
            {
                priceType = area * 12;
                Console.WriteLine($"{priceType:f2} leva");

            }
            else if(type == "Normal")
            {
                priceType = area * 7.50;
                Console.WriteLine($"{priceType:f2} leva");
            }
            else if(type == "Discount")
            {
                priceType = area * 5;
                Console.WriteLine($"{priceType:f2} leva");
            }
        }
    }
}
