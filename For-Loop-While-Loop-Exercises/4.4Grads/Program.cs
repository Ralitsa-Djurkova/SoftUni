using System;

namespace _4._4Grads
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudens = int.Parse(Console.ReadLine());
            int students1 = 0;
            int students2 = 0;
            int students3 = 0;
            int students4 = 0;
            double totalGrads = 0.0;


            for (int i = 1; i <= countStudens; i++)
            {
                double grads = double.Parse(Console.ReadLine());
                totalGrads += grads;
                if(grads >= 2.00 && grads <= 2.99)
                {
                    students1++;
                    
                }
                else if(grads >= 3.00 && grads <= 3.99)
                {
                    students2++;
                }
                else if(grads >= 4.00 && grads <= 4.99)
                {
                    students3++;
                }
                else if(grads >= 5.00)
                {
                    students4++;
                }
            }
            double averageGrades = totalGrads /(double) countStudens;
            double topStudents =(double)(students4 /(double)countStudens) * 100;
            double between1 =(double)(students3 /(double)countStudens) * 100;
            double between2 =(double)(students2 /(double)countStudens) * 100;
            double fail =(double)(students1 /(double)countStudens) * 100;

            Console.WriteLine($"Top students: {topStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between1:f2}% ");
            Console.WriteLine($"Between 3.00 and 3.99: {between2:f2}%");
            Console.WriteLine($"Fail: {fail:f2}%");
            Console.WriteLine($"Average: {averageGrades:f2}");
        }
    }
}
