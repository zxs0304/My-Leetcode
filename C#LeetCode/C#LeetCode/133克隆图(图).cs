// FileName：133克隆图(图).cs
// Author：duole-15
// Date：2024/12/27
// Des：描述
using System;
namespace C_LeetCode
{

	public class _133克隆图_图_
	{

        public class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node()
            {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }

        //DFS , 若邻居节点还没克隆过，先递归克隆所有的邻居节点，若邻居节点已经克隆过了，直接return 克隆后的新邻居节点
        Dictionary<Node, Node> map = new();
        public Node CloneGraph(Node node)
        {
            // 如果传进来一个空图，return null
            if (node == null)
            {
                return null;
            }

            // 说明该节点已经克隆过了
            if (map.ContainsKey(node))
            {
                return map[node];
            }

            // 克隆新节点
            Node newNode = new Node(node.val);
            map.Add(node, newNode);

            // 克隆新节点的邻居节点
            foreach (var item in node.neighbors)
            {
                newNode.neighbors.Add(CloneGraph(item));
            }

            return map[node];
        }


        // BFS
        // !!!!队列用于存放“待处理的节点”，指的是那些已经被克隆，但尚未处理其邻居的节点。
        public Node CloneGraph_2(Node node)
        {
            if (node == null)
            {
                return null;
            }

            // 使用字典来存储已克隆的节点
            Dictionary<Node, Node> visited = new Dictionary<Node, Node>();

            // 克隆起始节点
            Node cloneNode = new Node(node.val);
            visited[node] = cloneNode;

            // 使用队列进行 BFS
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();

                // 遍历邻居节点
                foreach (var neighbor in current.neighbors)
                {
                    // 如果邻居节点未被克隆
                    if (!visited.ContainsKey(neighbor))
                    {
                        // 克隆邻居节点并存储在字典中
                        visited[neighbor] = new Node(neighbor.val);
                        // 将邻居节点加入队列 , 等待下一轮处理邻居节点的邻居节点
                        queue.Enqueue(neighbor);
                    }

                    // 将克隆的邻居节点添加到当前克隆节点的邻居列表中
                    visited[current].neighbors.Add(visited[neighbor]);
                }
            }

            // 返回克隆的起始节点
            return cloneNode;
        }


    }
}

