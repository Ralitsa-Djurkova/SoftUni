using System;

namespace _07.TicketsForCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            int totalTickets = 0;
            int standardTickets = 0;
            int studentTickets = 0;
            int kidTickets = 0;

            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                string ticket = Console.ReadLine();
                int currentTickets = 0;

                while(ticket != "End")
                {
                    switch (ticket)
                    {
                        case "standard":
                            standardTickets++;
                            break;
                        case "student":
                            studentTickets++;
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
                    ticket = Console.ReadLine();
                }
                totalTickets += currentTickets;

                double seatsTaken = currentTickets * 1.0 / availableSeats * 100;
                Console.WriteLine($"{movie} - {seatsTaken}% full.");
                movie = Console.ReadLine();
            }
            double standardTicketsPercent = standardTickets * 1.0 / totalTickets * 100;
            double studentTicketsPercent = studentTickets * 1.0 / totalTickets * 100;
            double kidTicketsPercent = kidTickets * 1.0 / totalTickets * 100;


            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTicketsPercent:f2}% student tickets.");
            Console.WriteLine($"{standardTicketsPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsPercent:f2}% kids tickets.");
        }
    }
}
