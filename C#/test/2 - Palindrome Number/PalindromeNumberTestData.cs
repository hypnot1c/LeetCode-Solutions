using System.Collections.Generic;

namespace LeetCode_Solutions.Tests._2_PalindromeNumber
{
  public class PalindromeNumberTestData
  {
    public static IEnumerable<object[]> PalindromeNumber_ExpectedResult_Match =>
      new List<object[]>
        {
          new object[]
          {
            121,
            true
          },
          new object[]
          {
            -121,
            false
          },
          new object[]
          {
            10,
            false
          },
        };
  }
}
