using System;

namespace PotokOtBukwi
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            string command = "";
            string symbol = "";
            string letter = "c";
            string letter1 = "0";
            string letter2 = "n";

            while(command != "End")
            {
                if(symbol != letters)
                {
                    break;
                }
                if(letter == "c")
                {
                    Console.ReadLine("c");
                   
                }
                if(letter1 == "o")
                {
                    Console.WriteLine("o");
                }
                if(letter2 == "n")
                {
                    Console.WriteLine("n");
                }
            }
        }
    }
}
