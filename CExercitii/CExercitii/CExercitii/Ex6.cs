using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex6
    {
        //public static void exercitiu()
        //{
        //    var currentTime = DateTime.Now;
        //    int hour = currentTime.Hour;
        //    Console.WriteLine(hour);
        //    if ((hour >= 6) && (hour <= 10))
        //        Console.WriteLine("Good Morning");
        //    if ((hour >= 11) && (hour <= 19))
        //        Console.WriteLine("Good Afternoon");
        //    if ((hour >= 20) && (hour <= 22))
        //        Console.WriteLine("Good Evening");
        //    if (((hour >= 22) && (hour <= 23))||((hour>=0)&&(hour<=5)))
        //        Console.WriteLine("Good Night");
        //    Console.ReadLine();

        //}

        public static string message(string hour)
        {
            var hour2 = int.Parse(hour);
            if ((hour2 >= 6) && (hour2 <= 10))
               return "Good Morning";
            if ((hour2 >= 11) && (hour2 <= 19))
                return "Good Afternoon";
            if ((hour2 >= 20) && (hour2 <= 22))
                return "Good Evening";
            if (((hour2 >= 22) && (hour2 <= 23)) || ((hour2 >= 0) && (hour2 <= 5)))
                return "Good Night";
            return "Ora invalida.";
        }
    }
}
