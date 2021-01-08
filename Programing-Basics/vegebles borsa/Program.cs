using System;

namespace vegebles_borsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            double vegPerKg = int.Parse(Console.ReadLine());
            double fruitsPerKg = int.Parse(Console.ReadLine());

            double vegTotal = vegPrice * vegPerKg;
            double fruitsTotal = fruitsPrice * fruitsPerKg;
            double totalPrice =( vegTotal + fruitsTotal) / 1.94;
            

                Console.WriteLine((fruitsTotal + vegTotal) / 1.94);
        }
    }
}
