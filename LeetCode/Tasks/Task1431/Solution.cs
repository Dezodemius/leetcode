namespace Tasks.Task1431;

public class Solution {
  public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
  {
    var max = candies.Max();
    var result = new List<bool>(candies.Length);
    for (var i = 0; i < candies.Length; i++)
      result.Add(candies[i] + extraCandies >= max);
    return result;
  }
}