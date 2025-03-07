using System;

namespace RightSide
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach(string arg in args)
            {
                if (arg.Length > 3)
                {
                    if(arg.Length >= 8)
                    {
                        Console.WriteLine("[EARLY STOP]");
                        break;
                    }

                    Console.WriteLine($"{arg}");

                }
            }
        }
    }
}
