using System;

namespace AlkoholnaBorsa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
           

            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiaLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice - 0.4 * rakiaPrice;
            double beerPrice = rakiaPrice - 0.8 * rakiaPrice;

            double totalPrice = (rakiaPrice * rakiaLiters) + (winePrice * wineLiters) + (whiskeyPrice * whiskeyLiters) + (beerLiters * beerPrice);

            Console.WriteLine($"{totalPrice:F2}");



            
            
        }
    }
}
