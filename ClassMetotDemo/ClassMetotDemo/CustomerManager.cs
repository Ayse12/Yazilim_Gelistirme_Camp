using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.NameAndSurname + " " + "Added ! ! !");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.NameAndSurname + " " + "Deleted ! ! !");
        }
        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.NameAndSurname);
            }
        }

    }
}
