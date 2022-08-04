using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.NUnitTests._1_Easy
{
    internal class Task141Tests
    {
        readonly Task141 task = new();

        [TestCase(new int[] { 3, 2, 0, -4 }, ExpectedResult = true)]
        public bool Test1(int[] nums)
        {
            ListNode start = ListNode.CreateListFromArray(nums);
            ListNode node = start;
            while (node.next != null)
                node = node.next;
            node.next = start;
            return task.HasCycle(start);
        }

        [TestCase(new int[] { 1, 2 }, ExpectedResult = false)]
        [TestCase(new int[] { 1 }, ExpectedResult = false)]
        public bool Test2(int[] nums)
        {
            return task.HasCycle(ListNode.CreateListFromArray(nums));
        }
    }
}
