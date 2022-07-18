using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task589 : ILeetCodeTask<IList<int>>
    {
        Node _root = new Node { val = 1 };

        public IList<int> Invoke()
        {
            return Preorder(_root);
        }

        public IList<int> Preorder(Node root)
        {
            List<int> preorder = new List<int>();
            
            if (root == null)
                return preorder;

            preorder.Add(root.val);

            foreach (var child in root.children)
                Walk(child, preorder);

            return preorder;
        }

        private void Walk(Node child, List<int> preorder)
        {
            preorder.Add(child.val);

            foreach (var innerchild in child.children)
                Walk(innerchild, preorder);
        }
    }

    [DebuggerDisplay("Val = {val}")]
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
