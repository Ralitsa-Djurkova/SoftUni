using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDog = int.Parse(Console.ReadLine());
            int numberPets = int.Parse(Console.ReadLine());

            double priceDog= numberDog * 2.50;
            double pricePets = numberPets * 4;
            double totalSum = priceDog + pricePets;

            Console.WriteLine($"{totalSum} lv.");
        }
    }
}
