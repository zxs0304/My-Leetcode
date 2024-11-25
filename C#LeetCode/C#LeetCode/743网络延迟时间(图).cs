
using System;
using System.Collections.Generic;

namespace C_LeetCode
{
	public class _743网络延迟时间_图_
	{
        //因为我们需要找到从起始节点 K 到其他所有节点的最短传递时间，因此采用 Dijkstra 算法。
        public int NetworkDelayTime(int[][] times, int n, int k)
        {
            // 创建邻接表，键是出发点,list是一个二元组类型，分别表示目的点和代价
            var graph = new Dictionary<int, List<(int to, int cost)>>();
            foreach (var time in times)
            {
                if (!graph.ContainsKey(time[0]))
                    graph[time[0]] = new List<(int , int)>();
                graph[time[0]].Add((time[1], time[2]));
            }

            // 优先队列（数据类型是一个二元组，分别是当前节点，出发点到当前节点的代价）优先级是代价, 优先队列默认是最小堆
            var priorityQueue = new PriorityQueue<(int node, int cost), int>();
            var distances = new Dictionary<int, int>();

            // 初始化距离
            for (int i = 1; i <= n; i++)
            {
                distances[i] = int.MaxValue;
            }
            distances[k] = 0;
            priorityQueue.Enqueue((k, 0), 0);

            while (priorityQueue.Count > 0)
            {
                // 取出当前最近的可达点
                (int curNode , int curCost) = priorityQueue.Dequeue();

                //如果当前最近可达点 具有 邻居节点
                if (graph.ContainsKey(curNode))
                {
                    //获取当前最近可达点的每一个邻居节点
                    foreach ((int newNode, int newCost) in graph[curNode])
                    {
                        // 尝试更新 出发点到新点的最小距离
                        if (curCost + newCost < distances[newNode])
                        {
                            distances[newNode] = curCost + newCost;
                            priorityQueue.Enqueue((newNode, curCost + newCost), curCost + newCost);
                        }
                    }
                }
   
            }

            // 查找最大传递时间
            int maxTime = 0;
            foreach (var dist in distances.Values)
            {
                if (dist == int.MaxValue) return -1; // 有节点无法到达
                maxTime = Math.Max(maxTime, dist);
            }

            return maxTime;

        }

    }
}

