namespace Initial
{
    public class Middle_of_the_Linked_List
    {
        public ListNode? MiddleNode(ListNode? head)
        {
            ListNode? end = head;

            while (end != null && end.next != null)
            {
                end = end.next.next;
                head = head!.next;
            }

            return head;
        }
    }
}
