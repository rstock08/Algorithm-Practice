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

        // Problem(HackerRank): https://www.hackerrank.com/challenges/time-conversion/problem
        public static string TimeConversion(string s)
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
            return s;
        }

        // Problem(HackerRank): https://www.hackerrank.com/challenges/birthday-cake-candles/problem
        public static int BirthdayCakeCandles(int[] ar)
        {

            int n = ar.Length;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {

                if (!dict.ContainsKey(ar[i]))
                {
                    dict.Add(ar[i], 1);
                }
                else
                {
                    dict[ar[i]] += 1;
                }
            }

            //Console.Write(dict[dict.Keys.Max()]);

            return dict[dict.Keys.Max()];
        }

        // Problem(HackerRank): https://www.hackerrank.com/challenges/mini-max-sum/problem
        public static void MiniMaxSum(int[] arr)
        {

            double tot = 0;
            double min = 0;
            double max = 0;
            double temp = 0;

            foreach (int number in arr)
            {
                tot += number;
            }

            min = tot;

            foreach (int number in arr)
            {
                temp = tot - number;

                if (temp < min)
                {
                    min = temp;
                }
                if (temp > max)
                {
                    max = temp;
                }
            }


            Console.WriteLine(min + " " + max);
        }

        // Problem(HackerRank): https://www.hackerrank.com/challenges/staircase/problem
        public static void Staircase(int n)
        {
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {

                    while (k < n - i - 1)
                    {
                        Console.Write(" ");

                        k += 1;
                    }

                    Console.Write("#");

                }
                k = 0;
                Console.WriteLine();
            }
        }

        // Problem(HackerRank): https://www.hackerrank.com/challenges/plus-minus/problem
        public static void PlusMinus(int[] arr)
        {
            double pos = 0, neg = 0, zer = 0;
            double n = arr.Length;

            for (int i = 0; i < n; i++)
            {

                //Console.Write(arr[i]);

                if (arr[i] > 0)
                {
                    pos += 1;
                }
                else if (arr[i] < 0)
                {
                    neg += 1;
                }
                else
                {
                    zer += 1;
                }
            }

            Console.WriteLine("{0:0.000000}", pos / n);
            Console.WriteLine("{0:0.000000}", neg / n);
            Console.WriteLine("{0:0.000000}", zer / n);

        }

        // Problem(HackerRank): https://www.hackerrank.com/challenges/diagonal-difference/problem
        public static int DiagonalDifference(int[][] arr)
        {
            int val1 = 0, val2 = 0, dif = 0;
            int n = arr.GetLength(0);
            int ai = n - 1;

            // First for loop iterates through the columns
            for (int i = 0; i < n; i++)
            {

                // Second for loop iterates through the rows
                for (int j = 0; j < n; j++)
                {

                    if (i == j)
                    {
                        val1 += arr[i][j];
                        val2 += arr[ai][j];
                    }
                }

                ai -= 1;
            }

            dif = Math.Abs(val1 - val2);

            return dif;
        }

        // Problem(HackerRank): https://www.hackerrank.com/challenges/a-very-big-sum/problem
        public static long AVeryBigSum(long[] ar)
        {

            long arSum = 0;

            foreach (long numb in ar)
            {
                arSum += numb;
            }

            return arSum;
        }

        // Problem(HackerRank): https://www.hackerrank.com/challenges/sock-merchant/problem
        public static int SockMerchant(int n, int[] ar)
        {
            int matches = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            if (n > 1)
            {

                foreach (int sock in ar)
                {
                    if (dict.ContainsKey(sock))
                    {
                        dict[sock] += 1;
                    }
                    else
                    {
                        dict.Add(sock, 1);
                    }
                }

                foreach (KeyValuePair<int, int> entry in dict)
                {
                    if (entry.Value > 1)
                    {
                        matches += (entry.Value / 2);
                    }
                }

                return matches;
            }
            else
            {
                return 0;
            }
        }

        // Problem(HackerRank): https://www.hackerrank.com/challenges/simple-array-sum/problem
        public static int SimpleArraySum(int[] ar)
        {
            var total = 0;
            foreach (int number in ar)
            {
                total = total + number;
            }

            return total;

        }

        // Problem(HackerRank): https://www.hackerrank.com/challenges/counting-valleys/problem
        public static int CountingValleys(int n, string s)
        {
            int valleys = 0;
            int dCounter = 0;

            if (s.Length > 1)
            {
                foreach (char character in s.ToLower())
                {

                    if (character == 'd')
                    {
                        dCounter += 1;

                        if (dCounter == 2)
                        {
                            valleys += 1;
                        }
                    }
                    else
                    {
                        dCounter = 0;
                    }
                }
                return valleys;
            }
            else
            {
                return valleys;
            }
        }
    }
}
