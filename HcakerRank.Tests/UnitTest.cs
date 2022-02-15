using System;
using System.Collections.Generic;
using System.Linq;
using Xunit; 
namespace HcakerRank.Tests
{
    public class UnitTest
    {
        [Fact]
        public void TestHourClass()
        {
            List<int> row1 = new List<int>(new int[] { 1, 1, 1, 0, 0, 0 });
            List<int> row2 = new List<int>(new int[] { 0, 1, 0, 0, 0, 0 });
            List<int> row3 = new List<int>(new int[] { 1, 1, 1, 0, 0, 0 });
            List<int> row4 = new List<int>(new int[] { 0, 0, 2, 4, 4, 0 });
            List<int> row5 = new List<int>(new int[] { 0, 0, 0, 2, 0, 0 });
            List<int> row6 = new List<int>(new int[] { 0, 0, 1, 2, 4, 0 });

            List<List<int>> arr = new List<List<int>>();
            arr.Add(row1);
            arr.Add(row2);
            arr.Add(row3);
            arr.Add(row4);
            arr.Add(row5);
            arr.Add(row6);
            int expected = 19;
            int actual = Solution.Result.hourglassSum(arr);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Test2()
        {

            List<int> row1 = new List<int>(new int[] {0 ,-4 ,-6 ,0 ,-7 ,-6  });
            List<int> row2 = new List<int>(new int[] {-1, -2, -6,-8, -3, -1 });
            List<int> row3 = new List<int>(new int[] {-8, -4, -2,-8, -8, -6 });
            List<int> row4 = new List<int>(new int[] {-3, -1, -2,-5, -7, -4 });
            List<int> row5 = new List<int>(new int[] {-3, -5, -3,-6, -6, -6 });
            List<int> row6 = new List<int>(new int[] {-3, -6, 0 ,-8, -6, - 7});

            List<List<int>> arr = new List<List<int>>();
            arr.Add(row1);
            arr.Add(row2);
            arr.Add(row3);
            arr.Add(row4);
            arr.Add(row5);
            arr.Add(row6);
            int expected = -19;
            int actual = Solution.Result.hourglassSum(arr);

            arr = new List<List<int>>();
            arr.Add(new List<int> {-1, -1, 0 ,-9 -2 ,-2});
            arr.Add(new List<int> {-2, -1, -6, -8 -2, -5});
            arr.Add(new List<int> {-1, -1, -1, -2 -3, -4});
            arr.Add(new List<int> {-1, -9, -2, -4 -4, -5});
            arr.Add(new List<int> {-7, -3, -3, -2 -9, -9});
            arr.Add(new List<int> {-1, -3, -1, -2 -4, -5 });

            expected = -6;
            actual = Solution.Result.hourglassSum(arr);


            Assert.Equal(expected, actual);
        }
    }
}