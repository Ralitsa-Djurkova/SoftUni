using System;

namespace Sadomialna
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBottels = int.Parse(Console.ReadLine());
            string countDishes = Console.ReadLine();

            int sudove = 0;
            int counter = 1;
            double totalMiPreparat = countBottels * 750;
            double izrazhodvanPreparatChinii = 0;
            double izrazhodvanPreparatTengeri = 0;
            double izrazhodvanPreparat = 0;
            double brojChinii = 0;
            double brojTengeri = 0;


            while(countDishes != "End")
            {
                sudove = int.Parse(countDishes);

                if(counter %3 == 0)
                {
                    izrazhodvanPreparatTengeri = sudove * 15;
                    totalMiPreparat = (totalMiPreparat - izrazhodvanPreparatTengeri);
                    brojTengeri += sudove;
                    izrazhodvanPreparat = izrazhodvanPreparatTengeri;
                }
                else
                {
                    izrazhodvanPreparatChinii = sudove * 5;
                    totalMiPreparat = (totalMiPreparat - izrazhodvanPreparatChinii);
                    brojChinii += sudove;
                    izrazhodvanPreparat = izrazhodvanPreparatChinii;
                }
                if(totalMiPreparat <= 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(totalMiPreparat)} ml. more necessary!");
                    return;
                }
                countDishes = Console.ReadLine();
                counter++;
            }
            if(totalMiPreparat > 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{brojChinii} dishes and {brojTengeri} pots were washed.");
                Console.WriteLine($"Leftover detergent {totalMiPreparat} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(totalMiPreparat)} ml. more necessary!");
            }


           
                
            

        }
    }
}
