﻿// FileName：289生命游戏(矩阵).cs
// Author：duole-15
// Date：2024/12/26
// Des：描述
using System;
namespace C_LeetCode
{
    /*
	 * 289. 生命游戏
给定一个包含 m × n 个格子的面板，每一个格子都可以看成是一个细胞。
每个细胞都具有一个初始状态： 1 即为 活细胞 （live），或 0 即为 死细胞 （dead）。每个细胞与其八个相邻位置（水平，垂直，对角线）的细胞都遵循以下四条生存定律：
如果活细胞周围八个位置的活细胞数少于两个，则该位置活细胞死亡；
如果活细胞周围八个位置有两个或三个活细胞，则该位置活细胞仍然存活；
如果活细胞周围八个位置有超过三个活细胞，则该位置活细胞死亡；
如果死细胞周围正好有三个活细胞，则该位置死细胞复活；
下一个状态是通过将上述规则同时应用于当前状态下的每个细胞所形成的，其中细胞的出生和死亡是 同时 发生的。给你 m x n 网格面板 board 的当前状态，返回下一个状态。
给定当前 board 的状态，更新 board 到下一个状态。
注意 你不需要返回任何东西。

输入：board = [[0,1,0],[0,0,1],[1,1,1],[0,0,0]]
输出：[[0,0,0],[1,0,1],[0,1,1],[0,1,0]]

输入：board = [[1,1],[1,0]]
输出：[[1,1],[1,1]]

	 */
    public class _289生命游戏_矩阵_
	{

        public void GameOfLife(int[][] board)
        {
            int rows = board.Length;
            int cols = board[0].Length;

            int[][] newBoard = new int[rows][];
            for (int i = 0;i<rows;i++)
            {
                newBoard[i] = new int[cols];
                Array.Copy(board[i], newBoard[i], board[i].Length);
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int aliveCount = 0;

                    if (i - 1 >= 0 && j - 1 >= 0)
                    {
                        if (newBoard[i - 1][j - 1] == 1)
                            aliveCount++;
                    }

                    if (i - 1 >= 0)
                    {
                        if (newBoard[i - 1][j] == 1)
                            aliveCount++;
                    }

                    if (i - 1 >= 0 && j + 1 < cols)
                    {
                        if (newBoard[i - 1][j + 1] == 1)
                            aliveCount++;
                    }

                    if (j - 1 >= 0)
                    {
                        if (newBoard[i][j - 1] == 1)
                            aliveCount++;
                    }

                    if (j + 1 < cols)
                    {
                        if (newBoard[i][j + 1] == 1)
                            aliveCount++;
                    }

                    if (i + 1 < rows && j - 1 >= 0)
                    {
                        if (newBoard[i + 1][j - 1] == 1)
                            aliveCount++;
                    }

                    if (i + 1 < rows)
                    {
                        if (newBoard[i + 1][j] == 1)
                            aliveCount++;
                    }

                    if (i + 1 < rows && j + 1 < cols)
                    {
                        if (newBoard[i + 1][j + 1] == 1)
                            aliveCount++;
                    }

                    if (newBoard[i][j] == 1)
                    {
                        if (aliveCount < 2 || aliveCount > 3)
                        {
                            board[i][j] = 0;
                        }
                    }
                    else
                    {
                        if (aliveCount == 3)
                        {
                            board[i][j] = 1;
                        }
                    }

                }
            }

        }

    }
}

