// FileName：433最小基因变化_图_BFS.cs
// Author：duole-15
// Date：2024/12/26
// Des：描述
using System;
using System.Net;

namespace C_LeetCode
{
    /*
	 * 基因序列可以表示为一条由 8 个字符组成的字符串，其中每个字符都是 'A'、'C'、'G' 和 'T' 之一。
	 * 假设我们需要调查从基因序列 start 变为 end 所发生的基因变化。一次基因变化就意味着这个基因序列中的一个字符发生了变化。
	 * 例如，"AACCGGTT" --> "AACCGGTA" 就是一次基因变化。
	 * 另有一个基因库 bank 记录了所有有效的基因变化，只有基因库中的基因才是有效的基因序列。（变化后的基因必须位于基因库 bank 中）
	 * 给你两个基因序列 start 和 end ，以及一个基因库 bank ，请你找出并返回能够使 start 变化为 end 所需的最少变化次数。如果无法完成此基因变化，返回 -1 。
	 * 注意：起始基因序列 start 默认是有效的，但是它并不一定会出现在基因库中。
	 */
    public class _433最小基因变化_图_BFS
	{

        //BFS：BFS 是逐层探索的搜索算法，能确保找到最小的变化次数，因为它会先探索所有可能的一步变化，然后是遍历所有可能的两步变化，以此类推。这样更容易找到最小的变化次数
        //DFS：尽管 DFS 也能找到变换的方式，但它不保证是最短路径。DFS 可能会深入某一条路径而未遍历其他可能的路径，从而错过更短的解决方案。

        // 遍历基因序列的每个字符位置，尝试将每个位置的字符依次变为"A","C","G","T"，
        // 然后验证变换后的这个新字符串是否在bank中，如果在bank中的话，就表示符合要求，还可以继续变换，将新字符串入队。！！！记得在bank中删除掉这个新字符串，不然会造成重复访问
        public int MinMutation(string startGene, string endGene, string[] bank)
        {
			int n = startGene.Length;
            // 将基因库转换为 HashSet，以便快速查找
            HashSet<string> set = new HashSet<string>(bank);
            // 初始化队列，存储当前基因字符串和变化次数
            Queue<(string str,int times)> queue = new();
            // 可替换的字符数组
            string[] chars = {"A","C","G","T" };
            // 将起始基因和变化次数 0 入队
            queue.Enqueue((startGene,0));

            // 开始 BFS 过程
            while (queue.Count > 0)
			{
                // 出队当前基因字符串和变化次数
                (string curStr,int times) = queue.Dequeue();
                // 检查当前基因是否是目标基因
                if (curStr == endGene)
				{
					return times;
				}

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 4; j++) // 可以少变换一次，因为变换为相同的字符没有意义
                    {
                        string newStr = curStr.Substring(0, i) + chars[j] + curStr.Substring(i + 1, n - 1 - i);
                        if (set.Contains(newStr))
                        {
                            queue.Enqueue((newStr, times + 1));
                            // ！！！从基因库中移除新基因，避免重复访问 
                            set.Remove(newStr);
                        }
                    }
                }
            }
			return -1;
        }
    }
}

