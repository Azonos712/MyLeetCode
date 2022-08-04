using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task141
    {
        public bool HasCycle(ListNode head)
        {
            ListNode p1 = head, p2 = head;

            while (p2 != null && p2.next != null)
            {
                p1 = p1.next;
                p2 = p2.next.next;

                if (p1 == p2)
                    return true;
            }

            return false;
        }
    }
}
