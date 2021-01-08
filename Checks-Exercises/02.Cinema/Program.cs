using System;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double price = 0;

            if(projection == "Premiere")
            {
                price = row * column * 12.00;
                Console.WriteLine($"{price:F2} leva");
            }
            else if(projection == "Normal")
            {
                price = row * column * 7.50;
                Console.WriteLine($"{price:F2} leva");
            }
            else if(projection == "Discount")
            {
                price = row * column * 5;
                Console.WriteLine($"{price:F2} leva");
            }
        }
    }
}
