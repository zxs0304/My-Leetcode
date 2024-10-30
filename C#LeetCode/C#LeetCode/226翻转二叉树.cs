using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _226翻转二叉树
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

        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null )
            {
                return null;
            }
            Swap(ref root.left,ref root.right);
            InvertTree(root.left);
            InvertTree(root.right);
            return root;
        }

        public void Swap(ref TreeNode left , ref TreeNode right)
        {
            TreeNode temp = left;
            left = right;
            right = temp;
        }

    }
}
