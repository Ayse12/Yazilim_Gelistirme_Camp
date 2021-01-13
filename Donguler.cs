using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi
            string[] kurslar = new string[] { "Java", "Python", "C#", "C++" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //for döngüsü
            //Daha genel amaçlar için kullanılır
            for (int i = 1 ; i <=10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("For bitti.");

            //Dizi içindeki itemleı gezme
            //Dizi içinde dolaşmak için kullanılır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu");
        }
    }
}
