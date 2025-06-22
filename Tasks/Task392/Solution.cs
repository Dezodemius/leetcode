using System.Text;

namespace Tasks.Task392;

public class Solution
{
  public bool IsSubsequence(string s, string t)
  {
    if (s.Length == 0)
      return true;
    StringBuilder a = new StringBuilder(t);
    int j = 0;
    int k = 0;
    for (int i = 0; i < t.Length; i++)
    {
      if (t[i] != s[j])
      {
        a.Remove(i - k, 1);
        k++;
        continue;
      }
      if (j < s.Length - 1)
        j++;
    }
    return a.Equals(s);
  }
}