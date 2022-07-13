using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task199 : ILeetCodeTask<IList<int>>
    {
        TreeNode input = new TreeNode { val = 1, left = new TreeNode { val = 2, right = new TreeNode { val = 5, left = new TreeNode { val = 7 } } }, right = new TreeNode { val = 3, right = new TreeNode { val = 4 } } };
        //TreeNode input = new TreeNode { val = 1, left = new TreeNode { val = 2 } };
        public IList<int> Invoke()
        {
            return RightSideView(input);
        }

        public IList<int> RightSideView(TreeNode root)
        {
            var levels = new SortedDictionary<int, HashSet<int>>();
            GoToNext(root, levels, 0);

            var result = levels.Select(x => x.Value.Last()).ToList();
            return result;
        }

        private void GoToNext(TreeNode node, SortedDictionary<int, HashSet<int>> levels, int lvl)
        {
            if (node == null)
                return;

            if (!levels.ContainsKey(lvl))
                levels.Add(lvl, new HashSet<int>());

            levels[lvl].Add(node.val);
            GoToNext(node.left, levels, lvl + 1);
            GoToNext(node.right, levels, lvl + 1);
        }

        public IList<int> RightSideViewAnother(TreeNode root)
        {
            List<int> res = new List<int>();
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count != 0)
            {
                TreeNode rightSide = null;
                var qLen = q.Count;

                for (int i = 0; i < qLen; i++)
                {
                    var node = q.Dequeue();
                    if (node != null)
                    {
                        rightSide = node;
                        q.Enqueue(node.left);
                        q.Enqueue(node.right);
                    }
                }

                if (rightSide != null)
                    res.Add(rightSide.val);
            }

            return res;
        }
    }
}
