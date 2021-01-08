using System;

namespace EducasionalHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
          double  widht = double.Parse(Console.ReadLine());
          

            int cols = ((int)widht - 100) / 70;
            int rows = (int)lenght / 120;
            int seats = rows * cols - 3;
            Console.WriteLine(rows * cols - 3);

        }
    }
}
