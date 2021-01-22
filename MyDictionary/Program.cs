using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> meyveler = new MyDictionary<string, string>();
            meyveler.Add("Elma", "Yeşil");
            meyveler.Add("Armut", "Sarı");
            meyveler.Add("Nar", "Kırmızı");
            meyveler.Add("Üzüm", "Siyah");
            Console.WriteLine(meyveler.Length);

            foreach (var ismi in meyveler.Keys)
            {
                Console.WriteLine(ismi);
            }

            foreach (var isim in meyveler.Values)
            {
                Console.WriteLine(isim);
            }

            Console.ReadLine();
        }
    }
}
