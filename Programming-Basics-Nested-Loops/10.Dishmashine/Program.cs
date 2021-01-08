using System;

namespace _10.Dishmashine
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBottels = int.Parse(Console.ReadLine());
            string countSadove = Console.ReadLine();

            int sadove = 0;
            int counter = 0;
            double tengeri = 0.0;
            double chinii = 0.0;
            double izrazhodvanPreapratChinii = 0.0;
            double izrazhodvanPreaparatTengeri = 0.0;
            double izrazhodvanMiPreparat = 0.0;
            double izrazhodvanPreparat = countBottels * 750; ;

            while(countSadove != "End")
            {
                sadove = int.Parse(countSadove);

                if(counter % 3 == 0)
                {
                    izrazhodvanPreaparatTengeri = sadove * 15;
                    izrazhodvanMiPreparat -= izrazhodvanPreaparatTengeri;
                    tengeri += sadove;
                    izrazhodvanPreparat = izrazhodvanPreaparatTengeri;

                }
                else
                {
                    izrazhodvanPreapratChinii = sadove * 5;
                    izrazhodvanPreparat -= izrazhodvanPreapratChinii;
                    chinii += sadove;
                    izrazhodvanPreparat = izrazhodvanPreapratChinii;
                }
            }
            counter++;
            if(izrazhodvanMiPreparat >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{chinii} dishes and {tengeri} pots were washed.");
                Console.WriteLine($"Leftover detergent {izrazhodvanMiPreparat} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(izrazhodvanMiPreparat - izrazhodvanPreparat)} ml. more necessary!");
            }

        }
    }
}
