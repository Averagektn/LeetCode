namespace Initial
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

    public class Palindrome
    {
        public bool IsPalindrome(ListNode? head)
        {
            var num = 0;
            var rev = 0;
            var mul = 1;

            while (head != null)
            {
                num = num * 10 + head.val;
                rev += head.val * mul;
                mul *= 10;
                head = head.next;
            }

            return num == rev;
        }
    }
}
