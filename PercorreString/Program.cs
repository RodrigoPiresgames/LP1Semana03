using System;

namespace NomeDoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gibe string");
            string old = Console.ReadLine();
            Console.WriteLine("Gibe caracter");
            char remove = Console.ReadLine();
            
            for (int i = 0; i < old.Length; i++)
            {
                if (old[i] == remove)
                {
                
                }
                else
                {
                Console.Write($"{old[i]}");
                }
            }

        }
    }
}
