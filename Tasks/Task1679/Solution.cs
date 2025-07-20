using System;

namespace Tasks.Task1679;

public class Solution
{
  public int MaxOperations(int[] nums, int k)
  {
    var counter = 0;
    Array.Sort(nums);
    var i = 0;
    var j = nums.Length - 1;
  
    while (i < j)
    {
      var sum = nums[i] + nums[j];
      if (sum > k)
        j--;
      else if (sum < k)
        i++;
      else
      {
        counter++;
        i++;
        j--;
      }
    }
    return counter;
  }
}