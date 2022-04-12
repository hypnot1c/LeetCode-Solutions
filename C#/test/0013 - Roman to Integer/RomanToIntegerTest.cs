using LeetCode.Solutions._0013_Roman_to_Integer;
using Xunit;

namespace LeetCode_Solutions.Tests._0013_RomanToInteger
{
  public class RomanToIntegerTest
  {
    [Theory]
    [MemberData(nameof(RomanToIntegerTestData.RomanToInteger_ExpectedResult_Match), MemberType = typeof(RomanToIntegerTestData))]
    public void RomanToInteger_ExpectedResult_Match(string input, int expected)
    {
      var result = Solution.RomanToInt(input);

      Assert.Equal(expected, result);
    }
  }
}
