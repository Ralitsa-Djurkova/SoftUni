using System;

namespace _1._1Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favriteBook = Console.ReadLine();
            int counterBook = int.Parse(Console.ReadLine());
            int searchBook = 0;

            while(counterBook > 0)
            {
                string takenBook = Console.ReadLine();

                if(favriteBook == takenBook)
                {
                    Console.WriteLine($"You checked {searchBook} books and found it.");
                    break;
                }
                else
                {
                   searchBook++;
                    counterBook--;
                }
            }
            if (counterBook == 0)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {searchBook} books.");
            }
        }
    }
}
