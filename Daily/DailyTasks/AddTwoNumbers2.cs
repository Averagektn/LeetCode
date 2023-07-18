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
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        l1 = Reverse(l1);
        l2 = Reverse(l2);

        var carry = 0;
        var res = l1;
        var tail = res;

        while (l1 != null)
        {
            var tmp = (l1.val + l2.val + carry) % 10;

            carry = (l1.val + l2.val + carry) / 10;
            l1.val = tmp;

            l2 = l2.next;
            l1 = l1.next;
        }

        while (tail.next != null)
        {
            tail = tail.next;
        }

        while (l2 != null)
        {
            tail.next = new ListNode(l2.val);
            l2 = l2.next;
            tail = tail.next;
        }

        return Reverse(res);
    }

    private static ListNode Reverse(ListNode list)
    {
        ListNode prev = null;
        var curr = list;

        while (curr != null)
        {
            var next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
}