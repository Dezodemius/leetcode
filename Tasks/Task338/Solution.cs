using System;
using System.Linq;

namespace Tasks.Task388;

public class Solution
{
  public int[] CountBits(int n)
  {
    var ans = new int[n + 1];

    for (int i = 0; i <= n; i++)
    {
      var a = Convert.ToString(i, 2);
      ans[i] = a.Count(j => j == '1');
    }

    return ans;
  }
}