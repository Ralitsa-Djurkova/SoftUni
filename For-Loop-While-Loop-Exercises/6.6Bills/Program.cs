using System;

namespace _6._6Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double waterBill = 0.0;
            double internetBill = 0.0;
            double otherBill = 0.0;

            double tok = 0.0;
            double other = 0.0;
            
            for (int i = 1; i <= months; i++)
            {
                double billTok = double.Parse(Console.ReadLine());
                tok += billTok;
                waterBill = i * 20;
                internetBill = i * 15;
                otherBill = (billTok + 20 + 15) + (billTok + 20 + 15) * 0.2;
                other += otherBill;
            }
            double average = (tok + waterBill + internetBill + other) / months;

            Console.WriteLine($"Electricity: {tok:f2} lv");
            Console.WriteLine($"Water: {waterBill:f2} lv");
            Console.WriteLine($"Internet: {internetBill:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
