using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _114二叉树展开为链表
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

        public void Flatten(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            List<TreeNode> list = new List<TreeNode>();
            list.Add(root);
            Flatten(root.left, list);
            Flatten(root.right, list);

            for(int i = 0; i < list.Count; i++)
            {
                list[i].left = null;
                if (i + 1 < list.Count)
                {
                    list[i].right = list[i + 1];
                }
            }
            
         
        }

        public void Flatten(TreeNode root , List<TreeNode> list)
        {
            if (root == null)
            {
                return;
            }
            list.Add(root);

            Flatten(root.left,list);
            Flatten(root.right, list);

        }



    }
}
