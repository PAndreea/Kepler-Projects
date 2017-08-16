using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex15
    {
        public void exercitiu()
        {
            var people = GenerateListOfPeople();
            Console.WriteLine("Alege varsta pentru a afisa persoanele cu o vasta mai mare decat aceasta:");
            var varsta = int.Parse(Console.ReadLine());
            var people2 = people.Where(x => x.Age > varsta);
            foreach (var y in people2)
            {
                Console.WriteLine(y.FirstName);
            }

            Console.WriteLine("Alege numele pentru a afisa persoanele cu acest nume:");
            var nume = Console.ReadLine();
            var people3 = people.Where(x => x.LastName == nume);
            if (people3.Count()==0) Console.WriteLine("Numele nu se afla in lista.");
            else
            foreach (var y in people3)
            {
                Console.WriteLine(y.FirstName);
            }
            Console.ReadLine();
        }
        public static List<Person> GenerateListOfPeople()
        {
            var people = new List<Person>();

            people.Add(new Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24 });
            people.Add(new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 });
            people.Add(new Person { FirstName = "Brendan", LastName = "Enrick", Occupation = "Dev", Age = 30 });
            people.Add(new Person { FirstName = "Jane", LastName = "Doe", Occupation = "Dev", Age = 35 });
            people.Add(new Person { FirstName = "Sara", LastName = "Collins", Occupation = "Dev", Age = 24 });
            people.Add(new Person { FirstName = "Marta", LastName = "Jones", Occupation = "Manager", Age = 29 });
            people.Add(new Person { FirstName = "Jane", LastName = "Fleming", Occupation = "Dev", Age = 42 });
            people.Add(new Person { FirstName = "Alina", LastName = "Jones", Occupation = "Manager", Age = 21 });
            people.Add(new Person { FirstName = "Laura", LastName = "Smith", Occupation = "Dev", Age = 51 });

            return people;
        }
    

         public class Person
         {
             public string FirstName { get; set; }
             public string LastName { get; set; }
             public string Occupation { get; set; }
             public int Age { get; set; }
         }
    }
}
