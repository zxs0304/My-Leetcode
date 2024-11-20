using System;
namespace C_LeetCode
{
    /**
 给你二叉树的根节点 root 和一个整数目标和 targetSum ，找出所有 从根节点到叶子节点 路径总和等于给定目标和的路径。叶子节点是指没有子节点的节点。
    [1,-2,-3,1,3,-2,null,-1]
    targetSum = 2
	 */
    public class _13路径总和II_二叉树_
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
        // 回溯法
        IList<IList<int>> result = new List<IList<int>>();
        List<int> curResult = new List<int>();
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            DFS(root, targetSum);
            return result;
        }
        public void DFS(TreeNode root , int targetSum)
        {
            if (root == null)
            {
                return;
            }
            curResult.Add(root.val);
            if (root.val == targetSum && root.left == null && root.right == null)
            {
                result.Add(new List<int>(curResult));
            }
            else
            {
                DFS(root.left, targetSum - root.val);
                DFS(root.right, targetSum - root.val);
            }
            curResult.RemoveAt(curResult.Count-1);

        }

    }
}

