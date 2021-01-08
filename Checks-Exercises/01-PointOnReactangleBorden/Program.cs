using System;

namespace _01_PointOnReactangleBorden
{
    class Program
    {
        static void Main(string[] args)
        {
            // x1,,y2,x2,y2, x и y
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x= double.Parse(Console.ReadLine());
            double y= double.Parse(Console.ReadLine());

            bool check1 = (x == x1 || x == x2) && (y >= y1 && y <= y2);
            bool check2 = (y == y1 || y == y2) && (x >= x1 && x <= x2);

            if(check1 || check2)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
