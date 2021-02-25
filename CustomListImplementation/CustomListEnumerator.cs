using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListImplementation
{
    public class CustomListEnumerator<T> : IEnumerator
    {
        private int index;
        private int startingTransactionID;
        CustomList<T> underlyingData;
        public object Current
        {
            get
            {
                if (index == -1)
                {
                    throw new InvalidOperationException();
                }
                if (index < underlyingData.Count)
                {
                    return underlyingData[index];
                }
                throw new InvalidOperationException();
            }
        }
        public CustomListEnumerator (CustomList<T> target) {
            index = -1;
            underlyingData = target;
            startingTransactionID = target.TransactionID;
        }
        

        public bool MoveNext()
        {
            if (underlyingData.TransactionID != startingTransactionID)
            {
                throw new InvalidOperationException();
            }
            // If pointer is before beginning of list
            if (index == -1)
            {
                // Check for empty list case
                if (underlyingData.Count == 0)
                {
                    return false;
                }
            }
            // It is incrementing up by one after checking, so need to compare to count - 1
            if (index < underlyingData.Count - 1)
            {
                index += 1;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void Reset()
        {
            if (underlyingData.TransactionID != startingTransactionID)
            {
                throw new InvalidOperationException();
            }
            else
            {
                index = -1;
            }
        }
    }
}
