using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _543二叉树的直径_二叉树_
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

        int result = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            GetMaxDepth(root);
            return result;
        }

        public int GetMaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftDepth = GetMaxDepth(root.left);
            int rightDepth = GetMaxDepth(root.right);
            if (leftDepth + rightDepth > result)
            {
                result = leftDepth + rightDepth;
            }

            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}
