using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task21 : ILeetCodeTask<ListNode>
    {
        ListNode l1 = new() { val = 1, next = new() { val = 2, next = new() { val = 4, } } };
        ListNode l2 = new() { val = 1, next = new() { val = 3, next = new() { val = 4 } } };
        //ListNode l1 = new(2);
        //ListNode l2 = new(1);
        //ListNode l1 = new() { val = -2, next = new() { val = 5 } };
        //ListNode l2 = new() { val = -9, next = new() { val = -6, next = new() { val = -3, next = new() { val = -1, next = new() { val = 1, next = new() { val = 5, next = new() { val = 6 } } } } } } };

        public ListNode Invoke()
        {
            return MergeTwoLists(l1, l2);
        }

        public ListNode MergeTwoListsNonSorted(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                (list1, list2) = (list2, list1);

            ListNode head = list1;
            while (list2 != null)
            {
                list1 = head;
                ListNode current = list2;
                list2 = list2.next;
                while (list1 != null)
                {
                    if (list1.val >= current.val)
                    {
                        current.next = list1;
                        head = current;
                        break;
                    }

                    ListNode next = list1.next;

                    if (next == null)
                    {
                        if (list1.val <= current.val)
                        {
                            current.next = null;
                            list1.next = current;
                        }
                        else
                        {
                            current.next = list1;
                            head = current;
                        }
                        break;
                    }

                    if (next.val >= current.val)
                    {
                        current.next = next;
                        list1.next = current;
                        break;
                    }

                    list1 = list1.next;
                }
            }
            return head;
        }
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode current = new ListNode();
            ListNode head = current;

            while (list1 != null || list2 != null)
            {
                var val1 = list1 != null ? list1.val : int.MaxValue;
                var val2 = list2 != null ? list2.val : int.MaxValue;
                if (val1 < val2)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }

                current = current.next;
            }

            return head.next;
        }
    }
}
