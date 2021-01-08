using System;

namespace _06.Journy
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seson = Console.ReadLine();

            string destination = "";
            string placeToStay = "";
            double price = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (seson == "summer")
                {
                    placeToStay = "Camp";
                    price = budget * 0.30;

                }
                else if (seson == "winter")
                {
                    placeToStay = "Hotel";
                    price = budget * 0.70;

                }

            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (seson == "summer")
                {
                    placeToStay = "Camp";
                    price = budget * 0.40;
                }
                else if (seson == "winter")
                {
                    placeToStay = "Hotel";
                    price = budget * 0.80;
                }
            }
            else
            {
                destination = "Europe";
                placeToStay = "Hotel";
                price = budget * 0.90;
            }
            
                
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToStay} - {price:F2}");


            
        }

    }
}

        
    

