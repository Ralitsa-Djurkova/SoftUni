using System;

namespace _06.OperationNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operatorr = Console.ReadLine();

            string printResult = "";
            double result = 0.0;

            switch (operatorr)
            {
                case "+":
                    result = N1 + N2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {operatorr} { N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {operatorr} { N2} = {result} - odd");
                    }
                    break;
                case "-":
                    result = N1 - N2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {operatorr} { N2} = {result} - even");

                    }
                    else
                    {
                        Console.WriteLine($"{N1} {operatorr} { N2} = {result} - odd");
                    }
                    break;
                case "*":
                    result = N1 * N2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {operatorr} { N2} = {result} - even");
                    }
                    else
                    {

                        Console.WriteLine($"{N1} {operatorr} { N2} = {result} - odd");
                    }
                    break;
                case "/":
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                        
                    }
                    else
                    {
                        result = (double)N1 / N2;
                        Console.WriteLine($"{N1} / {N2} = {result:f2}");
                    }
                    break;
                case "%":
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        result = N1 % N2;
                        Console.WriteLine($"{N1} % {N2} = {result}");
                    }
                    break;
            }
        }
    }
}
