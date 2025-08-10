namespace TaskUtils;

public static class ListNodeUtils
{
  public static ListNode BuildListNodeFromArray(int[] nums, int index)
  {
    if (!nums.Any())
      return new ListNode();
    if (index >= nums.Length - 1)
      return new ListNode(nums[index]);

    return new ListNode(nums[index], BuildListNodeFromArray(nums, ++index));
  }

  public static int[] BuildArrayFromListNode(ListNode node)
  {
    if (node == null)
      return [];

    var res = new List<int>();

    void BuildList(ListNode _node)
    {
      if (_node == null)
        return;
      res.Add(_node.val);
      BuildList(_node.next);
    }

    BuildList(node);
    
    return res.ToArray();
  }

}