using System;

namespace _02.TablicaZaUmnogenie
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                for(int y = 1; y <= 10; y++)
                {
                    int result = i * y;
                    Console.WriteLine($"{i} * {y} = {result}");
                }
            }
        }
    }
}
