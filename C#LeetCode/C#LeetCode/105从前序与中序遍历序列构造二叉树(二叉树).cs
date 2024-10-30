using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _105从前序与中序遍历序列构造二叉树_二叉树_
    {
        Dictionary<int,int> valueToIndex = new Dictionary<int,int>();
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

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            for (int i = 0;i<inorder.Length;i++)
            {
                valueToIndex.Add(inorder[i] ,i);
            }
            return Digui(preorder, inorder, 0, preorder.Length - 1, 0,inorder.Length-1); 
        }

        public TreeNode Digui(int[] preorder , int[] inorder , int preLeft,int preRight,int inLeft,int inRight)
        {
            if (preLeft > preRight)
            {
                return null;
            }

            //preLeft一定是当前根节点在先序遍历中的下标
            //得到当前根节点的值
            int preRootValue = preorder[preLeft];

            TreeNode currentRootNode = new TreeNode(preorder[preLeft]);

            //得到当前树的根节点在中序遍历中的下标
            int inRoot = valueToIndex[preRootValue];

            int leftChildLength = inRoot - inLeft;

            currentRootNode.left = Digui(preorder, inorder, preLeft + 1, preLeft + leftChildLength, inLeft, inRoot - 1);
            currentRootNode.right = Digui(preorder, inorder, preLeft + leftChildLength + 1, preRight, inRoot + 1, inRight);

            return currentRootNode;

        }


    }
}
