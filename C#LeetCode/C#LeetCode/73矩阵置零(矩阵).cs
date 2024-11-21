// FileName：73矩阵置零(矩阵).cs
// Author：duole-15
// Date：2024/11/21
// Des：描述
using System;
using System.Collections.Generic;

namespace C_LeetCode
{
    //给定一个 m x n 的矩阵，如果一个元素为 0 ，则将其所在行和列的所有元素都设为 0 。请使用 原地 算法。

    public class _73矩阵置零_矩阵_
    {

        //遍历矩阵的 其余部分（从第 2 行和第 2 列开始），如果发现元素为零，则将该元素所在行的第一列和该元素所在列的第一行设置为零。
        //即 用第一行和第一列标记需要置零的位置(相当于把第一行和第一列的元素先置为0，反正早晚都得置为0)：
        public void SetZeroes(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            bool firstColHasZero = false;
            bool firstRowHasZero = false;

            // 检查第一列是否有0
            for (int i = 0; i < m; i++)
            {
                if (matrix[i][0] == 0)
                {
                    firstColHasZero = true;
                    break;
                }
            }

            // 检查第一行是否有0
            for (int j = 0; j < n; j++)
            {
                if (matrix[0][j] == 0)
                {
                    firstRowHasZero = true;
                    break;
                }
            }

            // 使用第一行和第一列标记其他行列需要置零的位置
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

 
            // 置零其他行列 ，i和j必须从 1 开始！！！因为第一行和第一列是标记位，最后才做处理
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            // 若第一行有0，那么将第一行都置为0
            if (firstRowHasZero)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[0][j] = 0;
                }
            }
            // 若第一列有0，那么将第一行都置为0
            if (firstColHasZero)
            {
                for (int i = 0; i < m; i++)
                {
                    matrix[i][0] = 0;
                }
            }


        }

    }



}





