using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex4
    {
        public static void exercitiu()
        {
            var someDate = new DateTime(1995, 3, 21);
            TimeSpan duration = DateTime.Today- someDate;
            Console.WriteLine($"Persoana are {duration.TotalDays} zile.");
            var daysToNextAnniversary = 10000 - (duration.TotalDays % 10000);
            Console.WriteLine($"Zile pana la urmatoarea aniversare: {daysToNextAnniversary} ");
            Console.ReadLine();
        }
    }
}
