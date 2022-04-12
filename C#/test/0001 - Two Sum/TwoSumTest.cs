using LeetCode.Solutions._0001_Two_Sum;
using Xunit;

namespace LeetCode_Solutions.Tests._0001_Two_Sum
{
  public class TwoSumTest
  {
    [Theory]
    [MemberData(nameof(TwoSumTestData.TwoSum_ExpectedResult_Match), MemberType = typeof(TwoSumTestData))]
    public void TwoSum_ExpectedResult_Match(int[] nums, int target, int[] expected)
    {
      var result = Solution.TwoSum(nums, target);

      Assert.Equal(expected, result);
    }
  }
}
