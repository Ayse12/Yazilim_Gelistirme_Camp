using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection ----> Bu methodun kullanacağı kredimanagerın ve hanagi logmanager kullanacağını enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)//Buraya ne gönderirsem o kredi referansı çalışmış olur
        {
            //Başvuru Bilgilerini değerlendirme
            //
            krediManager.Hesapla(); //Hangi kredimanagerı gönderirse onun hesaplası çalışacak.
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //Birden fazla kredinin hesabını yapmak istiyorum. Bana bir liste ver veri türü IkrediManager olsun diyoruz.
        {
            foreach (var kredi in krediler)//Listedeki her bir kredinin hesabını yap.
            {
                kredi.Hesapla();
            }
        }
    }
}
