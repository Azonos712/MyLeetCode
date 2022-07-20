using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task235 : ILeetCodeTask<TreeNode>
    {
        TreeNode _root = new TreeNode
        {
            val = 2,
            left = new TreeNode
            {
                val = 1,
                right = new TreeNode
                {
                    val = 5,
                    left = new TreeNode
                    {
                        val = 4
                    }
                }
            },
            right = new TreeNode
            {
                val = 6,
                right = new TreeNode
                {
                    val = 9
                }
            }
        };

        TreeNode _p = new TreeNode { val = 1 };
        TreeNode _q = new TreeNode { val = 6 };

        public TreeNode Invoke() => LowestCommonAncestor(_root, _p, _q);

        /// <summary>
        /// Time: O(logn) / Memory: O(1)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            while (root != null)
            {
                if (p.val > root.val && q.val > root.val)
                    root = root.right;
                else if (p.val < root.val && q.val < root.val)
                    root = root.left;
                else
                    return root;
            }

            return null;
        }
    }
}
