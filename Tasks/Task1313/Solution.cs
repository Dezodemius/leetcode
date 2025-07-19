using System.Collections.Generic;

namespace Tasks.Task1313;

public class Solution {
  public int[] DecompressRLElist(int[] nums) {
    var result = new List<int>();
    for (int i = 0; i < nums.Length - 1; i += 2)
    {
      var freq = nums[i];
      var val = nums[i + 1];
      for (int j = 0; j < freq; j++)
        result.Add(val);
    }

    return result.ToArray();
  }
}