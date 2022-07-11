using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeTasks.Solutions._2_Medium.Task2;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task2 : ILeetCodeTask<ListNode>
    {
        //ListNode l1 = new() { val = 2, next = new() { val = 4, next = new() { val = 3 } } };
        //ListNode l2 = new() { val = 5, next = new() { val = 6, next = new() { val = 4 } } };
        ListNode l1 = new() { val = 9, next = new() { val = 9, next = new() { val = 9, next = new() { val = 9, next = new() { val = 9, next = new() { val = 9, next = new() { val = 9 } } } } } } };
        ListNode l2 = new() { val = 9, next = new() { val = 9, next = new() { val = 9, next = new() { val = 9 } } } };

        public ListNode Invoke()
        {
            return AddTwoNumbers(l1, l2);
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            ListNode current = null;
            int rest = 0;
            while (l1 != null || l2 != null || rest != 0)
            {
                ListNode newNode = new ListNode();

                int val1 = l1 != null ? l1.val : 0;
                int val2 = l2 != null ? l2.val : 0;
                int val = val1 + val2;
                newNode.val = (val + rest) % 10;
                rest = (val + rest) / 10;

                l1 = l1?.next;
                l2 = l2?.next;

                if (current == null)
                {
                    current = newNode;
                    head = current;
                }
                else
                {
                    current.next = newNode;
                    current = current.next;
                }
            }

            return head;
        }

        [DebuggerDisplay("Val = {val}, Next = {next}")]
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
