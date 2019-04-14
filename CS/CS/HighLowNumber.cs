using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class HighLowNumber
    {
        public List<int> UnsortedArray { get; set; }
        public List<int> SortedArray { get; set; }

        public HighLowNumber(int[] numbArray)
        {
            UnsortedArray = numbArray.ToList();
            numbArray.Min();
        }

        public void mergeSort()
        {
           
        }

        public List<int> divide(List<int> unsorted)
        {
            // If passed in array is not a single item, divide again.
            
            if (arr.Count != 1)
            {
                SortedArray.Add(divide(arr));
            }
            else
            {
                return arr;
            }
        }

    }
}
