using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string mount = Console.ReadLine();
            int countNight = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double apartmentPrice = 0.0;

            if(mount == "May" || mount == "October")
            {
                studioPrice = countNight * 50;
                apartmentPrice = countNight * 65;
                if (countNight <= 7 || countNight < 14)
                {
                    studioPrice = studioPrice * 0.95;
                }
                else if(countNight <= 7 || countNight < 14)
                {
                    apartmentPrice = apartmentPrice * 0.90;
                }
                if (countNight > 14)
                {

                    studioPrice = studioPrice * 0.70;
                }
                if (countNight > 14)
                {
                    apartmentPrice = apartmentPrice * 0.90;
                }
            }
            else if (mount == "June" || mount == "September")
            {
                studioPrice = countNight * 75.20;
                apartmentPrice = countNight * 68.70;
                if (countNight > 14)
                {
                    studioPrice = studioPrice * 0.80;
                }
                if (countNight > 14)
                {
                    apartmentPrice = apartmentPrice * 0.90;
                }
            }
            else if (mount == "July" || mount == "August")
            {
                studioPrice = countNight * 76;
                apartmentPrice = countNight * 77;
                if (countNight > 14)
                {
                    apartmentPrice = apartmentPrice * 0.90;
                }
            }

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
