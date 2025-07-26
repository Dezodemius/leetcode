using System.Collections.Generic;

namespace Tasks.Task1137;

public class Solution
{
  public int Tribonacci(int n)
  {
    var list = new List<int>();
    if (n == 0 )
      return 0;
    if (n == 2 || n == 1)
      return 1;

    list.Add(0);
    list.Add(0);
    list.Add(1);
    for (int i = 2; i <= n; i++)
    {
      list.Add(list[i - 2] + list[i - 1] + list[i]);
    }
    return list[^1];
  }
}