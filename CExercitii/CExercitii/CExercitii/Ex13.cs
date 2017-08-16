using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex13
    {
        public void exercitiu()
        {
            var jimmy = new Student("Jimmy", "Jones", new DateTime(1990, 3, 15));

            //Course romana = new Course("Curs de romana");
            Course romana = new Course();
            romana.Name = "Curs de romana";
            romana.addStudent(jimmy);

            jimmy=new Student("jhonny", "Jones", new DateTime(1990, 3, 15));
            romana.addStudent(jimmy);

            for(int i=1;i<=5;i++)
            {
                var jimmyy = new Student("Jimmy"+i, "Jones", new DateTime(1990, 3, 15));
                romana.addStudent(jimmyy);
            }

            Console.WriteLine($"{romana.Name} are studentii:");
            romana.printStudenti();

            Console.ReadLine();
        }
        public class Person
        {
            public Person(string firstName, string lastName, DateTime dateOfBirth)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.DateOfBirth = dateOfBirth;
            }

            protected string FirstName { get; private set; }
            protected string LastName { get; private set; }
            public DateTime DateOfBirth { get; private set; }

            public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }

            public bool IsAnAdult()
            {
                var eighteenYearsAgo = DateTime.Today.AddYears(-18);
                return this.DateOfBirth < eighteenYearsAgo;
            }
        }

        public class Student : Person
        {
            public Student(string firstName, string lastName, DateTime dateOfBirth)
                : base(firstName, lastName, dateOfBirth)
            { }
            public string SchoolName { get; set; }

            public string RosterName { get { return $"{this.LastName}, {this.FirstName}"; } }
        }
        public class Course
        {
            /*public Course(string Name)
            {
                this.Name = Name;
            }*/

            public string Name { get; set; }
            private List<Student> lista = new List<Student>();
            public void addStudent(Student x)
            {
                lista.Add(x);
            }
            public void printStudenti()
            {
                foreach (Student x in lista)
                    Console.WriteLine(x.RosterName);
            }
          
            
            
        }
        

        
    }
}
