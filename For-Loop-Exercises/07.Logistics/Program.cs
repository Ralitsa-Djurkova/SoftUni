using System;

namespace _07.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTovar = int.Parse(Console.ReadLine());

            double micorbus = 0.0;
            double truck = 0.0;
            double train = 0.0;
            double sumTons = 0.0;

            double microbusTons = 0.0;
            double truckTons = 0.0;
            double trainTons = 0.0;
            double averageTons = 0.0;

           

            for(int i = 1; i <= countTovar; i++)
            {
                double tons = double.Parse(Console.ReadLine());

                if(tons <= 3)
                {
                    micorbus = micorbus + tons * 200;
                    microbusTons += tons;
                }
                else if(tons >= 4 && tons <= 11)
                {
                    truck = truck + tons * 175;
                    truckTons += tons;
                }
                else if(tons >= 12)
                {
                    train = train + tons * 120;
                    trainTons += tons;
                }

            }
            sumTons = microbusTons + truckTons + trainTons;
            averageTons = (micorbus + truck + train) / sumTons;

            micorbus = microbusTons / sumTons * 100;
            truck = truckTons / sumTons * 100;
            train = trainTons / sumTons * 100;

            Console.WriteLine($"{averageTons:f2}");
            Console.WriteLine($"{micorbus:f2}%");
            Console.WriteLine($"{truck:f2}%");
            Console.WriteLine($"{train:f2}%");
        }
    }
}
