using System.Linq;

namespace Tasks.Task136;

public class Solution {
  public int SingleNumber(int[] nums) {
    return nums
      .GroupBy(n => n)
      .Single(g => g.Count() == 1)
      .First();
  }
}