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
            internalArray = new T[0];
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
            get {
                if (i < 0 || i >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return internalArray[i];
            }
            set {
                if (i < 0 || i >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                internalArray[i] = value; }
        }

        public void Add(T item)
        {
            if (count >= capacity)
            {
                if (capacity == 0)
                {
                    capacity = 4;
                    internalArray = new T[4];
                }
                else
                {
                    T[] newArray = new T[capacity * 2];
                    // Copy over everything from previous array
                    for (int i = 0; i < capacity; i++)
                    {
                        newArray[i] = internalArray[i];
                    }
                    internalArray = newArray;
                    capacity = capacity * 2;
                }
            }
            internalArray[count] = item;
            count += 1;
        }

        public bool Remove(T item)
        {
            int removalIndex = -1;
            for (int i = 0; i < count; i++)
            {
                if (internalArray[i].Equals(item))
                {
                    removalIndex = i;
                    break;
                }
            }
            if (removalIndex == -1)
            {
                return false;
            }
            T[] newArray = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                if (i < removalIndex)
                {
                    newArray[i] = internalArray[i];
                }
                else if (i > removalIndex)
                {
                    newArray[i - 1] = internalArray[i];
                }
            }
            internalArray = newArray;
            count -= 1;
            return true;
        }
    }
}
