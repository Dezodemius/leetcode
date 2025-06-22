using System.Text;

namespace Tasks.Task392;

public class Solution
{
  public bool IsSubsequence(string s, string t)
  {
    if (s.Length == 0)
      return true;

    var j = s.Length;
    for (int i = 0; i < t.Length; i++)
    {
      if (t[i] == s[^j] && j >= 1)
      {
        j--;
        if (j == 0)
          return true;
      }
    }
    return j == 0;
  }
}