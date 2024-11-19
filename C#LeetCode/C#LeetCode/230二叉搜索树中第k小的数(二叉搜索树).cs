using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _230二叉搜索树中第k小的数_二叉搜索树_
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

        //递归 中序遍历，维护一个number表示当前遍历了几个节点，当中序遍历到第k个节点时，即是第k小的数
        int number = 0;
        int result = 0;
        public int KthSmallest(TreeNode root, int k)
        {
            DFS(root, k);
            return result;
        }
        public void DFS(TreeNode root, int k)
        {
            if (root == null)
            {
                return;
            }
            DFS(root.left, k);
            number++;
            if (number == k)
            {
                result = root.val;
            }
            DFS(root.right, k);
        }

    }
}
