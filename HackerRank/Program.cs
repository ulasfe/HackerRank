// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;






namespace Solution
{


    public class Result
    {


        /*
         * Complete the 'hourglassSum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */
        public static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < m; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            long result = Solution.Result.arrayManipulation(n, queries);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            long[] control = new long[n + 1];
            long a, b, k;
            for (int i = 0; i < queries.Count; i++)
            {
                a = queries[i][0];
                b = queries[i][1];
                k = queries[i][2];

                control[a - 1] += k;
                control[b] -= k;
            }

            long max = long.MinValue;
            long sum = 0;
            for (int i = 0; i < control.Length; i++)
            {
                sum += control[i];
                max = Math.Max(max, sum);
            }
            return max;
        }

    }

}
