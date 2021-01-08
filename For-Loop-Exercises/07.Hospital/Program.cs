using System;

namespace _07.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            

            int counttreatedPacients = 0;
            int untreadetPacient = 0;
            int doctors = 7;


            for(int days = 1;days <= period; days++)
            {
                int countPacients = int.Parse(Console.ReadLine());
                if ((days % 3 == 0) && (untreadetPacient > counttreatedPacients))
                {
                    doctors++;
                }

                if(countPacients > doctors)
                {
                    counttreatedPacients += doctors;
                    untreadetPacient += countPacients - doctors;
                }
                else
                {
                    counttreatedPacients += countPacients;
                }
            }
            Console.WriteLine($"Treated patients: {counttreatedPacients}.");
            Console.WriteLine($"Untreated patients: {untreadetPacient}.");
        }
    }
}
