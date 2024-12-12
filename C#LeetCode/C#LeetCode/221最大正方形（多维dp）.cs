// FileName：221最大正方形（多维dp）.cs
// Author：duole-15
// Date：2024/12/12
// Des：描述
using System;
namespace C_LeetCode
{
    /*221. 最大正方形
在一个由 '0' 和 '1' 组成的二维矩阵内，找到只包含 '1' 的最大正方形，并返回其面积。
输入：matrix = [["1","0","1","0","0"],["1","0","1","1","1"],["1","1","1","1","1"],["1","0","0","1","0"]]
输出：4
输入：matrix = [["0","1"],["1","0"]]
输出：1
输入：matrix = [["0"]]
输出：0
	 */
    public class _221最大正方形_多维dp_
	{
        public int MaximalSquare(char[][] matrix)
        {
            // max表示最大正方形的边长
            int max = 0;
            int m = matrix.Length;
            int n = matrix[0].Length;
            //dp[i][j] 表示以 matrix[i][j] 作为右下角的最大正方形的边长。
            int[,] dp = new int[m, n];

            // 处理第一行
            for (int j = 0; j < n; j++)
            {
                if (matrix[0][j] == '1')
                {
                    dp[0, j] = 1;
                    max = 1; // 更新最大边长
                }
            }

            // 处理第一列
            for (int i = 0; i < m; i++)
            {
                if (matrix[i][0] == '1')
                {
                    dp[i, 0] = 1;
                    max = 1; // 更新最大边长
                }
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    //如果 matrix[i][j] 为 '1'，
                    //那么：dp[i][j] = min(dp[i - 1][j], dp[i][j - 1], dp[i - 1][j - 1]) + 1
                    if (matrix[i][j] == '1')
                    {
                        dp[i, j] = Math.Min(Math.Min(dp[i - 1, j], dp[i, j - 1]), dp[i - 1, j - 1]) + 1;
                        max = Math.Max(max, dp[i, j]);
                    }
                }
            }

            return max * max;
        }

    }
}

