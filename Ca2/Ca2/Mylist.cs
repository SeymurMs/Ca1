using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ca2
{
    class Mylist<T> :IEnumerable<T>
    {
        public T[] Arr = new T[5];

        public T this[int index]
        {
            get => Arr[index];
            set => Arr[index] = value;
        }
        public void Add(T val)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = val;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in Arr)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
