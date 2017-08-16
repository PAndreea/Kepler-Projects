using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex14
    {
        public class Customer
        {
            public Customer(string name)
            {
                Name = name;
            }
            public string Name { get; }
            public List<Order> Orders { get; } = new List<Order>();

            public List<Order> History()
            {
                return Orders;
            }
            public void Adauga(Order x)
            {

                if ((x == null)||(x.OrderDate>DateTime.Now))
                    Console.WriteLine("Valoarea inserata este 'null'");
                else
                {
                    if(Orders.FirstOrDefault(y => y==x)==null)
                        Orders.Add(x);
                }
                
            }

        }

        public class Order
        {
            public Order(string orderNumber,DateTime orderDate)
            {
                OrderNumber = orderNumber;
                OrderDate = orderDate;
            }
            public string OrderNumber { get; }
            public DateTime OrderDate { get; }

        }

       

        public void exercitiu()
        {
            var customer1 = new Customer("Steve");
            customer1.Orders.Add(new Order("123", new DateTime(1999, 3, 15)));
            customer1.Orders.Add(new Order("234", new DateTime(2005, 9, 19)));
            customer1.Orders.Add(new Order("345", new DateTime(1990, 12, 24)));
            foreach (Order name in customer1.Orders)
                Console.WriteLine($"{name.OrderNumber}, {name.OrderDate}");
            Console.ReadLine();
        }
    }
}
