using System;

namespace _08.Po_slojni_Proverki
{
    class Program
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine();

            // if (weather == "snowy")
            //{
            //    Console.WriteLine("Let's do skiing");
            //}
            //else if (weather == "rainy")
            //{
            //    Console.WriteLine("Take your umbrellla!");
            //}
            //else if (weather == "sunny")
            //{
            //    Console.WriteLine("Get your sunglasses!");
            //}
            //else if (weather == "windy")
            //{
            //    Console.WriteLine("Get your coat!");
            //}
            
            
            switch (weather)
            { 
                case "snowy":
                    Console.WriteLine("Let's do skiing");
                    break;
                case "rainy":
                    Console.WriteLine("Take your umbrellla!");
                    break;
                case "sunny":
                    Console.WriteLine("Get your sunglasses!");
                    break;
                case "windy":
                    Console.WriteLine("Get your coat!");
                    break;
            }
        }  

    }
}
