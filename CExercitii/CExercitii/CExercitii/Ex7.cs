using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex7
    {

        public static void exercitiu()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Factors: ");
            while (number > 1) 
            {
                int candidateFactor = 2;
                while (candidateFactor <= number) 
                {
                    if (number % candidateFactor == 0) // found a factor
                    {
                        Console.Write(candidateFactor);
                        Console.Write(" ");
                        number = number / candidateFactor;
                    }
                    candidateFactor++;
                }
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
