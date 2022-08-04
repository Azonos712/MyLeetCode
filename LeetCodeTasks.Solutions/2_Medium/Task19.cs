using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int counter = 0;
            ListNode right = head;
            ListNode left = head;

            while (right != null)
            {
                if (counter > n)
                    left = left.next;

                right = right.next;
                counter++;
            }

            if (counter == n)
                return head.next;

            left.next = left.next.next;

            return head;
        }
    }
}