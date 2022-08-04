using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.NUnitTests._2_Medium
{
    internal class Task173Tests
    {
        static object[] cases =
        {
            new object[] { new int?[] { 7, 3, 15, null, null, 9, 20 }, new int[] { 3, 7, 9, 15, 20} },
        };

        [TestCaseSource(nameof(cases))]
        public void Test1(int?[] nums, int[] result)
        {
            Task173.BSTIterator iterator = new Task173.BSTIterator(TreeNode.CreateTreeFromArray(nums));
            List<int> list = new List<int>();
            while (iterator.HasNext())
                list.Add(iterator.Next());

            Assert.AreEqual(list.ToArray(), result);
        }
    }
}
