﻿using System;

namespace _9._9.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 23; i++)
            {
                for (int j = 0; j <= 59; j++)
                {
                    Console.WriteLine($"{i} : {j}");
                }
            }
        }
    }
}
