using System.Collections.Generic;

namespace LeetCode_Solutions.Tests._0013_RomanToInteger
{
  public class RomanToIntegerTestData
  {
    public static IEnumerable<object[]> RomanToInteger_ExpectedResult_Match =>
      new List<object[]>
      {
        new object[]
        {
          "III",
          3
        },
        new object[]
        {
          "LVIII",
          58
        },
        new object[]
        {
          "MCMXCIV",
          1994
        },
      };
  }
}
