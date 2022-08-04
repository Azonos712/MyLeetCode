using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.NUnitTests._2_Medium
{
    internal class Task230Tests
    {
        readonly Task230 task = new();

        static object[] cases =
        {
            new object[] { new int?[] { 3, 1, 4, null, 2, null, null }, 1, 1},
            new object[] { new int?[] { 5, 3, 6, 2, 4, null, null, 1, null, null, null, null, null, null, null }, 3, 3},
        };

        [TestCaseSource(nameof(cases))]
        public void Test1(int?[] nums, int k, int result)
        {
            Assert.AreEqual(task.KthSmallest(TreeNode.CreateTreeFromArray(nums), k), result);
        }
    }
}
