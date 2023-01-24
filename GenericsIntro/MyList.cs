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
            var tempArray = array;
            array = new T[array.Length+1];
            array[array.Length-1] = item;
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }
            array[array.Length - 1] = item;
        }

        public int Length
        {
            get { return array.Length; }
        }

        public T[] items
        {
            get { return array; }
        }

    }
}
