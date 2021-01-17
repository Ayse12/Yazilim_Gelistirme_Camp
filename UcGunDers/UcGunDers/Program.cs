using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Product prdct1 = new Product();
            prdct1.Name = "Armut";
            prdct1.Price = 15.5;
            prdct1.Description = "Armut işte";

            Product prdct2 = new Product();
            prdct2.Name = "Karpuz";
            prdct2.Price = 80;
            prdct2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { prdct1,prdct2};

            //type-safe -- tip güvenliği
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("---------------METHODS-------------------");

            //İnstance - Örnek
            //Encapsulation
            SepetManager sptmngr = new SepetManager();
            sptmngr.Add(prdct1);
            sptmngr.Add(prdct2);

            sptmngr.Add2("Muz", "Çikita Muz", 15,2);
            sptmngr.Add2("Nar", "Tap taze Nar", 7,6);
            sptmngr.Add2("Elma", "Yeşil Elma", 6,9);
        }
    }
}

//Dont repeat yourself - DRY - Clean Code- Best Practice