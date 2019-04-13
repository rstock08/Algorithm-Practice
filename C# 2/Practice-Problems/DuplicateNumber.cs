using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{

    class DuplicateNumber
    {
        public int[] numbArray;
        public DuplicateNumber(int[] numbArray)
        {
            this.numbArray = numbArray;
        }

        // Slow - Time: n^2
        public int findDuplicateLoop (){
            for(int i = 0; i < numbArray.Length; i++)
            {
                int j = i;
                for(j = i; j < numbArray.Length; j++)
                {
                    if(numbArray[i] == numbArray[j])
                    {
                        return numbArray[i];
                    }
                }
            }

        }

        // Fast - Time: n
        public int findDuplicateFaster()
        {
            // Hash table
            HashSet<int> values = new HashSet<int>();

            foreach(int number in numbArray)
            {
                if (values.Contains(number))
                {
                    return number;
                }
                else
                {
                    values.Add(number);
                }
            }
        }
    }
}
