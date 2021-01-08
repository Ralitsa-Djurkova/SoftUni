using System;

namespace _3._3Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double countTovari = double.Parse(Console.ReadLine());

          
            double totaltovar = 0;
            double tovarMicrobus = 0;
            double tovarCamion = 0;
            double tovarVlak = 0;
            

            for (int i = 1; i <=countTovari; i++)
            {
                double tonTovar = double.Parse(Console.ReadLine());
                totaltovar += tonTovar;
                if(tonTovar <= 3)
                {
                    tovarMicrobus += tonTovar;
                }
                else if(tonTovar >= 4 && tonTovar <= 11)
                {
                    tovarCamion += tonTovar;
                }
                else if(tonTovar >= 12)
                {
                    tovarVlak += tonTovar;
                }
            }
            double averagePrice = ((tovarMicrobus * 200) + (tovarCamion * 175) + (tovarVlak * 120)) / totaltovar;
            double percentMicrobus = (tovarMicrobus / totaltovar) * 100;
            double percentCamion = (tovarCamion / totaltovar) * 100;
            double percentVlak = (tovarVlak / totaltovar) * 100;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{percentMicrobus:f2}%");
            Console.WriteLine($"{percentCamion:f2}%");
            Console.WriteLine($"{percentVlak:f2}%");


        }
    }
}
