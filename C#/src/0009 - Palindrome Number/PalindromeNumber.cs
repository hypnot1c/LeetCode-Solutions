using System.Collections.Generic;

namespace LeetCode.Solutions._0002_PalindromeNumber
{
  public class Solution
  {
    public static bool PalindromeNumber(int x)
    {
      if (x < 0) return false;

      var strX = x.ToString();
      for (int i = 0, j = strX.Length - 1; i != j; i++, j--)
      {
        if (j - i == 1)
        {
          return strX[i] == strX[j];
        }
        if (strX[i] != strX[j]) return false;
      }

      return true;
    }

    public static bool PalindromeNumberNoString(int x)
    {
      if (x < 0 || (x % 10 == 0 && x != 0))
      {
        return false;
      }

      var xx = x;
      var left = xx % 10;
      var bits = new List<int>();

      while (left > 0 || (xx / 10) > 0)
      {
        bits.Add(left);
        xx /= 10;
        left = xx % 10;
      }

      if (bits.Count == 1)
      {
        return true;
      }

      for (int i = 0, j = bits.Count - 1; i != j && j > i; i++, j--)
      {
        if ((bits[i] ^ bits[j]) > 0)
          return false;
      }

      return true;
    }
  }
}

