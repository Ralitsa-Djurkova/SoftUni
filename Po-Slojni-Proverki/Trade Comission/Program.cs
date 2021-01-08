﻿using System;

namespace Trade_Comission
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comission = -1.0;

            if(town == "Sofia")
            {
                if(sales >=0 && sales <= 500)
                {
                    comission = 0.05;
                }
                else if(sales >= 500 && sales <= 1000)
                {
                    comission = 0.07;
                }
                else if(sales >= 1000 && sales <= 10000)
                {
                    comission = 0.08;
                }
                else if(sales >= 10000)
                {
                    comission = 0.12;
                }
            }
            else if(town == "Varna")
            {

                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.045;
                }
                else if (sales >= 500 && sales <= 1000)
                {
                    comission = 0.075;
                }
                else if (sales >= 1000 && sales <= 10000)
                {
                    comission = 0.10;
                }
                else if (sales >= 10000)
                {
                    comission = 0.13;
                }
            }
            else if(town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.055;
                }
                else if (sales >= 500 && sales <= 1000)
                {
                    comission = 0.08;
                }
                else if (sales >= 1000 && sales <= 10000)
                {
                    comission = 0.12;
                }
                else if (sales >= 10000)
                {
                    comission = 0.145;
                }
            }
            if(comission >= 0)
            {
                Console.WriteLine("{0:f2}" , sales * comission);
            }
            else
            {
                Console.WriteLine("error");
            }

            
        }    
    }
}
