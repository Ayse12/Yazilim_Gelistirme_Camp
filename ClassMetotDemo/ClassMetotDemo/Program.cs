using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cst1 = new Customer();
            cst1.CustomerId = 1;
            cst1.NameAndSurname = "Ali Bayrak";

            Customer cst2 = new Customer();
            cst2.CustomerId = 2;
            cst2.NameAndSurname = "Mehmet Bayrak";

            Customer cst3 = new Customer();
            cst3.CustomerId = 3;
            cst3.NameAndSurname = "Serdar Bayrak";

            CustomerManager cstmngr = new CustomerManager();

            //Adding
            cstmngr.Add(cst1);
            Console.WriteLine("--------------");

            //Deleting
            cstmngr.Delete(cst2);
            Console.WriteLine("--------------");

            // Listing
            Customer[] cstmr = new Customer[] { cst1, cst2, cst3 };
            cstmngr.List(cstmr);
            Console.ReadLine();
            Console.WriteLine("--------------");

        }
    }
}
