

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode prev = null;
        for(ListNode temp = head; temp != null; temp = temp.next)
        {
          if(temp.val == val && prev == null)
            {
                head = temp.next;
            }
            else if(temp.val == val)
            {
                prev.next = temp.next;
            }
            else
            {
                prev = temp;
            }
        }
        return head;
    }

    static void Main(string[] args)
    {

    }
}