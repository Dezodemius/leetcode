namespace TaskUtils;

public class ListNode
{
  public int val;
  public ListNode next;

  public override bool Equals(object? obj)
  {
    if (obj is ListNode node)
    {
      
    }
    return base.Equals(obj);
  }

  public ListNode(int val = 0, ListNode next = null)
  {
    this.val = val;
    this.next = next;
  }
}