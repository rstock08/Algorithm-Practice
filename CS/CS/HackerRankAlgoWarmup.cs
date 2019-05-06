using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    
    // Complete the compareTriplets function below.
    class HackerRankAlgoWarmup
    {

        // Problem (HackerRank): https://www.hackerrank.com/challenges/compare-the-triplets/problem
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            List<int> abScore = new List<int>() { 0, 0 };

            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                {
                    abScore[0] += 1;
                }
                else if (a[i] < b[i])
                {
                    abScore[1] += 1;
                }
            }
            return abScore;
        }

        //Problem(HackerRank) : https://www.hackerrank.com/challenges/compare-the-triplets/problem

    }
}
