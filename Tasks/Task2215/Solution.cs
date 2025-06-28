namespace Tasks.Task2215;

public class Solution
{
  public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
    var a = nums1.Except(nums2).ToList();
    var b = nums2.Except(nums1).ToList();

    return new List<IList<int>> { a, b };
  }
}