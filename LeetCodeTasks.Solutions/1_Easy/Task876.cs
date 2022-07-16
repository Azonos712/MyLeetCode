using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task876 : ILeetCodeTask<ListNode>
    {
        ListNode l1 = new() { val = 1, next = new() { val = 2, next = new() { val = 3, next = new() { val = 4 } } } };

        public ListNode Invoke()
        {
            return MiddleNode(l1);
        }

        public ListNode MiddleNode(ListNode head)
        {
            ListNode mid = head;
            int length = 0;

            while (head != null)
            {
                head = head.next;
                length++;
            }

            int midIndex = length / 2 ;
            length = 0;
            while (length != midIndex)
            {
                mid = mid.next;
                length++;
            }

            return mid;
        }
    }
}
