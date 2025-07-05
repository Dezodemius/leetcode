namespace Tasks.Task206;


public class ListNode
{ public int val;
  public ListNode next;

  public ListNode(int val = 0, ListNode next = null)
  {
    this.val = val;
    this.next = next;
  }
}

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