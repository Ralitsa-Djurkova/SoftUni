using System;

namespace WhileLoopAndForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBottlePreparat = int.Parse(Console.ReadLine());

           int preparat = countBottlePreparat * 750;

            string command = Console.ReadLine();
            int counter = 0;
            int chinii = 0;
            int tengeri = 0;
            int preparatSadove = 0;
             

            while (command != "End")
            {
                if (command == "End")
                {
                    break;
                }
                int sadove = int.Parse(command);
                counter++;
                if (counter % 3 == 0)
                {
                    tengeri += sadove;
                    sadove *= 15;
                   preparat -= sadove;
                    preparatSadove = preparat;
                }
                else
                {
                    chinii += sadove;
                    sadove *= 5;
                    preparat -= sadove;
                    preparatSadove = preparat;
                }
                if(preparatSadove < 0)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if(preparatSadove >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{chinii} dishes and {tengeri} pots were washed.");
                Console.WriteLine($"Leftover detergent {preparatSadove} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(preparatSadove)} ml. more necessary!");
            }
           
            

        }
    }
}
