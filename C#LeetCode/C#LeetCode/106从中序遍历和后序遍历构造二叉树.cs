using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _106从中序遍历和后序遍历构造二叉树
    {
        public Dictionary<int, int> valueToIndex = new Dictionary<int, int>(); 

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

        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            for (int i = 0;i<inorder.Length;i++)
            {
                valueToIndex.Add(inorder[i],i);
            }
            return Digui(inorder, postorder,0,inorder.Length-1,0,postorder.Length-1);

        }

        public TreeNode Digui(int[] inorder , int[] postorder , int inLeft , int inRight , int postLeft, int postRight)
        {
            if (inLeft > inRight)
            {
                return null;
            }

            int rootValue = postorder[postRight];
            int inRootIndex = valueToIndex[rootValue];
            TreeNode curRoot = new TreeNode(rootValue);
            int rightChildLength =  inRight - inRootIndex;

            curRoot.left = Digui(inorder, postorder, inLeft, inRootIndex - 1, postLeft, postRight - rightChildLength - 1);
            curRoot.right = Digui(inorder, postorder, inRootIndex + 1, inRight, postRight - rightChildLength, postRight - 1);
            return curRoot;

        }

    }
}
