using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _236二叉树的最近公共祖先_二叉树_
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        //方法一，递归回溯，记录找到目标节点的路径的节点，然后比较两段路径的节点，空间复杂度较高
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            List<TreeNode> pathToP = new List<TreeNode>();
            List<TreeNode> pathToQ = new List<TreeNode>();

            // 获取根节点到 p 和 q 的路径
            GetPath(root, p, pathToP);
            GetPath(root, q, pathToQ);

            // 从后向前查找最近公共祖先
            TreeNode res = null;
            for (int i = 0; i < Math.Min(pathToP.Count, pathToQ.Count); i++)
            {
                if (pathToP[i] == pathToQ[i])
                {
                    res = pathToP[i]; // 更新更深的公共祖先
                }
                else
                {
                    break; // 找到第一个不同的节点
                }
            }

            return res;

        }

        //该方法是获取从一条从根节点到目标节点的路径
        public bool GetPath(TreeNode curNode, TreeNode targetNode,List<TreeNode> path)
        {
            if (curNode == null) return false;

            path.Add(curNode); // 添加当前节点到路径

            if (curNode.val == targetNode.val) 
                return true;

            // 递归查找左子树或右子树 , 若有一个为true，表示目标节点是我的子节点，因此就不用删去我自己，直接返回
            if (GetPath(curNode.left, targetNode, path) || GetPath(curNode.right, targetNode, path))
            {
                return true;
            }

            // 否则表示目标节点不是我的子节点，要在路径中删去我自己
            path.RemoveAt(path.Count - 1);
            return false;

        }



//方法二,若 root 是 p,q 的 最近公共祖先 ，则只可能为以下情况之一：
//p 和 q 在 root 的子树中，且分列 root 的 异侧（即分别在左、右子树中）；
//p=root ，且 q 在 root 的左或右子树中(即q不在p的兄弟节点中，即p的父节点的另一子树返回的是null)；
//q=root ，且 p 在 root 的左或右子树中；
        public TreeNode LowestCommonAncestor_2(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q)
            {
                //只要当前根节点是p和q中的任意一个，就返回（因为不能比这个更深了，再深p和q中的一个就没了）
                return root;
            }
            //根节点不是p和q中的任意一个，那么就继续分别往左子树和右子树找p和q
            TreeNode left = LowestCommonAncestor_2(root.left, p, q);
            TreeNode right = LowestCommonAncestor_2(root.right, p, q);
            //p和q都没找到，那就没有
            if (left == null && right == null)
            {
                return null;
            }
            //左子树没有p也没有q，就返回右子树的结果
            if (left == null)
            {
                return right;
            }
            //右子树没有p也没有q就返回左子树的结果
            if (right == null)
            {
                return left;
            }
            //左右子树都找到p和q了，那就说明p和q分别在左右两个子树上，所以此时的最近公共祖先就是root
            return root;
        }

    }
}
