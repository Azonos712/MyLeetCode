using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task230
    {
        public int KthSmallest(TreeNode root, int k)
        {
            return Solve(root, ref k);
        }

        private int Solve(TreeNode root, ref int k)
        {
            if (root == null)
                return 0;

            int left = Solve(root.left, ref k);
            if (left >= 1)
                return left;
            
            k -= 1;
            
            if (k == 0)
                return root.val;
            int right = Solve(root.right, ref k);
            return right;
        }
    }
}
