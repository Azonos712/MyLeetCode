using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task148 : ILeetCodeTask<ListNode>
    {
        ListNode _head = new ListNode() { val = -1, next = new ListNode() { val = 5, next = new ListNode() { val = 3, next = new ListNode() { val = 4, next = new ListNode() { val = 0 } } } } };

        public ListNode Invoke() => SortList(_head);

        public ListNode SortList(ListNode head)
        {
            if (head == null)
                return head;

            ListNode pivot = head;
            head = head.next;
            ListNode leftStart = null;
            ListNode leftEnd = null;
            ListNode rightStart = null;
            ListNode rightEnd = null;

            while (head != null)
            {
                ListNode current = head;
                head = head.next;
                current.next = null;

                if (pivot.val >= current.val)
                    InsertInList(ref leftStart, ref leftEnd, current);
                else
                    InsertInList(ref rightStart, ref rightEnd, current);
            }

            if (leftEnd == null)
                leftStart = pivot;
            else
                leftEnd.next = pivot;

            pivot.next = rightStart;

            return leftStart;
        }

        private static void InsertInList(ref ListNode start, ref ListNode end, ListNode current)
        {
            if (start == null)
            {
                start = current;
                end = start;
            }
            else
            {
                if (start.val >= current.val)
                {
                    current.next = start;
                    start = current;
                }
                else if (end.val <= current.val)
                {
                    end.next = current;
                    end = current;
                }
                else
                {
                    ListNode left = start;
                    while (left.next.val < current.val)
                        left = left.next;

                    current.next = left.next;
                    left.next = current;
                }
            }
        }
    }
}
