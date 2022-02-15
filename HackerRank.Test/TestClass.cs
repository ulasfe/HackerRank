using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank.Test
{
    public class TestClass
    {
        [Fact]
        public void TestHourClass()
        {
            List<int> row1 =new List<int>( new int[] {1, 1, 1, 0, 0, 0 });
            List<int> row2 =new List<int>( new int[] {0, 1, 0, 0, 0, 0 });
            List<int> row3 =new List<int>( new int[] {1, 1, 1, 0, 0, 0 });
            List<int> row4 =new List<int>( new int[] {0, 0, 2, 4, 4, 0 });
            List<int> row5 =new List<int>( new int[] {0, 0, 0, 2, 0, 0 });
            List<int> row6 =new List<int>( new int[] {0, 0, 1, 2, 4, 0 });

            List<List<int>> arr = new List<List<int>>();
            arr[0].AddRange(row1);
            arr[1].AddRange(row2);
            arr[2].AddRange(row3);
            arr[3].AddRange(row4);
            arr[4].AddRange(row5);
            arr[5].AddRange(row6);
            int expected = 19;
            int actual = Solution.Result.hourglassSum(arr); 
            Assert.Equal(expected, actual);
            
 }
    }
}
