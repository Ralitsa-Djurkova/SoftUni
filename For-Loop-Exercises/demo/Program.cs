using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int treatedPatients = 0;
            int untreadetPatient = 0;
            int countDoctors = 7;

            for(int days = 1; days <= period; days++)
            {
                int currentPtient = int.Parse(Console.ReadLine());

                if(days % 3 == 0 && treatedPatients < untreadetPatient)
                {
                    countDoctors++;
                }
                if(currentPtient > countDoctors)
                {
                    treatedPatients += countDoctors;
                    untreadetPatient += currentPtient - countDoctors;
                }
                else
                {
                    treatedPatients += currentPtient;
                }

            }
            Console.WriteLine($"{treatedPatients}");
            Console.WriteLine($"{untreadetPatient}");
        }
    }
}
