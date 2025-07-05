using System.Collections.Generic;

namespace Tasks.Task1431;

public class Solution {
  public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
  {
    var max = 0;
    for (var i = 0; i < candies.Length; i++)
      if (candies[i] >= max)
        max = candies[i];

    var result = new List<bool>(candies.Length);
    for (var i = 0; i < candies.Length; i++)
      result.Add(candies[i] + extraCandies >= max);
    return result;
  }
}