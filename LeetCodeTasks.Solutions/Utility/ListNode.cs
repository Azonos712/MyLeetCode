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

        public static ListNode CreateListFromArray(params int[] values)
        {
            if (values.Length == 0)
                return null;

            ListNode node = new ListNode();
            ListNode start = node;

            for (int i = 0; i < values.Length; i++)
            {
                node.val = values[i];
                if (i + 1 < values.Length)
                    node.next = new ListNode();
                node = node.next;
            }

            return start;
        }

        public static int[] CreateArrayFromList(ListNode node)
        {
            List<int> list = new();

            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }

            return list.ToArray();
        }
    }
}
