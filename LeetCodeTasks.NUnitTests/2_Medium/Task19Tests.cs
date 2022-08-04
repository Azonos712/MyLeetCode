using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.NUnitTests._2_Medium
{
    internal class Task19Tests
    {
        readonly Task19 task = new();

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, ExpectedResult = new int[] { 1, 2, 3, 5 })]
        [TestCase(new int[] { 1, }, 1, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 1, 2 }, 1, ExpectedResult = new int[] { 1 })]
        public int[] Test1(int[] nums, int n)
        {
            return ListNode.CreateArrayFromList(task.RemoveNthFromEnd(ListNode.CreateListFromArray(nums), n));
        }
    }
}
