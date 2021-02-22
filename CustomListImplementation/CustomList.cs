using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListImplementation
{
    public class CustomList<T>
    {
        private T[] internalArray;
        private int count;
        private int capacity;
        public CustomList() {
            count = 0;
            capacity = 0;
            internalArray = new T[capacity];
        }
        public int Count
        {
            get => count;
        }
        public int Capacity
        {
            get => capacity;
            set => capacity = value;
        }
        public T this[int i]
        {
            get => internalArray[i];
            set => internalArray[i] = value;
        }

        public void Add(T item)
        {
        }
    }
}
