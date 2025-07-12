namespace Tasks.Task334;

public class Solution
{
  public bool IncreasingTriplet(int[] nums)
  {
    if (nums.Length < 3)
      return false;

    var first = int.MaxValue;
    var second = int.MaxValue;

    foreach (var num in nums)
    {
      if (first >= num)
        first = num;
      else if (second >= num)
        second = num;
      else
        return true;
    }

    return false;
  }
}