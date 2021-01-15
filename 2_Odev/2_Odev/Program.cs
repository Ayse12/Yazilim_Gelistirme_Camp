using System;

namespace _2_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prd = new Product();
            prd.ProductName = "Computer";
            prd.CategoryName = "Electronic";
            prd.Price = 5859.99;

            Product prd1 = new Product();
            prd1.ProductName = "Sneakers";
            prd1.CategoryName = "Sports and Outdoors";
            prd1.Price = 195.65;

            Product prd2 = new Product();
            prd2.ProductName = "Drone";
            prd2.CategoryName = "Toys and Games";
            prd2.Price = 999.99;

            Product[] Products = new Product[] { prd, prd1, prd2 };

            Console.WriteLine("FOR döngüsü");
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine("Product Name: " + Products[i].ProductName + "\nCategory Name: " + Products[i].CategoryName + "\nPrice: " + Products[i].Price);
                Console.WriteLine("\n");
            }
            Console.WriteLine("-------------------------------------------------------------");


            Console.WriteLine("WHILE döngüsü");
            int j = 0;
            while (j < Products.Length)
            {
                Console.WriteLine("Product Name: " + Products[j].ProductName + "\nCategory Name: " + Products[j].CategoryName + "\nPrice: " + Products[j].Price);
                Console.WriteLine("\n");
                j++;
            }
            Console.WriteLine("-------------------------------------------------------------");


            Console.WriteLine("FOREACH DÖNGÜSÜ***");
            foreach (Product prooduct in Products)
            {
                Console.WriteLine("Product Name: " + prooduct.ProductName + "\nCategory Name: " + prooduct.CategoryName + "\nPrice: " + prooduct.Price);
                Console.WriteLine("\n");
            }
            Console.WriteLine("-------------------------------------------------------------");

        }
    }
  
    class Product
    {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public double Price { get; set; }
    }
}
