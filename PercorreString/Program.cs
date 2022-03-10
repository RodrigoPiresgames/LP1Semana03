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
            string str = Console.ReadLine();
            char remove = char.Parse(str);
            
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
