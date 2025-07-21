namespace Tasks.Task704;

public class Solution {
  public int Search(int[] nums, int target) {
    if (nums.Length == 0)
      return -1;

    var left = 0;
    var right = nums.Length - 1;

    while (true)
    {
      if (left > right)
        break;
      var mid = left + (right - left) / 2;

      if (nums[mid] == target)
        return mid;
      if (nums[mid] > target)
        right = mid - 1;
      else if (nums[mid] < target)
        left = mid + 1;
    }

    return -1;

  }
}