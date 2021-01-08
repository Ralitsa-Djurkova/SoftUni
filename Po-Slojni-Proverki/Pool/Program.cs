using System;

namespace Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());//обем на басеина в литри
            int Pipe1 = int.Parse(Console.ReadLine());// дебита на първата тръба за час
            int Pipe2 = int.Parse(Console.ReadLine());// дебита на втората тръба за час
            double hours = double.Parse(Console.ReadLine());//часовете, в които работника отсъства

            double water = (hours * Pipe1) + (hours * Pipe2);//количество на водата

            if (water <= volume)
            {
               
                double waterFull = Math.Truncate(water /volume *  100);                
                double totalpipe1 = Math.Truncate(Pipe1 * hours / water * 100);
                double totalpipe2= Math.Truncate(Pipe2 * hours / water * 100);
                Console.WriteLine($"The pool is {waterFull}% full. pipe1: {totalpipe1}%. pipe2: {totalpipe2}%".);
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",hours , water - volume);
            }
        }
    }
}
