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

        //Problem(HackerRank) : https://www.hackerrank.com/challenges/time-conversion/problem
        static string timeConversion(string s)
        {
            string tempT = "";
            int tempVal1 = 0, tempVal2 = 0;

            if (s.Contains("AM"))
            {

                s = s.Replace("AM", "");

                if (s.Substring(0, 2).Contains("12"))
                {
                    s = s.Replace(s.Substring(0, 2), "00");
                }
            }
            else if (s.Contains("PM"))
            {

                s = s.Replace("PM", "");

                if (s.Substring(0, 2).Contains("12"))
                {
                    //String stays the same
                }
                else
                {
                    tempT = s.Substring(0, 2);
                    tempVal1 = Convert.ToInt32(tempT);
                    tempVal2 = tempVal1 + 12;

                    if (tempVal1 < 10)
                    {
                        s = s.Replace(s.Substring(0, 2), tempVal2.ToString());
                    }
                    else
                    {
                        s = s.Replace(tempVal1.ToString(), tempVal2.ToString());
                    }
                }
            }

            // Debug
            //Console.WriteLine(tempT);
            //Console.WriteLine(tempVal1);
            //Console.WriteLine(tempVal2);

            return s;
        }
    }
}
