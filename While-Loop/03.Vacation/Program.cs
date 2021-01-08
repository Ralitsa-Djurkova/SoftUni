using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double owneMoney = double.Parse(Console.ReadLine());
            int countSpendDays = 0;
            int countDays = 0;
           

            while(owneMoney < needMoney)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                countDays++;

                if(action == "spend")
                {
                    owneMoney -= sum;
                    countSpendDays++;
                }
                if(owneMoney < 0)
                {
                    owneMoney = 0;
                }
                else if(action == "save")
                {
                    owneMoney += sum;
                    countSpendDays = 0;
                    
                }
                if(countSpendDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(countDays);
                   
                    break;
                }

            }
            if(owneMoney >= needMoney)
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
            }

        }
    }
}
