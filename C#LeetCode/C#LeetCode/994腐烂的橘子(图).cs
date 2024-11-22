// FileName：994腐烂的橘子(图).cs
// Author：duole-15
// Date：2024/11/21
// Des：描述
using System;
using System.Text;

namespace C_LeetCode
{
    /*在给定的 m x n 网格 grid 中，每个单元格可以有以下三个值之一：
值 0 代表空单元格；值 1 代表新鲜橘子；值 2 代表腐烂的橘子。
每分钟，腐烂的橘子 周围 4 个方向上相邻 的新鲜橘子都会腐烂。
返回 直到单元格中没有新鲜橘子为止所必须经过的最小分钟数。如果不可能，返回 -1 。

输入：grid = [[2,1,1],
	         [1,1,0],
	         [0,1,1]]
输出：4

输入：grid = [[2,1,1],
	        [0,1,1],
	        [1,0,1]]
输出：-1
解释：左下角的橘子（第 2 行， 第 0 列）永远不会腐烂，因为腐烂只会发生在 4 个方向上。

输入：grid = [[0,2]]
输出：0
解释：因为 0 分钟时已经没有新鲜橘子了，所以答案就是 0 。
	 */
    public class _94腐烂的橘子_图_
	{
        //初始化: 使用一个队列来存储所有腐烂橘子的初始位置。统计新鲜橘子的数量。
        //BFS 过程: 每一轮从队列中，一次性取出当前状态下所有的腐烂的橘子（类似与树中一次取出一层的节点），
        //并检查每个橘子如果相邻的单元格是新鲜橘子，将其腐烂并加入队列。每次处理完一轮后，增加分钟数。
        public int OrangesRotting(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int goodOranges = 0;
            Queue<(int, int)> rottingOranges = new Queue<(int, int)>();
            int times = 0;
            for (int i = 0;i<m;i++)
            {
                for (int j= 0; j < n; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        rottingOranges.Enqueue((i,j));
                    }
                    else if (grid[i][j] == 1)
                    {
                        goodOranges++;
                    }
                }
            }
            //（广度优先搜索）
            while ( rottingOranges.Count>0 && goodOranges > 0)
            {
                // 一次性取出当前轮数下全部的腐烂橘子进行处理，模拟一轮的过程（类似与树中一次取出一层的节点）
                int count = rottingOranges.Count;
                for (int i = 0;i<count;i++)
                {
                    (int row ,int col) position = rottingOranges.Dequeue();
                    // 依次判断上下左右相邻的是否有新鲜橘子 且 坐标是否合法
                    // 上
                    if (position.row - 1 >=0 && grid[position.row - 1][position.col] == 1 )
                    {
                        goodOranges--;
                        grid[position.row - 1][position.col] = 2;
                        rottingOranges.Enqueue((position.row-1,position.col));
                    }
                    // 下
                    if (position.row + 1 < m && grid[position.row + 1][position.col] == 1)
                    {
                        goodOranges--;
                        grid[position.row + 1][position.col] = 2;
                        rottingOranges.Enqueue((position.row + 1, position.col));
                    }
                    // 左
                    if (position.col - 1 >= 0 && grid[position.row ][position.col-1] == 1)
                    {
                        goodOranges--;
                        grid[position.row][position.col - 1] = 2;
                        rottingOranges.Enqueue((position.row, position.col-1));
                    }
                    // 右
                    if (position.col + 1 < n && grid[position.row][position.col + 1] == 1)
                    {
                        goodOranges--;
                        grid[position.row][position.col + 1] = 2;
                        rottingOranges.Enqueue((position.row, position.col + 1));
                    }

                }
                times++;
            }

            return goodOranges > 0 ? -1 : times;


        }

    }
}

