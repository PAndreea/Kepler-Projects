using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex5
    {
        public static void exercitiu()
        {
            int correctNumber = new Random().Next(3) + 1;
            int guessedNumber;
            Console.Write("Alege un numar intre 1 si 3\n");
            guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber < 1)
                Console.WriteLine("Numarul ales este prea mic.");
            else if (guessedNumber == correctNumber)
                Console.WriteLine("Ai ghicit!");
            else if (guessedNumber > 3) Console.WriteLine("Numarul ales este prea mare");
            else Console.WriteLine("Nu ai ghicit numarul!");
             Console.ReadLine();
        }
    }
}
