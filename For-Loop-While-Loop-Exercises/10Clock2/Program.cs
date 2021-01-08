using System;

namespace _10Clock2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    for (int secunds = 0; secunds <= 59; secunds++)
                    {
                        Console.WriteLine($"{hour} : {minutes} : {secunds}");
                    }
                }
            }
        }
    }
}
