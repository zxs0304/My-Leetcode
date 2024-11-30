// FileName：103二叉树的锯齿型层序遍历(二叉树).cs
// Author：duole-15
// Date：2024/11/29
// Des：描述
using System;
using System.Collections;
using System.Collections.Generic;

namespace C_LeetCode
{


    public class _03二叉树的锯齿型层序遍历_二叉树_
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
        /*给你二叉树的根节点 root ，返回其节点值的 锯齿形层序遍历 。（即先从左往右，再从右往左进行下一层遍历，以此类推，层与层之间交替进行）。
输入：root = [3,9,20,1,2,15,7]    1 2 15 7
输出：[[3],[20,9],[15,7]]
输入：root = [1]
输出：[[1]]
输入：root = []
输出：[]
         */
        // 在list开头插入,实现右向左的效果!!!!!!!!!!
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null) return result;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool leftToRight = true; // 标记当前层的遍历方向

            while (queue.Count > 0)
            {
                int n = queue.Count;
                List<int> currentLevel = new List<int>();

                for (int i = 0; i < n; i++)
                {
                    TreeNode node = queue.Dequeue();

                    // 根据当前遍历方向添加节点值
                    if (leftToRight)
                    {
                        currentLevel.Add(node.val);
                    }
                    else
                    {
                        // 在开头插入实现右向左的效果!!!!!!!!!!
                        currentLevel.Insert(0, node.val);
                    }

                    // 将下一层的节点加入队列
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                result.Add(currentLevel);
                leftToRight = !leftToRight; // 切换遍历方向
            }
            return result;
        }
    }
}


