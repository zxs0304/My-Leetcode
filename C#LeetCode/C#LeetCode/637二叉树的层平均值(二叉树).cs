// FileName：637二叉树的层平均值(二叉树).cs
// Author：duole-15
// Date：2024/11/29
// Des：描述
using System;
namespace C_LeetCode
{
    public class _37二叉树的层平均值_二叉树_
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
        /*637. 二叉树的层平均值
给定一个非空二叉树的根节点 root , 以数组的形式返回每一层节点的平均值。
输入：root = [3,9,20,null,null,15,7]
输出：[3.00000,14.50000,11.00000]
解释：第 0 层的平均值为 3,第 1 层的平均值为 14.5,第 2 层的平均值为 11 。因此返回 [3, 14.5, 11] 。
输入：root = [3,9,20,15,7]
输出：[3.00000,14.50000,11.00000]
		 */

        public IList<double> AverageOfLevels(TreeNode root)
        {
            List<double> result = new();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int n = queue.Count;
                double curSum = 0;
                for (int i =0;i<n;i++)
                {
                    TreeNode node = queue.Dequeue();
                    curSum += node.val;


                    if (node.left!=null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }

                }
                result.Add(curSum / n);
            }
            return result;
        }


    }
}

