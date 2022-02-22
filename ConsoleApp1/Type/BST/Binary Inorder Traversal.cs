using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.BST
{
    internal class Binary_Inorder_Traversal
    {
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
        }
        public class InorderTraversalSolution
        {

            public IList<int> InorderTraversal(TreeNode root)
            {
                IList<int> list = new List<int>();
                Helper(list, root);
                return list;

            }

            private void Helper(IList<int> list, TreeNode root)
            {
                if (root == null)
                    return;
                Helper(list, root.left);
                list.Add(root.val);
                Helper(list, root.right);
            }

            public bool IsSameTree(TreeNode p, TreeNode q)
            {
                if (p == null && q == null)
                    return true;
                if (p == null || q == null)
                    return false;
                if (p.val != q.val) return false;
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);


            }
        }
    }
}
