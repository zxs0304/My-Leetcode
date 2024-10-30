using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _222完全二叉树的节点数
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

        public int CountNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftDepth = getDepth(root.left);
            int rightDepth = getDepth(root.right);
            if (leftDepth == rightDepth) //说明左子树一定是满二叉树
            {
                return (int)MathF.Pow(2, leftDepth) + CountNodes(root.right);
            }
            else //说明右子树一定是满二叉树
            {
                return (int)MathF.Pow(2, rightDepth) + CountNodes(root.left);
            }         

        }

        public int getDepth(TreeNode root) //对于完全二叉树而言，最深的depth一定是一个左孩子
        {
            int depth = 0;
            while (root != null)
            {
                depth++;
                root = root.left;
            }
            return depth;
        }


    }
}
