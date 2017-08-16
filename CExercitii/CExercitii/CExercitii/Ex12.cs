using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii {
    public class Ex12
    {
        public void exercitiu()
        {
            List<Person> persoane = new List<Person>();
            List<Company> companii = new List<Company>();
            for (int i = 1; i <= 5; i++)
            {
                Person persoana = new Person();
                persoana.ShippingAddress = new Address();
                persoana.FirstName = "Prenume" + i;
                persoana.LastName = "Nume" + i;
                persoana.ShippingAddress.StreetAddress = "Strada" + i;
                persoana.ShippingAddress.City = "Orasul" + i;
                persoana.ShippingAddress.State = "Statul" + i;
                persoana.ShippingAddress.PostalCode = "Cod postal" + i;
                persoana.ShippingAddress.Country = "Tara" + i;
                persoane.Add(persoana);

                Company companie = new Company();
                companie.ShippingAddress = new Address();
                companie.Name = "Nume" + i;
                companie.ShippingAddress.StreetAddress = "Strada" + i;
                companie.ShippingAddress.City = "Orasul" + i;
                companie.ShippingAddress.State = "Statul" + i;
                companie.ShippingAddress.PostalCode = "Cod postal" + i;
                companie.ShippingAddress.Country = "Tara" + i;
                companii.Add(companie);


            }
            Console.WriteLine("Afiseaza persoanele:");
            foreach(Person persoana in persoane)
            {
                persoana.write();
            }

            Console.WriteLine("Afiseaza companiile:");
            foreach(Company companie in companii)
            {
                companie.write();
            }
            Console.ReadLine();

            

        }
        public class Address
        {
            public string StreetAddress { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Address ShippingAddress { get; set; }
            public void write()
            {
                Console.WriteLine($"{FirstName},{LastName}");
                Console.WriteLine($"{ShippingAddress.StreetAddress}");
                Console.WriteLine($"{ShippingAddress.City},{ShippingAddress.State},{ShippingAddress.PostalCode}");
                Console.WriteLine($"{ShippingAddress.Country}\n");
            }
        }
        public class Company
        {
            public string Name { get; set; }
            public Address ShippingAddress { get; set; }
            public void write()
            {
                Console.WriteLine($"{Name}");
                Console.WriteLine($"{ShippingAddress.StreetAddress}");
                Console.WriteLine($"{ShippingAddress.City},{ShippingAddress.State},{ShippingAddress.PostalCode}");
                Console.WriteLine($"{ShippingAddress.Country}\n");
            }
        }

    }
}
            
            
        
    

