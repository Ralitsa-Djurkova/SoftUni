using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {

            int leghtcake = int.Parse(Console.ReadLine());
            int WeightCake = int.Parse(Console.ReadLine());
            int totalPices = leghtcake * WeightCake;
            string input = Console.ReadLine();

            while(input != "Stop")
            {
                int pieces = int.Parse(input);
                totalPices -= pieces;

                if (totalPices < 0)
                {
                    break;
                }
                input = Console.ReadLine();

                  
            }
            if(totalPices < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPices)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{totalPices} pieces are left." );
            }




            

        }   
    }
}
