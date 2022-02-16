using System;
using System.Collections.Generic;
using System.Linq;
using Xunit; 
namespace HcakerRank.Tests
{
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {
            List<long> actual = new List<long>(), expected = new List<long>();
            expected.Add(10);
            int n = 10;
            List<List<int>> queries = new List<List<int>>();
            queries.Add(new List<int> { 1, 5, 3 });
            queries.Add(new List<int>  { 4, 8, 7});
            queries.Add(new List<int> { 6, 9, 1 });

            actual.Add(Solution.Result.arrayManipulation(n, queries));

            expected.Add(200);
            n = 5;
            queries = new List<List<int>>();
            queries.Add(new List<int> { 1, 2, 100 });
            queries.Add(new List<int> { 2, 5, 100 });
            queries.Add(new List<int> { 3, 4, 100 });


           

            actual.Add(Solution.Result.arrayManipulation(n, queries));


            Assert.Equal(expected, actual);

        }
         
    }
}