using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task108
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return sortedBST(nums, 0, nums.Length - 1);
        }

        private TreeNode sortedBST(int[] nums, int low, int high)
        {
            if (low > high) return null;
            int temp = (low + high) / 2;
            TreeNode node = new TreeNode(nums[temp]);
            node.left = sortedBST(nums, low, temp - 1);
            node.right = sortedBST(nums, temp + 1, high);
            return node;
        }
    }
}
