using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _101对称二叉树
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

        public bool IsSymmetric(TreeNode root)
        {
            return dfs(root.left,root.right);

        }
        public bool dfs(TreeNode left , TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }
            else if (left != null && right != null && left.val == right.val) 
            {
                return dfs(left.left,right.right) && dfs(left.right,right.left);
            }
            else
            {
                return false;
            }

        }


    }
}
