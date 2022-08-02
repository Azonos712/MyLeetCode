using LeetCodeTasks.Solutions._1_Easy;
using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task437 : ILeetCodeTask<int>
    {
        public int Invoke() => PathSum(null, 8);

        public int PathSum(TreeNode root, int targetSum)
        {
            if (root == null) return 0;
            return PathSumFrom(root, targetSum) + PathSum(root.left, targetSum) + PathSum(root.right, targetSum);
        }

        private int PathSumFrom(TreeNode node, long sum)
        {
            if (node == null) return 0;
            return (node.val == sum ? 1 : 0)
                + PathSumFrom(node.left, sum - node.val) + PathSumFrom(node.right, sum - node.val);
        }
    }
}
