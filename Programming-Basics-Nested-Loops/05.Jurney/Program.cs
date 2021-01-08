using System;

namespace _05.Jurney
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while(destination != "End")
            {
                double moneyNeedet = double.Parse(Console.ReadLine());
                double savedMoney = 0.0;
                while (savedMoney < moneyNeedet)
                {
                    double currentSavedMoney = double.Parse(Console.ReadLine());
                    savedMoney += currentSavedMoney;
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }

        }
    }
}
