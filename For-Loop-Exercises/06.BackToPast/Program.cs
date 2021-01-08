using System;

namespace _06.BackToPast
{
    class Program
    {
        static void Main(string[] args)
        {
            double nasledstvo = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());

            int ageIvan = 18;

            for (int currentYear = 1800; currentYear <= yearToLive; currentYear++)
            {


                if (currentYear % 2 == 0)
                {
                    nasledstvo -= 12000;
                }
                else
                {
                    nasledstvo -= (12000 + (ageIvan * 50));
                }
                ageIvan++;
            }
            if (nasledstvo >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", nasledstvo);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(nasledstvo));
            }
        }
    }
}
