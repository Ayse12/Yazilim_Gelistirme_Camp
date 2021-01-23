using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Ref(Product prdct)
        {
            prdct.ProductName = "Şişe";
        }
        public void Out(int sayi)
        {
            sayi = 99;
        }
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        //void ben birşey istemiyorum. Kendisi içindeki kodlarla işlemi tamamlasın.
        //int türünde fonksiyonda ise dışarıya return komutuyla istediğimiz veriyi gönderiyoruz ve kod bloklarında üzerine işlemler yapabiliriz.    }
    }
}
