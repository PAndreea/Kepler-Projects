using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex11
    {
        List<string> colors = new List<string>() { "black", "white", "gray" };
        public  void exercitiu()
        {
            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                var x = Console.ReadLine();
                if (x == "+")
                    adaugaElement();

                else if (x == "-")
                    eliminaElement();

                else if (x == "--")
                    golesteLista();
                else Console.WriteLine("Alegere gresita.");
            }
        }

        public  void adaugaElement()
        {
                    Console.WriteLine("Adauga noul element din lista:");
                    var y = Console.ReadLine();
                    colors.Add(y);
                    colors.ForEach(Console.WriteLine);
        }
        public void eliminaElement()
        {
                    colors.ForEach(Console.WriteLine);
                    Console.WriteLine("Alege pozitia elementului pentru a fi sters:");
                    var z = int.Parse(Console.ReadLine());
                    colors.RemoveAt(z);
                    colors.ForEach(Console.WriteLine);
        }
        public void golesteLista()
        {
                    colors.ForEach(Console.WriteLine);
                    Console.WriteLine("Ai ales sa golesti lista:");
                    colors.Clear();
                    colors.ForEach(Console.WriteLine);

        }
    }
}
