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
    ListNode previous = null;
    while (head != null)
    {
      var temp  = head.next;
      head.next = previous;
      previous = head;
      head = temp;
    }

    return previous;
  }
}