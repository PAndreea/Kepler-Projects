using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Brad
    {

        public void stea(int a)
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
        public void triunghi(int x, int y)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = x; j > i; j--)
                    Console.Write(" ");
                for (int c = 1; c <= (y + 1 - x); c++)
                    Console.Write(" ");
                stea(i);
                Console.WriteLine();
            }
        }
        public void brad(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                triunghi(i + 1, x);
            }
        }
    }
}
