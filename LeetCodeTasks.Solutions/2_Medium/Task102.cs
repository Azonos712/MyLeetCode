using LeetCodeTasks.Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task102 : ILeetCodeTask<IList<IList<int>>>
    {
        TreeNode input = new TreeNode { val = 1, left = new TreeNode { val = 2, right = new TreeNode { val = 5, left = new TreeNode { val = 7 } } }, right = new TreeNode { val = 3, right = new TreeNode { val = 4 } } };
        public IList<IList<int>> Invoke()
        {
            return LevelOrder(input);
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            SortedDictionary<int, List<int>>? levels = new SortedDictionary<int, List<int>>();
            GoToNext(root, levels, 0);

            var result = levels.Select(x => x.Value).Cast<IList<int>>().ToList();
            return result;
        }

        private void GoToNext(TreeNode node, SortedDictionary<int, List<int>> levels, int lvl)
        {
            if (node == null)
                return;

            if (!levels.ContainsKey(lvl))
                levels.Add(lvl, new List<int>());

            levels[lvl].Add(node.val);
            GoToNext(node.left, levels, lvl + 1);
            GoToNext(node.right, levels, lvl + 1);
        }
    }
}
