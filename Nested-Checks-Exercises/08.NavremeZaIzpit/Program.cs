
using System;

namespace _08.NavremeZaIzpit
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());

            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            string status = "";
            int hour = 0;
            int min = 0;

            if (examHour < arrivalHour)
            {
                status = "Late";
                int minutesDiff = 60 - examMinutes + arrivalMinutes;

                hour = minutesDiff / 60;
                min = minutesDiff % 60;

            }
            else if (examHour == arrivalHour)
            {
                if (arrivalMinutes > examMinutes)
                {
                    status = "Late";
                    min = arrivalMinutes - examMinutes;
                }
                else if (examMinutes - arrivalMinutes <= 30)
                {
                    status = "On time";
                    min = examMinutes - arrivalMinutes;
                }
            }
            else if (examHour - arrivalHour == 1)
            {
                int minutesDiff = 60 - arrivalMinutes + examMinutes;

                if (minutesDiff <= 30)
                {
                    status = "On time";
                    min = minutesDiff;
                }
                else
                {
                    status = "Early";
                    min = minutesDiff;
                }
            }
            else if (examHour - arrivalHour > 1)
            {
                status = "Early";
                int minDiff = (examHour * 60 + examMinutes) - ((arrivalHour * 60) + arrivalMinutes);
                hour = minDiff / 60;
                min = minDiff % 60;

            }
            string beforOrAfter = "";

            if (status == "Late")
            {
                beforOrAfter = "after";
            }
            else if (status == "On time" || status == "Early")
            {
                beforOrAfter = "before";
            }
            if(min >= 60)
            {
                hour++;
                min -= 60;
            }

            Console.WriteLine(status);
            if (hour > 0)
            {
                if (min > 9)
                {
                    Console.WriteLine($"{hour}:{min} hours {beforOrAfter} the start");
                }
                else if (min < 10)
                {
                    Console.WriteLine($"{hour}:0{min} hours {beforOrAfter} the start");
                }
            }
            else if (hour == 0 && min > 0)
            {
                Console.WriteLine($"{min} minutes {beforOrAfter} the start");
            }


        }




    }
}

