using TaskUtils;

namespace Tasks.Task206;

public class Solution
{
  public ListNode ReverseList(ListNode head)
  {
    if (head == null || head.next == null)
      return head;

    var rest = ReverseList(head.next);
    
    head.next.next = head;
    head.next = null;

    return rest;
  }
}