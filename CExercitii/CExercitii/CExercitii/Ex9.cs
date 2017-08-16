using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex9
    {
        public static List<string> exercitiu(string text, string text2, List<string> colors)
        {

            if(colors[0]=="")
                colors = new List<string>();

            if (text == "+")
            {
                colors.Add(text2);
            }
            else if (text == "-")
            {
                if (colors.Any())
                    colors.Remove(text2);
            }
            else if (text == "--")
            {
                colors.Clear();
            }

            return colors;

        }
    }
}
