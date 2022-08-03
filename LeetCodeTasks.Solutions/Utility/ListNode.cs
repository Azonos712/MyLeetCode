using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions.Utility
{
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

        public ListNode(params int[] values)
        {
            ListNode p = this;
            for (int i = 0; i < values.Length; i++)
            {
                p.val = values[i];
                if (i + 1 < values.Length)
                    p.next = new ListNode();
                p = p.next;
            }
        }

        public int[] ToArray()
        {
            List<int> list = new();

            ListNode p = this;
            while (p != null)
            {
                list.Add(p.val);
                p = p.next;
            }

            return list.ToArray();
        }
    }
}
