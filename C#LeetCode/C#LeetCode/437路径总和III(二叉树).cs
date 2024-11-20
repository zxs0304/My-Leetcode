
using System;
namespace C_LeetCode
{
    /*
	 * 给定一个二叉树的根节点 root ，和一个整数 targetSum ，求该二叉树里节点值之和等于 targetSum 的 路径 的数目。
       路径 不需要从根节点开始，也不需要在叶子节点结束，但是路径方向必须是向下的（只能从父节点到子节点）。
输入：root = [10,5,-3,3,2,null,11,3,-2,null,1], targetSum = 8
输出：3
解释：和等于 8 的路径有 3 条，如图所示。
输入：root = [5,4,8,11,null,13,4,7,2,null,null,5,1], targetSum = 22
输出：3
	 */
    public class _37路径总和III_二叉树_
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
        // 依次让每一个节点都作为根节点，然后向下找
        int result = 0;
        public int PathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return 0;

            // 让当前节点作为根节点(相当于要当前节点)
            PathFromThisNode(root,targetSum);
            // 让左右子节点重新作为根节点向下找(相当于不要当前节点)
            PathSum(root.left, targetSum);
            PathSum(root.right, targetSum);
            return result;
        }
        // 从当前节点作为根节点，一直向下找直到叶子节点
        public void PathFromThisNode(TreeNode root , int targetSum)
        {
            if (root == null)
            {
                return;
            }
            if (root.val == targetSum)
            {
                result++;
            }
            PathFromThisNode(root.left , targetSum - root.val);
            PathFromThisNode(root.right, targetSum - root.val);
        }


	}
}

