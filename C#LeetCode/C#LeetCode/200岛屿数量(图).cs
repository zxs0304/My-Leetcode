using System;
namespace C_LeetCode
{
    /*示例 1：
输入：grid = [
  ["1","1","1","1","0"],
  ["1","1","0","1","0"],
  ["1","1","0","0","0"],
  ["0","0","0","0","0"]
]
输出：1
示例 2：
输入：grid = [
  ["1","1","0","0","0"],
  ["1","1","0","0","0"],
  ["0","0","1","0","0"],
  ["0","0","0","1","1"]
]
输出：3
     */
    public class _00岛屿数量
	{
        // 遇到第一块岛屿时，就深度优先递归遍历该岛屿相邻的所有岛屿，并修改他们的状态为0 ,这样一整块岛屿就只会计算一次result++
        int result = 0;
        public int NumIslands(char[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            for (int i = 0;i<m;i++)
            {
                for (int j = 0;j<n;j++)
                {
                    if (grid[i][j] == '1')
                    {
                        result++;
                        DFS(grid, i, j);
                    }
    
                }
            }
            return result;
        }
        //(深度优先)
        private void DFS(char[][] grid, int i, int j)
        {
            // 边界条件和终止条件
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == '0')
            {
                return;
            }

            // 标记为已访问
            grid[i][j] = '0';

            // 递归访问上下左右
            DFS(grid, i + 1, j); // 下
            DFS(grid, i - 1, j); // 上
            DFS(grid, i, j + 1); // 右
            DFS(grid, i, j - 1); // 左
        }
    }
}

