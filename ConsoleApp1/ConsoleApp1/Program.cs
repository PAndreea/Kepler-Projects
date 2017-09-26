using System;

namespace ConsoleApp1
{
    
    class Program
    {
        public static void Main(string[] args)
        {
            Brad br = new Brad();
            int ramuri = 4;
            br.brad(ramuri);
            for (int i = 1; i <= ramuri; i++)
                Console.Write(" ");
            Console.Write("*\n");
            for (int i = 1; i <= ramuri; i++)
                Console.Write(" ");
            Console.Write("*\n");

            Console.ReadLine();



        }
    }
}
