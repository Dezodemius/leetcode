namespace Tasks.Task334;

public class Solution
{
  public bool IncreasingTriplet(int[] nums)
  {
    int i = 0;
    int j = 1;
    int k = 2;

    for (int l = 0; l < nums.Length; l++)
    {
      bool indexes = i < j && j < k;
      bool values = nums[i] < nums[j] && nums[j] < nums[k];
      if (indexes && values)
        return true;
      else
      {
        i++;
        j++;
        k++;
      }
      if (k == nums.Length)
        return false;
    }

    return false;
  }
}