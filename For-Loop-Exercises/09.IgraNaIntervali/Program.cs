using System;

namespace _09.IgraNaIntervali
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberHod = int.Parse(Console.ReadLine());
            
            double result = 0.0;
            double second = 0.0;
            double third = 0.0;
            double fourth = 0.0;
            double fifth = 0.0;
            double sixth = 0.0;
            double invalid = 0.0;

            for(int i = 1;i <= numberHod; i++)
            {
                double number = double.Parse(Console.ReadLine());
                
                if(number >= 0 && number <= 9)
                {
                    second++;
                    result += number * 0.2;
                }
                else if(number >= 10 && number <= 19)
                {
                    third++;
                    result += number * 0.3;
                }
                else if(number >=20 && number <= 29)
                {
                    fourth++;
                    result += number * 0.4;
                }
                else if(number >= 30 && number <= 39)
                {
                    fifth++;
                    result += 50;
                }
                else if(number >= 40 && number <= 50)
                {
                    sixth++;
                    result += 100;
                }
                else
                {
                    invalid++;
                    result = result / 2;
                }

            }

            double lowtotal = (second / numberHod) * 100;
            double middletotal = (third / numberHod) * 100;
            double averagetotal = (fourth / numberHod) * 100;
            double highttotal = (fifth / numberHod) * 100;
            double abovetotal = (sixth / numberHod) * 100;
            double invalidtotal = (invalid / numberHod) * 100;

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {lowtotal:f2}%");
            Console.WriteLine($"From 10 to 19: {middletotal:f2}%");
            Console.WriteLine($"From 20 to 29: {averagetotal:f2}%");
            Console.WriteLine($"From 30 to 39: {highttotal:f2}%");
            Console.WriteLine($"From 40 to 50: {abovetotal:f2}%");
            Console.WriteLine($"Invalid number: {invalidtotal:f2}%");
        }
    }
}
