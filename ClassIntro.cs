using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C++";
            kurs1.Egitmen = "Mehmet";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Faruk";
            kurs2.IzlenmeOrani = 79;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.Egitmen = "Ayşe";
            kurs3.IzlenmeOrani = 89;

            Console.WriteLine(kurs1.KursAdi+":"+kurs1.Egitmen);
            Console.WriteLine("------------------------------");

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs1.KursAdi + ":" + kurs.Egitmen);
            }
        }
    }

    //Kurs objesi oluşturuyorum. int string gibi bir tip tanımladım.
    class Kurs
    {
        //Özellik
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
