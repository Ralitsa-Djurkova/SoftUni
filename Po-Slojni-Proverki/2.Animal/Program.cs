using System;

namespace _2.Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodil":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
                    
            }
        }
    }
}
