using LeetCodeTasks.Solutions._1_Easy;
using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task98 : ILeetCodeTask<bool>
    {
        //TreeNode input = new TreeNode { val = 2, left = new TreeNode { val = 1, right = new TreeNode { val = 5, left = new TreeNode { val = 4 } } }, right = new TreeNode { val = 6, right = new TreeNode { val = 9 } } };
        TreeNode input = new TreeNode { val = 2, left = new TreeNode { val = 2 }, right = new TreeNode { val = 2 } };

        public bool Invoke() => IsValidBST(input);

        public bool IsValidBST(TreeNode root)
        {
            bool l = IsValidBST(root.left, long.MinValue, root.val);
            bool r = IsValidBST(root.right, root.val, long.MaxValue);
            return l && r;
        }

        private bool IsValidBST(TreeNode node, long lb, long rb)
        {
            if (node == null)
                return true;

            if (lb >= node.val || node.val >= rb)
                return false;

            bool l = IsValidBST(node.left, lb, node.val);
            bool r = IsValidBST(node.right, node.val, rb);

            return l && r;
        }
    }
}
