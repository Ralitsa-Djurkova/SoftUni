using System;

namespace _2._2Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPacients = 0;
            int untreatedPacients = 0;

            for (int day = 1; day <= period; day++)
            {
                int countPacients = int.Parse(Console.ReadLine());


                if ((day % 3 == 0) && (untreatedPacients > treatedPacients))
                {
                    doctors++;
                }
                if(countPacients > doctors)
                {
                    treatedPacients += doctors;
                    untreatedPacients += countPacients - doctors;
                }
                else
                {
                    treatedPacients += countPacients;
                }

            }
            Console.WriteLine($"Treated patients: {treatedPacients}.");
            Console.WriteLine($"Untreated patients: {untreatedPacients}.");
        }
    }
}
