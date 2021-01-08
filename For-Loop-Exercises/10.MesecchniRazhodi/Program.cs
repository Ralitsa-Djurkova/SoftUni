using System;

namespace _10.MesecchniRazhodi
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double waterBill = 20;
            double internetBill = 15;
            double otherBill = 0;

            double electricity = 0;
            double water = 0;
            double internet = 0;
            double other = 0;
            double average = 0;

            for (int i = 1; i <= months; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());

                electricity += electricityBill;
                water = waterBill * months;
                internet = internetBill * months;
                other = (electricityBill + internetBill + waterBill) * 1.2;
                otherBill += other;

                

            }
            average = (electricity + water + internet + otherBill) / months;
            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {otherBill:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
