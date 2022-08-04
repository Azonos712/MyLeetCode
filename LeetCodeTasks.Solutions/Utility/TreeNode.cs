using LeetCodeTasks.Solutions._1_Easy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions.Utility
{
    [DebuggerDisplay("Val = {val}")]
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static TreeNode CreateTreeFromArray(int?[] arr, int i = 0)
        {
            TreeNode root = null;

            if (i < arr.Length)
            {
                var element = arr[i];
                if (element.HasValue)
                {
                    root = new TreeNode(element.Value);
                    root.left = CreateTreeFromArray(arr, 2 * i + 1);
                    root.right = CreateTreeFromArray(arr, 2 * i + 2);
                }
            }

            return root;
        }

        public static int?[] CreateArrayFromTree(TreeNode node)
        {
            List<int?> list = new List<int?>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(node);
            while (queue.Count != 0)
            {
                if (!queue.Any(x => x != null))
                    break;

                if (queue.Peek() != null)
                    queue.Enqueue(queue.Peek().left);

                if (queue.Peek() != null)
                    queue.Enqueue(queue.Peek().right);

                TreeNode element = queue.Dequeue();
                if (element == null)
                    list.Add(null);
                else
                    list.Add(element.val);
            }

            return list.ToArray();
        }
    }
}
