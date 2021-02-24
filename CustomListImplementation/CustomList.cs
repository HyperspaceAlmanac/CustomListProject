using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListImplementation
{
    public class CustomList<T> : IEnumerable
    {
        private T[] internalArray;
        private int count;
        private int capacity;
        private Random rand;
        public CustomList()
        {
            count = 0;
            capacity = 0;
            internalArray = new T[0];
            rand = new Random();
        }
        public int Count
        {
            get => count;
        }
        public int Capacity
        {
            get => capacity;
            set
            {
                // Need to change size of array when updating capacity
                // Do nothing if new value is equal to capacity, or if it is less than count
                if (value != capacity)
                {
                    if (value > count)
                    {
                        capacity = value;
                        T[] newArray = new T[capacity];
                        for (int i = 0; i < count; i++)
                        {
                            newArray[i] = internalArray[i];
                        }
                        internalArray = newArray;
                    }
                }
            }
        }
        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return internalArray[i];
            }
            set
            {
                if (i < 0 || i >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                internalArray[i] = value;
            }
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < count; i++)
            {
                sb.Append((i > 0 ? "," : "") + internalArray[i].ToString());
            }
            sb.Append("]");
            return sb.ToString();
        }
        public static CustomList<T> operator +(CustomList<T> left, CustomList<T> right)
        {
            // If left or right is empty, just return other
            CustomList<T> newList = new CustomList<T>();
            // Can fit into left or right capacity, if not, larger of two times two
            newList.Capacity = (left.Count + right.Count <= left.Capacity) ? left.Capacity
                : (left.Count + right.Count <= right.Capacity ? right.Capacity
                : Math.Max(left.Capacity, right.Capacity) * 2);
            for (int i = 0; i < left.Count; i++)
            {
                newList.Add(left[i]);
            }
            for (int i = 0; i < right.Count; i++)
            {
                newList.Add(right[i]);
            }
            return newList;
        }

        public static CustomList<T> operator -(CustomList<T> left, CustomList<T> right)
        {
            CustomList<T> newList = new CustomList<T>();
            newList.Capacity = left.Capacity;
            for (int i = 0; i < left.Count; i++)
            {
                newList.Add(left[i]);
            }
            for (int i = 0; i < right.Count; i++)
            {
                newList.Remove(right[i]);
            }
            return newList;
        }

        public CustomList<T> Zip(CustomList<T> rightList)
        {
            // Double capacity until everything can fit
            CustomList<T> zipped = new CustomList<T>();
            while (count + rightList.count > capacity)
            {
                if (capacity == 0)
                {
                    capacity = 4;
                }
                else
                {
                    capacity *= 2;
                }
            }
            int i = 0;
            int j = 0;
            while (i < count || j < rightList.Count)
            {
                if (i < count)
                {
                    zipped.Add(internalArray[i]);
                    i += 1;
                }
                if (j < rightList.Count)
                {
                    zipped.Add(rightList[j]);
                    j += 1;
                }
            }
            return zipped;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return internalArray[i];
            }
        }

        public void Sort()
        {
            // Really should just do Quicksort.
        }

        private void QuickSort(int pivot, int leftIndex, int rightIndex)
        {

        }
    }
}
