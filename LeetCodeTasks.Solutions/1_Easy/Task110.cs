using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task110 : ILeetCodeTask<bool>
    {
        public bool Invoke() => IsBalanced(null);

        public bool IsBalanced(TreeNode root)
        {
            return Walk(root).Item1;
        }

        private (bool, int) Walk(TreeNode node)
        {
            if (node == null)
                return (true, 0);

            var l = Walk(node.left);
            var r = Walk(node.right);
            var balance = l.Item1 && r.Item1 && Math.Abs(l.Item2 - r.Item2) <= 1;

            return (balance, 1 + Math.Max(l.Item2, r.Item2));
        }
    }
}
