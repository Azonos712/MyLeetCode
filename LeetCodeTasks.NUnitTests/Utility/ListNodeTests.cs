using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.NUnitTests.Utility
{
    internal class ListNodeTests
    {
        [TestCase(new int[] { 2, 4, 3 }, ExpectedResult = new int[] { 2, 4, 3 })]
        [TestCase(new int[] { 0 }, ExpectedResult = new int[] { 0 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        public int[] Test1(int[] arr)
        {
            return ListNode.CreateArrayFromList(ListNode.CreateListFromArray(arr));
        }
    }
}
