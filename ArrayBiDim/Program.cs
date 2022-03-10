using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            float somadamedia = 0;
            float soma = 0;
            Console.WriteLine("Gibe horizontal");
            int x = Console.ReadLine();
            Console.WriteLine("Gibe vertical");
            int y = Console.ReadLine();

            float [,] array = new float [x,y];
            
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Gibe num");
                    float num = Console.ReadLine();
                    array[i,j] = num;
                    soma += num;
                }
                somadamedia += soma/array.GetLength(1)
                Console.WriteLine($"Media da linha e {soma/array.GetLength(1)}");
                soma = 0
            }


        }
    }
}
