using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _63不同路径
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            //obstacleGrid[i][j] 表示此位置有几条路径可以到达，由于路径只能从左上到右下走，因此可以原地修改数组的值
            int row = obstacleGrid.Length;
            int col = obstacleGrid[0].Length;
            if (obstacleGrid[row - 1][col-1] == 1 || obstacleGrid[0][0] == 1)
            {
                return 0;
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == 0 && j == 0) //初始化起点
                    {
                        obstacleGrid[i][j] = 1;
                        continue;
                    }

                    if (obstacleGrid[i][j] == 1) //精妙之处是从左上到右下 每个格子只会访问一次，因此修改obstacleGrid[i][j] = 0 表示无法到达，
                                                 //并不会相混淆与初始的0
                    {
                        obstacleGrid[i][j] = 0; //表示此位置没有路径可以到达
                        continue;
                    }

                    if (i == 0) //第一行
                    {
                        obstacleGrid[i][j] = obstacleGrid[i][j - 1];
                    }
                    else if (j == 0) //第一列
                    {
                        obstacleGrid[i][j] = obstacleGrid[i - 1][j];
                    }
                    else 
                    {
                        obstacleGrid[i][j] = obstacleGrid[i - 1][j] + obstacleGrid[i][j - 1];
                    }


                }

            }

            return obstacleGrid[row - 1][col - 1];
        }

    }
}
