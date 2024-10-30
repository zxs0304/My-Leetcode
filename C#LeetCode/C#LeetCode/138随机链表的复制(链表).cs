using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_LeetCode
{
    internal class _138随机链表的复制_链表_
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }

        public Node CopyRandomList(Node head)
        {
            if(head == null)
            {
                return null;
            }
            Dictionary<Node,Node> maps = new Dictionary<Node,Node>(); //存储每一个旧节点和新节点的映射
            Node current = head;

            while (current != null)
            {
                Node newNode = new Node(current.val);
                maps.Add(current, newNode);
                current = current.next;
            }
            current = head;

            while (current != null)
            {
                Node newNode = maps[current];
                if (current.random != null) 
                {
                    newNode.random = maps[current.random];
                }
                else
                {
                    newNode.random = null;
                }
                if (current.next != null)
                {
                    newNode.next = maps[current.next];
                }
                current = current.next;
            }
            return maps[head];
        }

    }
}
