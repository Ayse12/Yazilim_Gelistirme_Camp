using System;

namespace DictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> meyveler = new MyDictionary<string>();
            meyveler.Add("Portakal");
            meyveler.Add("Elma");
            meyveler.Add("Armut");
            Console.WriteLine("-------------");

            Console.WriteLine("Adet : " + meyveler.Count());
            meyveler.Add("Nar");
            Console.WriteLine("-------------");

            Console.WriteLine("Adet : " + meyveler.Count());
            Console.WriteLine("-------------");

            foreach (var meyve in meyveler.meyvelerim)
            {
                Console.WriteLine(meyve);
            }

            Console.WriteLine("-------------");
        }
    }
}

