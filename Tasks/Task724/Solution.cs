namespace Tasks.Task724;

public class Solution
{
  public int PivotIndex(int[] nums)
  {
    var leftsum = 0;
    var rightsum = 0;

    for (int i = 1; i < nums.Length; i++)
      rightsum += nums[i];

    if (rightsum == 0)
      return 0;
    for (int i = 0; i < nums.Length - 1; i++)
    {
      leftsum += nums[i];
      rightsum -= nums[i + 1];
      if (leftsum == rightsum)
        return i + 1;
    }

    return -1;
  }
}