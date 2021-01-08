using System;

namespace _02_Podgotovka_za_izpit
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPoorGrades = int.Parse(Console.ReadLine());

            string task = Console.ReadLine();

            int countPoorGrade = 0;
            int countTasks = 0;
            int sumGrades = 0;
            string lastTask = "";
           

            while (task != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                sumGrades += grade;
                countTasks++;

                if(grade <= 4)
                {
                    countPoorGrade++;
                }
                if(countPoorGrade == maxPoorGrades)
                {
                    Console.WriteLine($"You need a break, {countPoorGrade} poor grades.");
                    break;
                }
                lastTask = task;
                task = Console.ReadLine();

            }
            if (task == "Enough")
            {
                double avarege = sumGrades * 1.0 / countTasks;
                Console.WriteLine($"Average score: {avarege:f2}");
                Console.WriteLine($"Number of problems: {countTasks}");
                Console.WriteLine($"Last problem: {lastTask}");

            }


        }
    }
}
