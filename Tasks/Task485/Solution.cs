namespace Tasks.Task485;

public class Solution
{
  public int FindMaxConsecutiveOnes(int[] nums)
  {
    var res = 0;
    var count = res;
    foreach (var num in nums)
    {
      if (num == 1)
        count++;
      else
      {
        if (count > res)
          res = count;
        count = 0;
      }
    }
    if (count > res)
      res = count;

    return res;
  }
}