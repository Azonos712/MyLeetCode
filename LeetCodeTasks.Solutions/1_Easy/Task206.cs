using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task206 : ILeetCodeTask<ListNode>
    {
        ListNode l1 = new() { val = 1, next = new() { val = 2, next = new() { val = 3, next = new() { val = 4 } } } };
        
        public ListNode Invoke()
        {
            return ReverseList(l1);
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode cur = head;

            while (cur != null)
            {
                ListNode next = cur.next;

                cur.next = prev;

                prev = cur;
                cur = next;
            }

            return prev;
        }
    }
}
