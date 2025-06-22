namespace Tasks.Task283;

public class Solution
{
  public void MoveZeroes(int[] nums) {
    for (int i = nums.Length - 1; i >= 0; i--)
    {
      if (nums[i] == 0)
      {
        for (int j = i; j < nums.Length - 1; j++)
        {
          var temp = nums[j+1];
          nums[j+1] = nums[j];
          nums[j] = temp;
        }
      }
    }
  }
}