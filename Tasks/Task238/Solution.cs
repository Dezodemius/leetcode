using System.Collections.Generic;

namespace Tasks.Task238;

public class Solution
{
  public int[] ProductExceptSelf(int[] nums)
  {
    int n = nums.Length;
    int[] result = new int[n];

    result[0] = 1;
    for (int i = 1; i < n; i++)
      result[i] = nums[i - 1] * result[i - 1];

    var right = 1;
    for (int i = n - 1; i >= 0; i--)
    {
      result[i] *= right;
      right *= nums[i];
    }
    return result;
  }
}