using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //İnterfacelerde o interface i implement eden classın referans sonucunu tutabiliyor.
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            Console.WriteLine("-------------------");

            //İnterfacelerde o interface i implement eden classın referans sonucunu tutabiliyor.
            IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            ihtiyacKrediManager1.Hesapla();

            IKrediManager tasitKrediManager1 = new TasitKrediManager();
            tasitKrediManager1.Hesapla();

            IKrediManager konutKrediManager1 = new KonutKrediManager();
            konutKrediManager1.Hesapla();

            Console.WriteLine("-------------------");
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager1);
            basvuruManager.BasvuruYap(konutKrediManager1, new DatabaseLoggerService());

            Console.WriteLine("-------------------");
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, konutKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            Console.WriteLine("-------------------");
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerServices = new FileLoggerService();

            BasvuruManager basvuruManager1 = new BasvuruManager();
            basvuruManager1.BasvuruYap(konutKrediManager1, fileLoggerServices);
        }
    }
}
