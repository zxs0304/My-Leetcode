using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_LeetCode._138随机链表的复制_链表_;

namespace C_LeetCode
{
    internal class _117填充每个节点的下一个右侧节点指针II_二叉树_
    {

        List<Node> list = new List<Node>();

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }

        public Node Connect(Node root)
        {
            if (root == null)
            {
                return null;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                Node preNode = null; //当前层中，当前节点的上一个节点
                int n = queue.Count;
                for (int i = 0;i<n;i++) //一次性把队列中的点都取出来完，即是每层的所有点,然后依次连接他们
                {
                    Node curNode = queue.Dequeue();

                    if (curNode.left != null) //加入当前节点的子节点到队列
                    {
                        queue.Enqueue(curNode.left);
                    }
                    if (curNode.right != null)
                    {
                        queue.Enqueue(curNode.right);
                    }

                    if(preNode != null) //设置上一个节点的next
                    {
                        preNode.next = curNode;

                    }
                    preNode = curNode; //更新上一个节点为当前节点
                }

            }

            return root;

        }

        //DFS法，维护一个List，先递归遍历所有的左子树，把每一层的第一个节点记录下来，后续持续更新
        public Node Connect2(Node root)
        {
            if (root == null)
            {
                return null;
            }


            Connect2(root , 0 );

            return root;
        }

        public Node Connect2(Node root , int depth) //当前的层的深度
        {
            if (root == null)
            {
                return null;
            }

            if (depth == list.Count) //说明当前节点是当前层的第一个节点
            {
                list.Add(root);
            }
            else //说明当前节点不是当前层的第一个节点
            {
                list[depth].next = root;
                list[depth] = root;
            }

            Connect2(root.left , depth +1);

            Connect2(root.right, depth + 1);

            return root;
        }

        

    }
}
