using System.Collections.Generic;

namespace LeetCode_Solutions.Tests._0001_Two_Sum
{
  public class TwoSumTestData
  {
    public static IEnumerable<object[]> TwoSum_ExpectedResult_Match =>
      new List<object[]>
        {
          new object[]
          {
            new[] { 2, 7, 11, 15 },
            9,
            new[] { 0, 1 }
          },
          new object[]
          {
            new[] { 3, 2, 4 },
            6,
            new[] { 1, 2 }
          },
          new object[]
          {
            new[] { 3, 3 },
            6,
            new[] { 0, 1 }
          },
        };
  }
}
