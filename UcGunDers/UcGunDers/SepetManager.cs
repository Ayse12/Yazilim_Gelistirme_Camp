using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    class SepetManager
    {
        //Naming Convention -- İsimlendirme Kuralı
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi :"+product.Name);
        }

        public void Add2(string productName , string description, double price, int stock)
        {
            Console.WriteLine("Sepete Eklendi :" + productName);
        }
    }
}
