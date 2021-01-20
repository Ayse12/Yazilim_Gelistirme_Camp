using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            //List<string> isimler2 = new List<string>();
            //Console.WriteLine(isimler2.Count);
            Console.WriteLine(isimler.Length);
            isimler.Add("Kerem");

            Console.WriteLine(isimler.Length);
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
