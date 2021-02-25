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
            if (count > 1)
            {
                QuickSort(0, count - 1);
            }
        }
        private void Swap(int left, int right)
        {
            T temp = internalArray[right];
            internalArray[right] = internalArray[left];
            internalArray[left] = temp;
        }
        private int CompareT(T left, T right)
        {
            return Comparer.DefaultInvariant.Compare(left, right);
        }

        private void QuickSort(int leftIndex, int rightIndex)
        {
            // Check for case of 1 and 2. Do recursion for rest
            if (rightIndex - leftIndex == 0)
            {
                return;
            }
            else if (rightIndex - leftIndex == 1)
            {
                if (CompareT(internalArray[leftIndex], internalArray[rightIndex]) == 1)
                {
                    Swap(leftIndex, rightIndex);
                }
                return;
            }
            // Lazy implementation:
            // 0. Always use last number as pivot, don't bother with randomly choosing one
            // 1. Count number of values less than pivot to swap pivot to after it
            // 2. Go through each value on left side of pivot:
            //   a. If value is larger than pivot, swap with first value lower than pivot on right side
            // Stop when we hit pivot
      
            int smaller = 0;
            for (int i = leftIndex; i < rightIndex; i++)
            {
                if (CompareT(internalArray[i], internalArray[rightIndex]) == -1)
                {
                    smaller += 1;
                }
            }
            if (smaller == rightIndex - leftIndex)
            {
                // pivot is 
                QuickSort(leftIndex, rightIndex - 1);
            }
            else if (smaller == 0)
            {
                // pivot is smallest
                Swap(leftIndex, rightIndex);
                QuickSort(leftIndex + 1, rightIndex);
            }
            else
            {
                int left = leftIndex;
                int right = rightIndex;
                int pivotPoint = smaller + leftIndex;
                Swap(pivotPoint, rightIndex);
                while (left < pivotPoint)
                {
                    // left < pivot is 1, left == pivot is 0, left > pivot is -1
                    if (CompareT(internalArray[left], internalArray[pivotPoint]) > -1)
                    {
                        // Pivot < right is 1, pivot == right is 0, pivot > right is -1
                        while (CompareT(internalArray[pivotPoint], internalArray[right]) <= 0)
                        {
                            right -= 1;
                        }
                        Swap(left, right);
                        right -= 1;
                    }
                    // Otherwise continue
                    left += 1;
                }
                QuickSort(leftIndex, pivotPoint - 1);
                QuickSort(pivotPoint + 1, rightIndex);
            }
        }
    }
}
