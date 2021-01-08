using System;

namespace _08.Ocenka
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudent = int.Parse(Console.ReadLine());

            double numberOfFiledStudents = 0.0;
            double numberOFAverageStudents = 0.0;
            double numberOfGoodStudents = 0.0;
            double numberOfExellentsStudents = 0.0;
            double totalResult = 0.0;

            for(int i = 0; i < countStudent; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                totalResult += grade / countStudent;
                if(grade < 3)
                {
                    numberOfFiledStudents++;
                    
                }
                else if(grade >=3 && grade < 3.99)
                {
                    numberOFAverageStudents++;
                }
                else if(grade >= 4.00 && grade < 4.99)
                {
                    numberOfGoodStudents++;
                }
                else if(grade >= 5.00)
                {
                    numberOfExellentsStudents++;
                }
                
            }
            double totalStudentFiled = numberOfFiledStudents * 100 / countStudent; 
            double totalStudentAverage = numberOFAverageStudents * 100 / countStudent; 
            double totalStudentsGood = numberOfGoodStudents * 100 / countStudent; 
            double totalStudentsExellent = numberOfExellentsStudents * 100 / countStudent;
            

            Console.WriteLine($"Top students: {totalStudentsExellent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {totalStudentsGood:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {totalStudentAverage:f2}%");
            Console.WriteLine($"Fail: {totalStudentFiled:f2}%");
            Console.WriteLine($"Average: {totalResult:f2}");
        }
    }
}
