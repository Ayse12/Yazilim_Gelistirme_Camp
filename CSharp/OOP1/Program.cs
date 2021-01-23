using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prdct1 = new Product();
            prdct1.Id = 1;
            prdct1.ProductName = "Masa";
            prdct1.CategoryId = 2;
            prdct1.UnitPrice = 500;
            prdct1.UnitsInStock = 3;

            Product prdct2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //PascalCase   //camelCase
            //case sensitive - Küçük büyük harf duyarlı
            ProductManager productManager = new ProductManager();
            productManager.Ref(prdct1);
            Console.WriteLine(prdct1.ProductName); //Şişe

            int sayi = 100;
            productManager.Out(sayi);
            Console.WriteLine(sayi); //100

            //out
            //int,double,bool --- değer tip
            //Atamalar tamamen değer üzerinden ilerler. Yani int=100 dediğimde fonksiyona sayiyı yolladıktan sonra tüm bağlantım biter. Çünkü sayi değeri aldıktan sonra fonksiyona gitmesine gerek kalmaz. Değer tamamen değeri veriyor ve iş biter.

            //ref
            //diziler,class,abstract class, interface ---- referans tip
            //Herşey yani atamalar referansın numarasıyla yapılır(bellekteki adresiyle) Aslında ben oluşturduğum veriyi referans adresi alır ve bu yüzden değer olmadığı için bellekteki adresteki değeri değitirebillir. Referans numarasına ait veri fonksiyon içinde değiştirilebilir.

            productManager.Topla2(2, 4);

            int toplamaSonucu = productManager.Topla(2, 4);
            Console.WriteLine(toplamaSonucu * 2);
        }
    }
}
