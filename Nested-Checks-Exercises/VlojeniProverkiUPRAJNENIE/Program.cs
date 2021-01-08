using System;

namespace VlojeniProverkiUPRAJNENIE
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            //            10 <= градуси <= 18 Outfit = Sweatshirt
            //Shoes = Sneakers    Outfit = Shirt
            //Shoes = Moccasins   Outfit = Shirt
            //Shoes = Moccasins
            //18 < градуси <= 24  Outfit = Shirt
            //Shoes = Moccasins   Outfit = T - Shirt
            //Shoes = Sandals Outfit = Shirt
            //Shoes = Moccasins
            //градуси >= 25   Outfit = T - Shirt
            //Shoes = Sandals Outfit = Swim Suit
            //Shoes = Barefoot    Outfit = Shirt
            //Shoes = Moccasins


            switch (dayTime)
            {
                case "Morning":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (degrees >= 10 && degrees <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";


                    }
                    else if (degrees >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;

                case "Afternoon":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees >= 10 && degrees <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";


                    }
                    else if (degrees >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;

                case "Evening":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees >= 10 && degrees <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";


                    }
                    else if (degrees >= 25)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }

                    break;
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
