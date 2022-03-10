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
            string str = Console.ReadLine();
            float x = float.Parse(str);

            Console.WriteLine("Gibe vertical");
            str = Console.ReadLine();
            float y = float.Parse(str);

            float [,] array = new float [x,y];
            
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Gibe num");
                    str = Console.ReadLine();
                    float num = float.Parse(str);

                    array[i,j] = num;
                    soma += num;
                }
                somadamedia += soma/array.GetLength(1);
                Console.WriteLine($"Media da linha = {soma/array.GetLength(1)}");
                soma = 0;
            }

            Console.WriteLine($"Soma das medias = {somadamedia}");

        }
    }
}
