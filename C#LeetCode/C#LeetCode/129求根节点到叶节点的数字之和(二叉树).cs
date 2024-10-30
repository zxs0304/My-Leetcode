using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _129求根节点到叶节点的数字之和_二叉树_
    {
        int sum = 0;
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

        public int SumNumbers(TreeNode root) //本题记录的是数字的总和，每到达一个叶子结点，将和加进sum来记录,不需要用list
        {
            dfs(root,0);
            return sum;
        }
        public void dfs(TreeNode root , int num)
        {
            if (root == null )
            {
                return;
            }
            num = num * 10 + root.val;
            if (root.left == null && root.right == null)
            {
                sum += num;
            }
            else
            {
                dfs(root.left, num);
                dfs(root.right, num);
            }

        }

        int sum2 = 0;
        int num2 = 0;                    //而上面的深度递归法，是每一次递归要维护一个临时变量,每条路径操作的是不同变量
        private void dfs2(TreeNode node) //回溯法,用到两个成员变量，就不需要传参数了(回溯法一般是所有的路径都操作同一个变量，一般是把引用变量作为参数)
                                         
        {
            if (node == null) return;
            num2 = num2 * 10 + node.val;
            if (node.left == null && node.right == null)
            {
                sum2 += num2;
            }
            dfs2(node.left);
            dfs2(node.right);
            num2 = (num2 - node.val) / 10;
        }

    }
}
