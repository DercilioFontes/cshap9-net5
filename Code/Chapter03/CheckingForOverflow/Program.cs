﻿using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     checked
            //     {
            //         int x = int.MaxValue - 1;
            //         WriteLine($"Initial value: {x}");
            //         x++;
            //         WriteLine($"After incrementing: {x}");
            //         x++;
            //         WriteLine($"After incrementing: {x}");
            //         x++;
            //         WriteLine($"After incrementing: {x}");
            //     }
            // }
            // catch (OverflowException)
            // {
            //     WriteLine("The code overflowed but I caught the exception.");
            // }

            // unchecked
            // {
            //     int y = int.MaxValue + 1;
            //     WriteLine($"Initial value: {y}");
            //     y--;
            //     WriteLine($"After decrementing: {y}");
            //     y--;
            //     WriteLine($"After decrementing: {y}");

            // }

            // int zero = 0;
            // // int x = 6 / zero;
            // double y = 6.0 / zero;
            // WriteLine(y);


            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                WriteLine(i);
            }

        }
    }
}
