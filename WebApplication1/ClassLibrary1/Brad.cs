using System;

namespace Bradapp
{
    public class Brad
    {
        public int[,] MatriceBrad2(int x, int[,] a, int y)
        {
            int l = 0;
            for (int i = x + 1; i >= 2; i--)
                l = l + i;
            l = l + 2;
            int c = 2 * x + 1;

            int b = 0;
            for (int i = l - 2; i >= l - 2 - (x + 1); i--)
            {
                for (int j = 1 + b; j <= c - b; j++)
                    a[i, j + (y - x)] = 1;
                b++;
            }
            return a;
        }
    }
}

