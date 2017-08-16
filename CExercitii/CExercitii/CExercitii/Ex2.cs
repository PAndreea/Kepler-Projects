using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex2
    {
        public static void afiseaza()
        {
            Console.WriteLine(message());
            Console.ReadLine();
        }

        public static string message()
        {
            var name = "Steve";
            var prop = "Hei,John!";
            return $"Hello {name}!\n" + $"{prop} How are you?";
        }
    }
}
