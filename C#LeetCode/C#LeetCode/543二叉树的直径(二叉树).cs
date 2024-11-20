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
        //当前节点为根的最大深度：即 max(leftDepth, rightDepth) + 1 ，其中 leftDepth 和 rightDepth 是左子树和右子树为根的最大深度
        //跨越当前节点的最大直径：即 leftDepth + rightDepth
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
            // 计算跨越当前节点的最大直径，并更新结果
            if (leftDepth + rightDepth > result)
            {
                result = leftDepth + rightDepth;
            }
            // 返回当前节点为根的最大深度
            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}
