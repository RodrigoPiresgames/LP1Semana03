using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme lengh");
            string str = Console.ReadLine();
            int l = Convert.ToInt16(str);
            Console.WriteLine("Gimme height");
            str = Console.ReadLine();
            int h = Convert.ToInt16(str);

            int num;

            int[,] matrix = new int[l, h];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"Gimme num for place {i}, {j}");
                    str = Console.ReadLine();
                    num = Convert.ToInt16(str);

                    matrix[i, j] = num;

                }
            }

        }
    }
}
