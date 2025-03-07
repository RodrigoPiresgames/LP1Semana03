using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Gimme words");
            string words = Console.ReadLine();
            Console.WriteLine("Gimme char");
            string toremove = Console.ReadLine();
            char removechar = Convert.ToChar(toremove);

            foreach (char c in words)
            {
                if (removechar == c)
                    continue;
                else
                    Console.Write($"{c}");
            }
        }
    }
}
