using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace _08.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int overnight = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month =="May" || month =="October")
            { 
              studioPrice = overnight * 50;
                apartmentPrice = overnight * 65;
                if (overnight < 7 && overnight <= 14)
                {
                    studioPrice = studioPrice * 0.95;   
                }
                 if (overnight > 14)
                {
                    studioPrice = studioPrice * 0.70;  
                }
                 if(overnight > 14)
                {
                    apartmentPrice = apartmentPrice * 0.90;
                }
            }
             else if (month =="June" || month =="September")
            {
                studioPrice = overnight * 75.20;
                apartmentPrice = overnight * 68.70;
                if (overnight > 14)
                { 
                    apartmentPrice = apartmentPrice * 0.90;
                }
            }
            else if (month =="July" || month =="August")
            {
                studioPrice = overnight * 76;
                apartmentPrice = overnight * 77;
                if (overnight > 14)
                {
                    apartmentPrice = apartmentPrice * 0.90;
                }

            }
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");


        }
    }
}


