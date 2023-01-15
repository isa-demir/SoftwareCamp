using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        public T[] array;

        public MyList()
        {
            array= new T[0];
        }

        public void Add(T item)
        {
            array = new T[array.Length+1];
            array[array.Length-1] = item;
        }

    }
}
