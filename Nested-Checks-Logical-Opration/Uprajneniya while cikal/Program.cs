using System;

namespace Uprajneniya_while_cikal
{
    class Program
    {
        static void Main(string[] args)
        {

            string searcheBook = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int counterCheckBooks = 0;

            while(capacity > 0)
            {
                string takenBook = Console.ReadLine();
                capacity--;
              
                if(searcheBook == takenBook)
                {
                    Console.WriteLine($"You checked {counterCheckBooks} books and found it.");
                    break;
                }
                else
                {
                    counterCheckBooks++;
                    capacity--;
                }
            }
            if(capacity == 0)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counterCheckBooks} books.");
            }
            
        }
    }
}
