using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _104二叉树的最大深度
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

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int curLeftDepth = MaxDepth(root.left);
            int curRightDepth = MaxDepth(root.right); 

            return Math.Max(curLeftDepth,curRightDepth) + 1;//return的是从下往上，当前自己的层(包含了自己,因此+1)

        }


    }
}
