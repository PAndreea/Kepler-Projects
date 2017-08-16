using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex10
    {
        public static void exercitiu()
        {
            
            Console.Write(message());
          
            Console.ReadLine();
        }
        public static string message()
        {
            var lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            Console.WriteLine("Elementele listei:");
            foreach (var x in lista)
            {
                Console.Write(x);
                Console.Write(" ");
                sum += x;
            }
            return "\nSuma este: " + sum;
        }
    }
}
