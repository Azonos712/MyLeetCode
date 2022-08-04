using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.NUnitTests.Utility
{
    internal class TreeNodeTests
    {
        static object[] cases =
        {
            new object[] { new int?[] { 2, 4, 3 }, new int?[] { 2, 4, 3 }},
            new object[] { new int?[] { 0 }, new int?[] { 0 }},
            new object[] { new int?[] { 1, 2, 3, 4, null, null, 5 }, new int?[] { 1, 2, 3, 4, null, null, 5 } },
            new object[] { new int?[] { }, new int?[] { } }
        };

        [TestCaseSource(nameof(cases))]
        public void Test1(int?[] arr1, int?[] arr2)
        {
            Assert.That(arr2, Is.EqualTo(TreeNode.CreateArrayFromTree(TreeNode.CreateTreeFromArray(arr1))));
        }
    }
}
