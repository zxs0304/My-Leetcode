using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _199二叉树的右视图_二叉树_
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

        public IList<int> RightSideView(TreeNode root)
        {
            IList<int> result = new List<int>();

            if (root == null)
            {
                return result;
            }
            int depth = 0;
            result.Add(root.val);
            dfs(root.right , depth +1 , result);
            dfs(root.left , depth+1 , result);
            return result;
        }
        //深度优先，右子树优先，列表元素个数等于当前层数时，即表示当前节点是该层最右的节点
        public void dfs(TreeNode curNode,int depth,IList<int> result)
        {
            if (curNode == null) 
            { 
                return; 
            }
           
            if (result.Count == depth)
            {
                result.Add(curNode.val);
            }
            dfs(curNode.right, depth + 1, result);
            dfs(curNode.left, depth + 1, result);

        }  

    }
}
