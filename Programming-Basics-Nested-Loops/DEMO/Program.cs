using System;
using System.Runtime.InteropServices;

namespace DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            int totalTickets = 0;
            int standardTickets = 0;
            int studentsTickets = 0;
            int kidTickets = 0;


            while(movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                string tickets = Console.ReadLine();
                int currentTickets = 0;
               

                while(tickets != "End")
                {
                    switch (tickets)
                    {
                        case "standard":
                            standardTickets++;
                            break;
                        case "student":
                            studentsTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                    }
                    currentTickets++;

                    if(currentTickets == availableSeats)
                    {
                        break;
                    }
                    tickets = Console.ReadLine();
                    
                }
                totalTickets += currentTickets;

                double seatsTaken = currentTickets * 1.0 / availableSeats * 100;
                Console.WriteLine($"{movie} - {seatsTaken:f2}% full.");
                movie = Console.ReadLine();
                
            }
            double standardTicketsPercent = standardTickets * 1.0 / totalTickets * 100;
            double studentTicketsPercent = studentsTickets * 1.0 / totalTickets * 100;
            double kidTicketsPercent = kidTickets * 1.0 / totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTicketsPercent:f2}% student tickets.");
            Console.WriteLine($"{standardTicketsPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsPercent:f2}% kids tickets.");
        }
    }
}
