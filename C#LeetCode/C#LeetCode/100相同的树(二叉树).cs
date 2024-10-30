using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_LeetCode._104二叉树的最大深度;

namespace C_LeetCode
{
    internal class _100相同的树_二叉树_
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

        public bool IsSameTree(TreeNode p, TreeNode q)
        {

            if (p == null && q == null)
            {
                return true;
            }
            else if(p != null && q != null && p.val == q.val)
            {
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }
            else
            {
                return false;
            }


        }

        //public bool dfs(TreeNode p, TreeNode q)
        //{
        //    if (p != null && q!=null)
        //    {

        //    }
        //    else
        //    {

        //    }
        //}

    }
}
