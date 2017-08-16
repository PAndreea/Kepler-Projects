using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex3
    {
        public static void exercitiu()
        {
            string var3 = Console.ReadLine();
            Console.WriteLine(message(var3));
         
            Console.ReadLine();
        }
        public static string message(string text)
        {
            string one = "Hello ";
            string two = "Martha!";
            string combined = one + two;
            
            if (text == "loud")
            {
                combined = combined.ToUpper();
                
            }
            else if (text == "quiet")
            {
                combined = combined.ToLower();
                
            }
            return combined;
        }
    }
}
