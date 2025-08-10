using System.Linq;

namespace Tasks.Task9;

public class Solution
{
  public bool IsPalindrome(int x) {
    if (x < 0)
      return false;

    var a = x.ToString();
    var b = new string(a.ToCharArray().Reverse().ToArray());

    return a == b;
  }
}