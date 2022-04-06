namespace LeetCode.Solutions._2_PalindromeNumber
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
  }
}

