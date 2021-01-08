using System;

namespace ShivashkiCeh
{
    class Program
    {
        static void Main(string[] args)
        {

            int table = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());

            double areaOneCover = (lenght + 2 * 0.30) * (widht + 2 * 0.30);
            double areaOneQuare = (lenght / 2) * (lenght / 2);

            double totalPriceDollars = table * (areaOneCover * 7 +  areaOneQuare * 9);
            double totalPriceBGN = totalPriceDollars * 1.85;

            Console.WriteLine($"{totalPriceDollars:F2} USD");
            Console.WriteLine($"{totalPriceBGN:F2} BGN");


        }
    }
}