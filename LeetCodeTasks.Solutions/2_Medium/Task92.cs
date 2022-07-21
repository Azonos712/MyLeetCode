using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task92 : ILeetCodeTask<ListNode>
    {
        ListNode _head = new() { val = 1, next = new() { val = 2, next = new() { val = 3, next = new() { val = 4, next = new() { val = 5 } } } } };
        public ListNode Invoke() => ReverseBetween(_head, 2, 4);

        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode prev = null;
            ListNode cur = head;
            for (int i = 0; i < left - 1; i++)
            {
                prev = cur;
                cur = cur.next;
            }

            ListNode conn = prev;
            ListNode newTail = cur;

            for (int i = left - 1; i < right; i++)
            {
                var next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }

            newTail.next = cur;

            if (conn != null)
                conn.next = prev;
            else
                head = prev;

            return head;
        }
    }
}
