using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    //ListIsmi<veriti veya class tip>
    //Generics class demek özel çalışacağınız class anlamına geliyor.
    //Ben MyList'imde T ile çalışacağım.
    class MyList<T>
    {
        T[] items;
        //Arrayler referan tip olduğu için new'lenmesi gerekiyor.
        //ctor  ----> constructor Eğer MyList<T> classını herhangi bir yerde new lersem otomatik çalışmasını sağlayan kod.
        //ctor tab tab yapınca çıkar otomatikmen.
        public MyList()
        {
            //eleman sayımı yeni açtığı için 0 yapar
            items = new T[0];
        }

        public void Add(T item)
        {
            //Geçici dizi. Ben dizinin eleman sayısını 1 arttırır isem referans tip olduğu için önceki değerlerim uçar. Bunun için geçici bir diziye atarım.
            T[] tempArray = items;

            //List'ime eleman eklemek için eleman sayısını bir arttırarak ekleme işlemini sağlıyorum.  Mevcuttaki eleman sayısı kaç ise onu 1 arttırır
            //Dinamik bir yapı.
            items = new T[items.Length + 1];

            //emanet edilen veri geri alınır
            for (int i = 0; i < tempArray.Length; i++)
            {
                //sırasıyla items'a geri alıyorum.
                items[i] = tempArray[i];
            }
            //Eklemek istediğim elemanı şimdi eklemiş oldum.
            items[items.Length - 1] = item;
        }
        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
