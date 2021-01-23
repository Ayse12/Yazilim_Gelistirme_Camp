using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Şablonum görevi görür. İnterface
    //Bir interface der ki eğer ki birisi bunu kullanırsa o arkadaş aşağıdaki metodu içermek zorunda.
    interface IKrediManager //Okunurluğu arttırmak için I harfi ile başlatırız(interface olduğu anlaşılsın diye)
    {
        //interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız. 
        //Tüm kredilerde Ödeme işlemi ortaktır ama vergileri kdvleri faizleri farklısır.Yani fonksiyon içeriği farklıdır.
        void Hesapla();
        void BiseyYap();
    }
}
