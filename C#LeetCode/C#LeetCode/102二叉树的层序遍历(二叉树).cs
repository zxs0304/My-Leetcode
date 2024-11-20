using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _102二叉树的层序遍历_二叉树_
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

        public IList<IList<int>> LevelOrder(TreeNode root)
        {

            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;

            List<int> level = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                level = new();
                int n = queue.Count;
                //必须一次性把这一层的节点都取出来
                //因此用一个for循环
                //!!!!必须要先把n求出来，如果在for循环的条件里写queue.Count会报错，因为Count在不断减小
                for (int i = 0;i< n ;i++)
                {

                    TreeNode node = queue.Dequeue();
                    level.Add(node.val);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                // 当您在 while 循环中使用 level = new(); 时，
                // 实际上是创建了一个新的 List<int> 实例，并将 level 指向这个新实例。
                //这意味着在每次迭代时，level 指向的都是一个新对象，
                //因此在每次调用 result.Add(level); 时，添加的是不同的实例。
                result.Add((level));
            }
            return result;
        }

    }
}
