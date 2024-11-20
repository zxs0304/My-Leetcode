
using System;
namespace C_LeetCode
{
	public class _124二叉树的最大路径和_二叉树_
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

        /*二叉树中的 路径 被定义为一条节点序列，序列中每对相邻节点之间都存在一条边。同一个节点在一条路径序列中 至多出现一次 。
         * 该路径 至少包含一个 节点，且不一定经过根节点。
         * 路径和 是路径中各节点值的总和。
         * 给你一个二叉树的根节点 root ，返回其 最大路径和 
         */

        //当前节点为根，向下的最大路径和：即 node.val + max(left, right)，其中 left 和 right 是左子树和右子树为根的最大路径和，但要确保不为负值。
        //跨越当前节点的最大路径和：即 node.val + left + right，但要确保不为负值。这是可以用来更新全局最大路径和。
        int maxPathSum = int.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            CalculateMaxPath(root);
            return maxPathSum;
        }

        private int CalculateMaxPath(TreeNode node)
        {
            if (node == null)
            {
                return 0; // 返回0以便于路径和的计算
            }

            // 递归计算左右子树为根，向下的最大路径和，确保不为负值
            int leftMax = Math.Max(CalculateMaxPath(node.left), 0);
            int rightMax = Math.Max(CalculateMaxPath(node.right), 0);

            // 跨越当前节点的最大路径和
            int currentMax = node.val + leftMax + rightMax;

            maxPathSum = Math.Max(maxPathSum, currentMax);

            // 返回当前节点为根，向下的最大路径和
            return node.val + Math.Max(leftMax, rightMax);
        }
    }
}

