using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task234 : ILeetCodeTask<bool>
    {
        ListNode _head = new ListNode() { val = 1, next = new ListNode() { val = 2, next = new ListNode() { val = 2, next = new ListNode() { val = 1 } } } };

        public bool Invoke() => IsPalindrome(_head);

        /// <summary>
        /// Time: O(n) / Memory: O(n)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindrome(ListNode head)
        {
            List<ListNode> list = new List<ListNode>();
            while (head != null)
            {
                list.Add(head);
                head = head.next;
            }

            int l = 0, r = list.Count - 1;
            while (l <= r)
            {
                if (list[l].val != list[r].val)
                    return false;

                l++;
                r--;
            }

            return true;
        }
    }
}