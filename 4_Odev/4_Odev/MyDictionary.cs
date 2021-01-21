using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryProject
{
    class MyDictionary<T>
    {

        T[] items;
        public MyDictionary()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public T[] meyvelerim
        {
            get { return items; }
        }

        public int Count()
        {
            return items.Length;
        }

    }
}
