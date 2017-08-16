using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex8
    {
        public static void exercitiu()
        {
            for(int i=1;i<=4;i++)
            {
                for (int j = 0; j <= 24; j += i)
                    Console.Write($" {j} ");
                Console.WriteLine();

            }
            Console.Read();
        }
    }
}
