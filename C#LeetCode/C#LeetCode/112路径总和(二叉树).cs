using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _112路径总和_二叉树_
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

        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }

            return dfs2(root, 0, targetSum);
        }
        public bool dfs(TreeNode node, int sum, int targetSum, TreeNode preNode)
        {
            if (node == null)
            {
                if (sum == targetSum && preNode.left == null && preNode.right == null) //说明上一个节点是叶子结点
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            sum += node.val;
            return dfs(node.left, sum, targetSum, node) || dfs(node.right, sum, targetSum, node);

        }


        //法二更好，直接判断当前是否是叶子节点，如果是叶子结点就不往下继续了，法一 需要多记录一个上一个节点
        public bool dfs2(TreeNode node, int sum, int targetSum)
        {
            if (node == null)
            {
                return false;
            }
            sum += node.val;
            if (node.left == null && node.right == null && sum == targetSum)
            {
                return true;
            }
            else
            {
                return dfs2(node.left, sum, targetSum) || dfs2(node.right, sum, targetSum);
            }
        }
        //法三更好，比法二少维护一个参数变量
        public bool dfs3(TreeNode node, int targetSum)
        {
            if (node == null)
            {
                return false;
            }
            if (node.left == null && node.right == null && node.val == targetSum)
            {
                return true;
            }
            else
            {
                return dfs3(node.left, targetSum - node.val) || dfs3(node.right, targetSum - node.val);
            }
        }

    }
}
