using System;

namespace SartBloklari
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini Tekrarlama
            //değer tutucu alies

            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 32000;
            double faizOrani = 4.12;

            bool sistemeGirisYapmisMi = false;
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


        }
    }
}
