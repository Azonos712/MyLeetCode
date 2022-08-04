using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task173
    {
        public class BSTIterator
        {
            private Stack<TreeNode> _helper;

            public BSTIterator(TreeNode root)
            {
                _helper = new Stack<TreeNode>();

                while (root != null)
                {
                    _helper.Push(root);
                    root = root.left;
                }
            }

            public int Next()
            {
                TreeNode result = _helper.Pop();
                TreeNode node = result.right;

                while (node != null)
                {
                    _helper.Push(node);
                    node = node.left;
                }

                return result.val;
            }

            public bool HasNext() => _helper.Count() != 0;
        }
    }
}
