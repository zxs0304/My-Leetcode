using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _108将有序数组转化为平衡二叉树_分治_
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
        public TreeNode SortedArrayToBST(int[] nums)
        {
            int n = nums.Length;
            TreeNode root = SortedArrayToBST(0, n - 1, nums);
            return root;
        }

        public TreeNode SortedArrayToBST(int left , int right ,int[] nums)
        {
            if (left > right)
            {
                return null;
            }
            int mid = (left + right) / 2;
            TreeNode root = new TreeNode(nums[mid]);
            root.left = SortedArrayToBST(left,mid-1,nums);
            root.right = SortedArrayToBST(mid+1, right, nums);
            return root;
        }

    }
}
