namespace TopInterview
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Add
    {
        public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
        {
            var head = new ListNode();
            var curr = head;
            var carry = 0;

            while (l1 != null || l2 != null)
            {
                var sum = carry + (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0);
                var num = sum % 10;
                carry = sum / 10;

                curr.next = new ListNode(num);
                curr = curr.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }


            return head.next;
        }
    }
}
