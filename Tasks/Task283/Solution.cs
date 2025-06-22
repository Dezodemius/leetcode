namespace Tasks.Task283;

public class Solution
{
  public void MoveZeroes(int[] nums) {
    var temp = new List<int>(nums);
    var zeros = 0;
    var j = 0;
    for (int i = 0; i < temp.Count; i++)
    {
      if (temp[i] == 0)
      {
        nums[temp.Count - zeros - 1] = temp[i];
        zeros++;
      }
      else
      {
        nums[i - zeros] = temp[i];
      }
    }
  }
}