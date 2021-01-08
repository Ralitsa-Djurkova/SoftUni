using Microsoft.VisualBasic.CompilerServices;
using System;

namespace NestetLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLatter =char.Parse(Console.ReadLine());
            char endLatter = char.Parse(Console.ReadLine());
            char latter =char.Parse(Console.ReadLine());

            int sum = 0;
            for (char i = startLatter; i <= endLatter; i++)
            {
                if(i != latter)
                {
                    for (char j = startLatter;j <= endLatter; j++)
                    {
                        if(j != latter)
                        {
                            for (char k = startLatter; k <= endLatter; k++)
                            {
                                if(k != latter )
                                {
                                    Console.Write($"{i}{j}{k} ");
                                    sum++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
