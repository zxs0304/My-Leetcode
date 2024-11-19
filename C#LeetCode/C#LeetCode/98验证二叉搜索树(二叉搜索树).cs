using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_LeetCode
{
    internal class _98验证二叉搜索树_二叉搜索树_
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
        //法一：中序遍历，把每个值放进list，最后遍历list看看list是否有序。中序遍历有序的树一定是二叉搜索树。反之也成立。
        //法二：递归，动态维护一个上界和下界，遍历每个节点，节点都必须处于上下界之间，否则不是二叉搜索树
        public bool IsValidBST(TreeNode root)
        {
            return isValidBST(root, long.MinValue , long.MaxValue);
        }
        public bool isValidBST(TreeNode node, long lower, long upper)
        {
            if (node == null)
            {
                return true;
            }
            if (node.val <= lower || node.val >= upper)
            {
                return false;
            }

            return isValidBST(node.left , lower , node.val) && isValidBST(node.right , node.val, upper);
        }


    }
}
