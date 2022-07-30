using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task328 : ILeetCodeTask<ListNode>
    {
        ListNode _head = new ListNode() { val = 1, next = new ListNode() { val = 2, next = new ListNode() { val = 3, next = new ListNode() { val = 4, next = new ListNode() { val = 5 } } } } };

        public ListNode Invoke() => OddEvenList(_head);

        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
                return head;

            ListNode odd = head;
            ListNode oddStart = odd;
            ListNode even = head.next;
            ListNode evenStart = even;

            while (odd.next != null && even.next != null)
            {
                odd.next = odd.next?.next;
                odd = odd.next;

                even.next = even.next?.next;
                even = even.next;
            }

            odd.next = evenStart;

            return oddStart;
        }
    }
}
