using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Practice 
/// </summary>
namespace Practice_Problems
{
    class MissingNumber
    {
        // Variables
        public int[] numArray;
        public int missingNumber;

        // Constructor
        public MissingNumber(int[] numArray)
        {
            this.numArray = numArray;
        }

        // Find the missing number given the array fed in to the constructor
        public void findMissingNumber()
        {
            int count = 1;
            foreach (int number in numArray){

                if (number != count) {
                    missingNumber = count;
                    return;
                }
                else { count += 1; }
            }
        }
    }
}
