using System;

namespace _11.Football
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadion = double.Parse(Console.ReadLine());
            double countFens = double.Parse(Console.ReadLine());

            
            double pepoleA = 0;
            double pepoleB = 0;
            double pepoleV = 0;
            double pepoleG = 0;



            for (int i = 1; i <= countFens; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    pepoleA++;
                }
                else if (sector == "B")
                {
                    pepoleB++;
                }
                else if (sector == "V")
                {
                    pepoleV++;
                }
                else if (sector == "G")
                {
                    pepoleG++;
                }
            }
            double fansInSectorA = (pepoleA / countFens) * 100;
            double fansInSectorB = (pepoleB / countFens) * 100;
            double fansInSectorV = (pepoleV / countFens) * 100;
            double fansInSectorG = (pepoleG / countFens) * 100;
            double totalCapacitet = (countFens / stadion) * 100;

            Console.WriteLine($"{fansInSectorA:f2}%");
            Console.WriteLine($"{fansInSectorB:f2}%");
            Console.WriteLine($"{fansInSectorV:f2}%");
            Console.WriteLine($"{fansInSectorG:f2}%");
            Console.WriteLine($"{totalCapacitet:f2}%");
        }
    }
}
