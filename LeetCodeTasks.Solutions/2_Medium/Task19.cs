using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task19 : ILeetCodeTask<ListNode>
    {
        //ListNode _head = new ListNode() { val = 1, next = new ListNode() { val = 2, next = new ListNode() { val = 3, next = new ListNode() { val = 4, next = new ListNode() { val = 5 } } } } };

        //ListNode _head = new ListNode() { val = 1, next = new ListNode() { val = 2, } };
        //ListNode _head = new ListNode() { val = 1 };
        ListNode _head = new ListNode() { val = 1, next = new ListNode() { val = 2 } };

        public ListNode Invoke() => RemoveNthFromEnd(_head, 2);

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int counter = 0;
            ListNode result = head;
            ListNode marked = head;

            while (head != null)
            {
                if (counter > n)
                    marked = marked.next;

                head = head.next;
                counter++;
            }

            if (counter == n)
                result = result.next;
            else
                marked.next = marked.next.next;

            return result;
        }
    }
}