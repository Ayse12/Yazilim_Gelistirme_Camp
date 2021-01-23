using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //İnterface clasını implement eden classlar kendi işlemlerine göre fonksiyonları doldurmalıdır.
    class KonutKrediManager : IKrediManager //Üzerine gelip ampülden implement interface yazısına tıkladığında base classtaki kularrı getirir. 
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı !");

        }
    }
}
