using System;

namespace _01.BackInPast
{
    class Program
    {
        static void Main(string[] args)
        {
            double naslestvo = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            int yearsIvan = 18;
           
            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    naslestvo -= 12000;
                }
                else
                {
                    naslestvo -= 12000 + (50 * yearsIvan);
                }
                yearsIvan++;
            }
            if (naslestvo >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {naslestvo:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(naslestvo):f2} dollars to survive.");
            }
        }
    }
}
