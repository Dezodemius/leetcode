namespace Tasks.Task724;

public class Solution
{
  public int PivotIndex(int[] nums)
  {
    for (var i = 0; i < nums.Length; i++)
    {
      var leftsum = 0;
      var rightsum = 0;

      for (var j = 0; j < i; j++)
      {
        leftsum += nums[j];
      }
      for (var j = i + 1; j < nums.Length; j++)
      {
        rightsum += nums[j];
      }

      if (leftsum == rightsum)
        return i;
    }

    return -1;
  }
}