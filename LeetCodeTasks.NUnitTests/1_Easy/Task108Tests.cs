using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.NUnitTests._1_Easy
{
    internal class Task108Tests
    {
        readonly Task108 task = new();

        static object[] cases =
        {
            new object[] { new int[] { 2, 3, 4 }, new int?[] { 3, 2, 4 }},
            new object[] { new int[] { 0 }, new int?[] { 0 }},
            new object[] { new int[] { -10, -3, 0, 5, 9 }, new int?[] { 0, -10, 5, null, -3, null, 9 } },
            new object[] { new int[] { 1, 3 }, new int?[] { 1, null, 3 } }
        };

        [TestCaseSource(nameof(cases))]
        public void Test1(int[] nums, int?[] result)
        {
            Assert.AreEqual(TreeNode.CreateArrayFromTree(task.SortedArrayToBST(nums)), result);
        }
    }
}
