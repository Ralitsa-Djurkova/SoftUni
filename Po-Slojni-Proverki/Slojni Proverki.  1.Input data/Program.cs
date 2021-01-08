using System;

namespace Slojni_Proverki.__1.Input_data
{
    class Program
    {
        static void Main(string[] args)
        {
            //Такси.Начална такса: 0.70 лв.Дневна тарифа: 0.79 лв./ км.Нощна тарифа: 0.90 лв./ км.
            // Автобус.Дневна / нощна тарифа: 0.09 лв./ км.Може да се използва за раз - стояния минимум 20 км.
            // Влак.Дневна / нощна тарифа: 0.06 лв./ км.Може да се използва за разсто - яния минимум 100 км.

            int distance = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double price = 0;
            double taxiRate = 0;

            if(dayOrNight == "day")
            {
                taxiRate = 0.79;
            }
            else
            {
                taxiRate = 0.90;
            }
            if(distance < 20)
            {
                price = 0.70 +(distance * taxiRate);
            }
            else if(distance < 100)
            {
                price = distance * 0.09;
            }
            else
            {
                price = distance * 0.06;
            }
            Console.WriteLine(price);
        }  


    }
}
