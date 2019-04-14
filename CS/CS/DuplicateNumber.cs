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
            numbArray.Min();
        }

        // Slow - Time: n^2
        public string findDuplicateLoop (){
            for(int i = 0; i < numbArray.Length; i++)
            {
                int j = i;
                for(j = i+1; j < numbArray.Length; j++)
                {
                    if(numbArray[i] == numbArray[j])
                    {
                        return numbArray[i].ToString();
                    }
                }
            }
            return "Failed...";
        }

        // Fast - Time: n
        public string findDuplicateFaster()
        {
            // Hash table
            HashSet<int> values = new HashSet<int>();

            foreach(int number in numbArray)
            {
                if (values.Contains(number))
                {
                    return number.ToString();
                }
                else
                {
                    values.Add(number);
                }
            }

            return "Failed...";
        }
    }
}
