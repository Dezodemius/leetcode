using System;

namespace Tasks.Task11;

public class Solution
{
  public int MaxArea(int[] height)
  {
    var maxSquare = 0;

    for (int i = 0; i < height.Length; i++)
    {
      for (int j = 0; j < height.Length; j++)
      {
        var x = Math.Abs(i - j);
        var y = Math.Min(height[i], height[j]);
        var s = x * y;
        if (s > maxSquare)
          maxSquare = s;
      }
    }

    return maxSquare;
  }
}