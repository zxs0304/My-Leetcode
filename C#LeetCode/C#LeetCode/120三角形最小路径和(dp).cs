using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _120三角形最小路径和_dp_
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int row = triangle.Count;
            int col = triangle[row-1].Count;
            int[,] dp = new int[row, col];
            dp[0,0] = triangle[0][0];

            for (int i = 1;i<row;i++) 
            {
                for (int j = 0; j<i+1;j++)
                {
                    if ( j == 0)
                    {
                        dp[i,j] = dp[i - 1,j] + triangle[i][j];
                    }
                    else if (j == i) 
                    {
                        dp[i, j] = dp[i - 1, j-1] + triangle[i][j];
                    }
                    else
                    {
                        dp[i, j] = Math.Min(dp[i-1,j] , dp[i-1,j-1]) + triangle[i][j];
                    }
                }
            }
            int min = dp[row-1,0];
            for (int j = 1;j<col;j++)
            {
                min = Math.Min(min, dp[row-1,j]);
            }

            return min;
        }

        //自底向上 空间O(n)  使用一维数组优化动态规划,因为我们在计算每一行的最小路径和时，只依赖于上一行的值,而不需要上两行,因此直接原地修改数组值
        public int MinimumTotal2(IList<IList<int>> triangle)
        {
            int row = triangle.Count;
            int[] dp = new int[row];  //第row行的列数一定是row！

            // 从底部开始填充 dp 数组
            for (int j = 0; j < row; j++)  
            {
                dp[j] = triangle[row - 1][j]; // 初始化底层
            }

            // 从倒数第二层往上更新 dp 数组
            for (int i = row - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    dp[j] = Math.Min(dp[j], dp[j + 1]) + triangle[i][j];
                }
            }

            // dp[0] 现在存储的是从顶层到底层的最小路径和
            return dp[0];
        }

    }
}
