using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task543 : ILeetCodeTask<int>
    {
        public int Invoke() => DiameterOfBinaryTree(null);

        public int DiameterOfBinaryTree(TreeNode root)
        {
            int result = 0;

            int DFS(TreeNode node)
            {
                if (node == null)
                    return -1;
                var l = DFS(node.left);
                var r = DFS(node.right);

                result = Math.Max(result, 2 + l + r);

                return 1 + Math.Max(l, r);
            }

            DFS(root);

            return result;
        }
    }
}
