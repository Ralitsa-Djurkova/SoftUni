using System;

namespace _03.Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            string outFit = "";
            string shoes = "";

            if (degree >= 10 && degree <= 18)
            {
                if (dayTime == "Morning")
                {
                    outFit = "Sweatshirt";
                    shoes =  "Sneakers";
                }
                else if(dayTime == "Afternoon" || dayTime == "Evening")
                {
                    outFit = "Shirt";
                    shoes = "Moccasins";
                }
                
                Console.WriteLine($"It's {degree} degrees, get your {outFit} and {shoes}.");
            }
            if (degree > 18 && degree <= 24)
                
            {
                if (dayTime == "Morning" || dayTime == "Evening")
                {
                   
                    outFit = "Shirt";
                    shoes = "Moccasins";
                   
                }
                else if(dayTime == "Afternoon")
                {
                    outFit ="T-Shirt";
                    shoes ="Sandals";
                }
                
                Console.WriteLine($"It's {degree} degrees, get your {outFit} and {shoes}.");
            }
                    
                if(degree >= 25)
            {
                if(dayTime == "Morning")
                {
                    outFit = "T - Shirt";
                    shoes = "Sandals";
                }
                else if(dayTime == "Afternoon")
                {
                    outFit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if(dayTime == "Evening")
                {
                    outFit = "Shirt";
                    shoes = "Moccasins";
                }
                Console.WriteLine($"It's {degree} degrees, get your {outFit} and {shoes}.");
            }
            

            

                
                
            
        }
    }
}
