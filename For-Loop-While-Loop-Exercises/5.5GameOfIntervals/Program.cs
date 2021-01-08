using System;

namespace _5._5GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            double points = 0.0;
         
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            int counter6 = 0;


            for (int i = 1; i <= moves; i++)
            {
                double pointsGame = double.Parse(Console.ReadLine());

                if(pointsGame >= 0 && pointsGame <= 9)
                {
                    counter1++;
                    points += pointsGame * 0.2;
                    
                }
                else if(pointsGame >= 10 && pointsGame <= 19)
                {
                    counter2++;
                   points += pointsGame * 0.3;
                   
                }
                else if(pointsGame >= 20 && pointsGame <= 29)
                {
                    counter3++;
                   points += pointsGame * 0.4;
                   
                }
                else if(pointsGame >= 30 && pointsGame <= 39)
                {
                    counter4++;
                   points += 50;
                }
                else if(pointsGame >= 40 && pointsGame <= 50)
                {
                    counter5++;
                    points += 100;
                }
                else
                {
                    counter6++;
                    points = points / 2;
                }
                
            }
            double percent1 = ((double)counter1 / (double)moves) * 100;
            double percent2 = ((double)counter2 / (double)moves) * 100;
            double percent3 = ((double)counter3 / (double)moves) * 100;
            double percent4 = ((double)counter4 / (double)moves) * 100;
            double percent5 = ((double)counter5 / (double)moves) * 100;
            double percent6 = ((double)counter6 / (double)moves) * 100;
            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {percent1:f2}%");
            Console.WriteLine($"From 10 to 19: {percent2:f2}%");
            Console.WriteLine($"From 20 to 29: {percent3:f2}%");
            Console.WriteLine($"From 30 to 39: {percent4:f2}%");
            Console.WriteLine($"From 40 to 50: {percent5:f2}%");
            Console.WriteLine($"Invalid numbers: {percent6:f2}%");
        }
    }
}
