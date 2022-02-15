// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;


List<List<int>> arr = new List<List<int>>();


for (int i = 0; i < 6; i++)
{
    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
}

int result = Solution.Result.hourglassSum(arr);

Console.WriteLine(result);


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

        public static int hourglassSum(List<List<int>> arr)
        {
            int result = 0, temp = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int k = 0; k < arr[i].Count; k++)
                {
                    if (k + 2 < arr[i].Count && i + 2 < arr.Count)
                        temp = arr[i][k] + arr[i][k + 1] + arr[i][k + 2] + arr[i + 1][k + 1] + arr[i + 2][k] + arr[i + 2][k + 1] + arr[i + 2][k + 2];
                    if (i == 0 && k == 0)
                        result = temp;
                    if (temp > result)
                        result = temp;
                }
            }
            return result;
        }

    }

}
