using System;

namespace Week_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Mondey");
                    break;
                case 2:
                    Console.WriteLine("Thuesday");
                    break;
                case 3:
                    Console.WriteLine("Wendnesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Fraday");
                    break;
                case 6:
                    Console.WriteLine("Sunneday");
                    break;
                case 7:
                    Console.WriteLine("Sathurday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            
            

        }
    }
}
