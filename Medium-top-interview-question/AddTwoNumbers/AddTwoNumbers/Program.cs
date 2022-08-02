
namespace Pr
{
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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var head = new ListNode();
            var current = head;
            while (l1 != null || l2 != null)
            {

                var x = (l1 != null) ? l1.val : 0;
                var y = (l2 != null) ? l2.val : 0;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;

                var sum = x + y + current.val;
                var fund = sum / 10;

                current.val = sum % 10;

                if (l1 != null || l2 != null || fund > 0)
                {
                    var next = new ListNode();
                    next.val += fund;
                    current.next = next;
                    current = next;
                }
            }
            return head;
        }
        
    }

    public class Program
    {
        public static void Main()
        {
            
        }
    }
}

