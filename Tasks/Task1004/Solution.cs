namespace Tasks.Task1004;

public class Solution
{
  public int LongestOnes(int[] nums, int k)
  {
    var left = 0;
    var right = 0;
    var count = 0;
    var maxLength = 0;
    
    for (var i = 0; i < nums.Length; i++)
    {
      if (nums[i] == 1 && right < nums.Length)
        right++;
      else if (nums[i] == 0)
      {
        count++;
        right++;
      }
      if (count > k)
      {
        while (count > k)
        {
          if (nums[left] == 0)
            count--;
          left++;
        }
      }

      if (maxLength < right - left)
        maxLength = right - left;
    }
    
    return maxLength;
  }
}