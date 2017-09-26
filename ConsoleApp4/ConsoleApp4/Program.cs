using System;

namespace ConsoleApp4
{
    class Program
    {
        static void stea(int a)
        {
            if (a == 1)
                Console.Write("*");
            else
            {
                stea(a - 1);
                Console.Write("*");
                Console.Write("*");
            }
        }
        static void triunghi(int x, int y)
        {
            for (int i = 1; i <= x; i++)
            { 
                for (int j = x; j > i; j--)
                    Console.Write(" ");
            for (int c = 1; c <= (y + 1 -x); c++)
                Console.Write(" ");
            stea(i);
            Console.WriteLine();
            }
        }

        static void brad(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                triunghi(i + 1, x);
            }

        }
        static void Main(string[] args)
        {
            int ramuri;
            Console.Write("Cate ramuri are bradul?\n");
            ramuri = int.Parse(Console.ReadLine());
            brad(ramuri);
            for (int i = 1; i <= ramuri; i++)
                Console.Write(" ");
            Console.WriteLine("*");
            for (int i = 1; i <= ramuri; i++)
                Console.Write(" ");
            Console.WriteLine("*");
            Console.ReadLine();
        }
    }
}
