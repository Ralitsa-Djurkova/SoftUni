﻿using System;

namespace Uprajneniq_za_Proverki
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit =Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;
            
            if (day == "Monday" || day == "thuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana") price = 2.70;
                else if (fruit == "apple") price = 1.20;
                else if (fruit == "orandge") price = 0.85;
                else if (fruit == "grapefruit") price = 1.45;
                else if (fruit == "kiwi") price =  5.12;
                else if (fruit == "pineapple") price = 5.50;
                else if (fruit == "grapes") price = 3.85;
                
            }
            else if(day == "sunnday" || day == "saturday")
            {
                if (fruit == "banana") price = 2.70;
                else if (fruit == "apple") price = 1.25;
                else if (fruit == "orange") price = 0.90;
                else if (fruit == "grapefruit") price = 1.60;
                else if (fruit == "kiwi") price = 3.00;
                else if (fruit == "pineapple") price = 5.60;
                else if (fruit == "greaps") price = 4.20;
                                  
            }
            double totalPrice = quantity * price;
            Console.WriteLine(totalPrice);

        }
    }
}
