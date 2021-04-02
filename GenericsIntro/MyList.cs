using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items;
        //constructor <<ctor>>
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //önceki değerleri korumak için geçici array
            items = new T[items.Length + 1]; // burda listemizin eleman sayısını 1 artırdık
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;//oluşan boş array e gelen item yazdırdık

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
