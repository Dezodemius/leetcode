using System;

namespace Tasks.Task11;

public class Solution
{
  public int MaxArea(int[] height)
  {
    var maxSquare = 0;

    var i = 0;
    var j = height.Length - 1;

    while (i != j)
    {
      var x = Math.Abs(i - j);
      var y = Math.Min(height[i], height[j]);
      var s = x * y;
      if (s > maxSquare)
        maxSquare = s;
      if (height[i] < height[j]) i++;
      else j--;
    }

    return maxSquare;
  }
}