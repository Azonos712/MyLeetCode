using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCodeTasks.NUnitTests._2_Medium
{
    internal class Task2Tests
    {
        readonly Task2 task = new();

        [TestCase(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, ExpectedResult = new int[] { 7, 0, 8 })]
        [TestCase(new int[] { 0 }, new int[] { 0 }, ExpectedResult = new int[] { 0 })]
        [TestCase(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, ExpectedResult = new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        public int[] Test2(int[] l1, int[] l2)
        {
            return task.AddTwoNumbers(new ListNode(l1), new ListNode(l2)).ToArray();
        }
    }
}
