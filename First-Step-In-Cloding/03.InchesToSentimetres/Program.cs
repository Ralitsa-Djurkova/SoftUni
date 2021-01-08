using System;

namespace _03.InchesToSentimetres
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double sentometers = inches * 2.54;
            Console.WriteLine(sentometers);
        }
    }
}
