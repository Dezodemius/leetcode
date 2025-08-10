using TaskUtils;

namespace Tasks.Task2095;

public class Solution
{
    public ListNode DeleteMiddle(ListNode head)
    {
        var temp = new ListNode();
        temp.next = head;
        var slow =  temp;
        var fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        slow.next = slow.next.next;
        return temp.next;
    }
}