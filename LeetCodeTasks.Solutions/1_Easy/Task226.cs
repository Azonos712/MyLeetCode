using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task226 : ILeetCodeTask<TreeNode>
    {
        public TreeNode Invoke() => InvertTree(null);

        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null || (root.left == null && root.right == null))
                return root;

            var left = InvertTree(root.left);
            var right = InvertTree(root.right);

            root.left = right;
            root.right = left;

            return root;
        }
    }
}
