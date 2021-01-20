using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        //Ctrl + K + C -------> Comment
        //Ctrl + K + U -------> Uncomment
        static void Main(string[] args)
        {
            //Bir array tanımlandığında eleman sayısı 4 ise 5. elemanı ekleyemiyoruz. new demek yeni referans alanı demek o yüzden arrayler kullaım açısından sınırlıdır. Onun yerine List kullanılır.
            string[] isimler = new string[] { "Ayşe", "Murat", "Fatma", "Aslı" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            Console.WriteLine("--------------");

            //new denildiği anda bellekte adres ayrılır.
            isimler = new string[5];
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]); //Gösterilmez. Çünkü new ile başka adreste 5 elemanlı bir array oluşturdum. Yukarıdaki diziden farklı bir adres olduğu için 0.indiste eleman olmadığı için boş gelir.
            Console.WriteLine("--------------");

            List<string> isimler2 = new List<string> { "Ayşe", "Murat", "Fatma", "Aslı" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine("--------------");
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            Console.WriteLine("--------------");

        }
    }
}
