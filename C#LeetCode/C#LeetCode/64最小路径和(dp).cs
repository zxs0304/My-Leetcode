using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _64最小路径和_dp_
    {
        public int MinPathSum(int[][] grid)
        {
            int row = grid.Length;
            int col = grid[0].Length;

            for (int i = 0;i< row;i++)
            {
                for (int j = 0;j< col;j++)
                {
                    if (i == 0)
                    {
                        if (j != 0)
                        {
                            grid[i][j] = grid[i][j - 1] + grid[i][j];
                        }
                    }
                    else if (j == 0)
                    {
                        grid[i][j] = grid[i-1][j] + grid[i][j];
                    }
                    else
                    {
                        grid[i][j] = Math.Min(grid[i - 1][j], grid[i][j - 1]) + grid[i][j];
                    }
 

                }

            }

            return grid[row-1][col-1];
        }

    }
}
