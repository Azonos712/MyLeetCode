using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task142 : ILeetCodeTask<ListNode>
    {
        ListNode l1 = new() { val = 1, next = new() { val = 2, next = new() { val = 3, next = new() { val = 4 } } } };

        public ListNode Invoke()
        {
            return DetectCycle(l1);
        }

        /// <summary>
        /// Time: O(n) / Memory: O(n)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DetectCycleWithHashTable(ListNode head)
        {
            HashSet<ListNode> set = new();

            while (head != null)
                if (set.Add(head))
                    head = head.next;
                else
                    return head;

            return null;
        }

        /// <summary>
        /// Time: O(n) / Memory: O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DetectCycle(ListNode head)
        {
            //two pointers: slow and fast
            return null;
        }
    }
}
