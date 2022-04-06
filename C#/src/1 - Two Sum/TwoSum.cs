using System.Collections.Generic;

namespace LeetCode.Solutions._1_Two_Sum
{
  public class Solution
  {
    public static int[] TwoSum(int[] nums, int target)
    {
      var dict = new Dictionary<int, int>();
      for (var i = 0; i < nums.Length; i++)
      {
        var secondPart = target - nums[i];

        if (dict.ContainsKey(secondPart))
        {
          var firstInd = dict[secondPart];
          return new int[] { firstInd, i };
        }

        dict[nums[i]] = i;
      }

      return new int[] { };
    }
  }
}
