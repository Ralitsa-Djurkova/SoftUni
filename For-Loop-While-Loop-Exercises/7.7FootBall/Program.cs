using System;

namespace _7._7FootBall
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int countFens = int.Parse(Console.ReadLine());

            int fens1 = 0;
            int fens2 = 0;
            int fens3 = 0;
            int fens4 = 0;
            for (int i = 1; i <= countFens; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    fens1++;
                }
                else if (sector == "B")
                {
                    fens2++;
                }
                else if (sector == "G")
                {
                    fens3++;
                }
                else if(sector == "V")
                {
                    fens4++;
                }
            }
            double percentSectorA = ((double)fens1 /(double)countFens) * 100;
            double percentSectorB = ((double)fens2 /(double)countFens) * 100;
            double percentSectorG = ((double)fens3 /(double)countFens) * 100;
            double percentSectorV = ((double)fens4 /(double)countFens) * 100;
            double percent = ((double)countFens /(double)capacity) * 100;

            Console.WriteLine($"{percentSectorA:f2}%");
            Console.WriteLine($"{percentSectorB:f2}%");
            Console.WriteLine($"{percentSectorV:f2}%");
            Console.WriteLine($"{percentSectorG:f2}%");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
