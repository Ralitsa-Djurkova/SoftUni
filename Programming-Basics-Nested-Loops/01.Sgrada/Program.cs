using System;

namespace _01.Sgrada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLoors = int.Parse(Console.ReadLine());
            int numOfRooms = int.Parse(Console.ReadLine());

            for (int floor = numOfLoors; floor >= 1; floor--)
            {
                for (int room = 0; room < numOfRooms; room++)
                {
                    if (floor == numOfLoors)
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
