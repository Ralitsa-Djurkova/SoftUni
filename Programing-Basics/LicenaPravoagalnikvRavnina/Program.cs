using System;

namespace LicenaPravoagalnikvRavnina
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double lenght = Math.Abs(x1 - x2);
            double widgh = Math.Abs(y1 - y2);

            double area = lenght * widgh;
            double perimetar = 2 * (lenght + widgh);

            Console.WriteLine($"{ area:F2}");
            Console.WriteLine($"{perimetar:F2}");
        }
    }
}
