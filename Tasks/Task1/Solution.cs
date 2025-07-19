using System;
using System.Collections.Generic;

namespace Tasks.Task1;

public class Solution
{
  public int[] TwoSum(int[] nums, int target)
  {
    var dic1 = new Dictionary<int, int >();

    for (int i = 0; i < nums.Length; i++)
    {
      var diff =  target - nums[i];
      if (dic1.TryGetValue(diff, out var value))
        return [i, value];
      dic1[nums[i]] = i;
    }

    return [];
  }
}