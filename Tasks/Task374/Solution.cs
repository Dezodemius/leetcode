using System;

namespace Tasks.Task374;

public class Solution
{
  public int GuessNumber(int n, Func<int, int> guess)
  {
    if (guess(n) == 0)
      return n;

    var left = 0;
    var right = n;

    while (true)
    {
      if (left > right)
        break;
      var mid = left + (right - left) / 2;

      var a = guess(mid);

      if (a == 0)
        return mid;
      if (a == -1)
        right = mid;
      else if (a == 1)
        left = mid;
    }

    return -1;
  }
}