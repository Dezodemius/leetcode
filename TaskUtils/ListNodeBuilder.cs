namespace TaskUtils;

public static class ListNodeBuilder
{
  public static ListNode BuildListNodeFromArray(int[] nums, int index)
  {
    if (!nums.Any())
      return new ListNode();
    if (index >= nums.Length - 1)
      return new ListNode(nums[index]);

    return new ListNode(nums[index], BuildListNodeFromArray(nums, ++index));
  }
}