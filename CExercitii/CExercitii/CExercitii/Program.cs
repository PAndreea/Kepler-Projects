using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("1: Exercitiul 1");
            Console.WriteLine("2: Exercitiul 2");
            Console.WriteLine("3: Exercitiul 3");
            Console.WriteLine("4: Exercitiul 4");
            Console.WriteLine("5: Exercitiul 5");
            Console.WriteLine("6: Exercitiul 6");
            Console.WriteLine("7: Exercitiul 7");
            Console.WriteLine("8: Exercitiul 8");
            Console.WriteLine("9: Exercitiul 9");
            Console.WriteLine("10: Exercitiul 10");
            Console.WriteLine("11: Exercitiul 11");
            Console.WriteLine("12 Exercitiul 12");
            Console.WriteLine("13: Exercitiul 13");
            Console.WriteLine("14: Exercitiul 14");
            Console.WriteLine("15: Exercitiul 15");
            Console.WriteLine("16: Exercitiul 16");
            c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Ex1.afiseaza();
                    break;
                case 2:
                    Ex2.afiseaza();
                    break;
                case 3:
                    Ex3.exercitiu();
                    break;
                case 4:
                    Ex4.exercitiu();
                    break;
                case 5:
                    Ex5.exercitiu();
                    break;
                case 6:
                    //Ex6.exercitiu();
                    break;
                case 7:
                    Ex7.exercitiu();
                    break;
                case 8:
                    Ex8.exercitiu();
                    break;
               case 9:
                    //Ex9.exercitiu();
                    break;
                case 10:
                    Ex10.exercitiu();
                    break;
                case 11:
                    Ex11 ex11 = new Ex11();
                    ex11.exercitiu();
                    break;
                case 12:
                    Ex12 ex12=new Ex12();
                    ex12.exercitiu();
                    break;
                case 13:
                    Ex13 ex13 = new Ex13();
                    ex13.exercitiu();
                    break;
                case 14:
                    Ex14 ex14 = new Ex14();
                    ex14.exercitiu();
                    break;
                case 15:
                    Ex15 ex15 = new Ex15();
                    ex15.exercitiu();
                    break;
                case 16:
                    Ex16 ex16 = new Ex16();
                    ex16.exercitiu();
                    break;
          


            }
        }
    }
}
