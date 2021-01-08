using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumNeedet = double.Parse(Console.ReadLine());

            double totalCurrentSum = 0;
            double currentByCard = 0;
            double currentByCash = 0;
            int numOfPayment = 0;
            int numOfPaymentByCard = 0;
            int numOfPaymentByCash = 0;

            string payment = Console.ReadLine();
            while(payment != "End")
            {
                double product = double.Parse(payment);
                if(product %2 != 0)
                {
                    if(product > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    if(product < 100)
                    {
                        Console.WriteLine("Product sold!");
                        currentByCash += product;
                        numOfPayment++;
                    }
                }
                else
                {
                    if(product < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    if(product > 10)
                    {
                        Console.WriteLine("Product sold!");
                        currentByCard += product;
                        numOfPayment++;
                    }
                }
                totalCurrentSum = currentByCard + currentByCash;
                if(sumNeedet <= totalCurrentSum)
                {
                    Console.WriteLine($"Average CS: {currentByCash / numOfPaymentByCash:f2}");
                    Console.WriteLine($"Average CC: {currentByCard / numOfPaymentByCard:f2}");
                    break;
                }
            }
            if(payment == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
              
                
            
            
        }
    }
}
