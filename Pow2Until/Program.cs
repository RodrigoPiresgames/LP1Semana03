﻿using System;

namespace Pow2Until
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
        }

        private static void PowerOf2Until5()
        {
            for (int i = 1; i <= (1<<5); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
