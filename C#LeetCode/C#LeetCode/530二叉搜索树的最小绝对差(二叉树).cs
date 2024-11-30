// FileName：530二叉搜索树的最小绝对差(二叉树).cs
// Author：duole-15
// Date：2024/11/29
// Des：描述
using System;
namespace C_LeetCode
{
    /*530. 二叉搜索树的最小绝对差
给你一个二叉搜索树的根节点 root ，返回 树中任意两不同节点值之间的最小差值 。差值是一个正数，其数值等于两值之差的绝对值。
输入：root = [4,2,6,1,3]
输出：1
输入：root = [1,0,48,null,null,12,49]
输出：1
	 */

    public class _30二叉搜索树的最小绝对差_二叉树_
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


        public TreeNode preNode;// 记录遍历时上一个节点
        public int result = int.MaxValue; // 记录最小差值

        // 利用二叉搜索树的 中序遍历 是有序的!!! 因此，差值最小的两个点，一定是中序遍历时相邻的两个点
        // 由于只需要得到两个相邻点的差值，因此不需要一个数组来存储中序遍历的结果，只需要维护一个preNode记录上个节点即可。
        public int GetMinimumDifference(TreeNode root)
        {
            InOrderTraversal(root);
            return result;
        }

        public void InOrderTraversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            InOrderTraversal(node.left);

            if (preNode != null)
            {
                // 中序遍历时，当前节点一定比上个节点大，因此不用考虑绝对值
                result = Math.Min(result,node.val - preNode.val);
            }
            preNode = node;

            InOrderTraversal(node.right);
        }

    }
}

