using System;
using System.Data;

namespace _2._1Podgotovka_za_izpit
{
    class Program
    {
        static void Main(string[] args)
        {

            int maxPoorGrades = int.Parse(Console.ReadLine());
            string nameTask = Console.ReadLine();
            int countPoorGrades = 0; 
            

            while (nameTask != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                if(grade <= 4)
                {
                    countPoorGrades++;
                }
                if(countPoorGrades == maxPoorGrades)
                {
                    Console.WriteLine($"You need );
                }
            }



        }

    }
}
