
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.NUnitTests._1_Easy
{
    internal class Task1Tests
    {
        readonly Task1 task = new();

        [TestCase(new int[] { 2, 7, 11, 15 }, 9, ExpectedResult = new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, ExpectedResult = new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 3 }, 6, ExpectedResult = new int[] { 0, 1 })]
        public int[] Test1(int[] nums, int target)
        {
            return task.TwoSumFast(nums, target);
        }

        [TestCase(new int[] { 2, 7, 11, 15 }, 9, ExpectedResult = new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, ExpectedResult = new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 3 }, 6, ExpectedResult = new int[] { 0, 1 })]
        public int[] Test2(int[] nums, int target)
        {
            return task.TwoSumSlow(nums, target);
        }
    }
}
