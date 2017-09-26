using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Cate ramuri are bradul?\n");
            n = int.Parse(Console.ReadLine());
            int l = 0;
            for (int i = n + 1; i >= 2; i--)
                l = l + i;
            l = l + 2;
            int c = 2 * n + 1;//linii coloane

            int[,] a = new int[l + 1, c + 1];
            for (int i = 1; i <= l; i++)
                for (int j = 1; j <= c; j++)
                    a[i, j] = 0;//initializare matrice

            brad br = new brad();
            for (int i = 1; i <= n; i++)
                a = br.MatriceBrad(i, a, n);
            a[l - 1, n + 1] = 1; a[l, n + 1] = 1;//trunchi


            for (int i = 1; i <= l; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    Console.Write(a[i, j]);//afisare
                }
                Console.WriteLine();
            }





            Console.Read();
        }
    }
}