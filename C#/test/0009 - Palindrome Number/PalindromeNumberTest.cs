using LeetCode.Solutions._0009_PalindromeNumber;
using Xunit;

namespace LeetCode_Solutions.Tests._0009_PalindromeNumber
{
  public class PalromeNumberTest
  {
    [Theory]
    [MemberData(nameof(PalindromeNumberTestData.PalindromeNumber_ExpectedResult_Match), MemberType = typeof(PalindromeNumberTestData))]
    public void PalindromeNumber_ExpectedResult_Match(int input, bool expected)
    {
      var result = Solution.PalindromeNumber(input);

      Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(PalindromeNumberTestData.PalindromeNumber_ExpectedResult_Match), MemberType = typeof(PalindromeNumberTestData))]
    public void PalindromeNumberNoString_ExpectedResult_Match(int input, bool expected)
    {
      var result = Solution.PalindromeNumberNoString(input);

      Assert.Equal(expected, result);
    }
  }
}
