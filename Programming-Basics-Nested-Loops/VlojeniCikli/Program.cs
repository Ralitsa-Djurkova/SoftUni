using System;

namespace VlojeniCikli
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours < 24; hours++)
            {
                for (int minutes = 0;  minutes <= 59; minutes++)
                {
                    for (int seconds = 0;  seconds<= 59; seconds++)
                    {
                        Console.WriteLine($"{hours}:{minutes}:{seconds}");
                        if(seconds == 10)
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}
