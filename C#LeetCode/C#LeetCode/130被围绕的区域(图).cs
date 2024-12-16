// FileName：130被围绕的区域(图).cs
// Author：duole-15
// Date：2024/12/16
// Des：描述
using System;
namespace C_LeetCode
{
    /*130. 被围绕的区域
给你一个 m x n 的矩阵 board ，由若干字符 'X' 和 'O' 组成，捕获 所有 被围绕的区域：
连接：一个单元格与水平或垂直方向上相邻的单元格连接。
区域：连接所有 'O' 的单元格来形成一个区域。
围绕：如果您可以用 'X' 单元格 连接这个区域，并且区域中没有任何单元格位于 board 边缘，则该区域被 'X' 单元格围绕。
通过将输入矩阵 board 中的所有 'O' 替换为 'X' 来 捕获被围绕的区域。
输入：board = [
    ["X","X","X","X"],
    ["X","O","O","X"],
    ["X","X","O","X"],
    ["X","O","X","X"]
    ]
输出：[["X","X","X","X"],["X","X","X","X"],["X","X","X","X"],["X","O","X","X"]]
在上图中，底部的区域没有被捕获，因为它在 board 的边缘并且不能被围绕。

输入：board = [["X"]]
输出：[["X"]]
	 */
    public class _130被围绕的区域_图_
	{
        // 反向思维，要求所有被X包围的O。可以从边缘开始求，求所有不被包围的O。 这样就类似于 200.岛屿数量
        // 即从四个边上的O开始DFS延伸，看能延伸周围多少个O，记录下这些O，这些O都是无法被包围的。最后矩阵中除了记录下的这些O以外，其他的都是可以被包围的，将其他的都变为X
        int rows;
        int cols;
        public void Solve(char[][] board)
        {
            rows = board.Length;
            cols = board[0].Length;
            // 检查第一列和最后一列的O
            for (int i = 0; i < rows; i++)
            {
                if (board[i][0] == 'O')
                    DFS(i, 0, board);
                if (board[i][cols - 1] == 'O')
                    DFS(i, cols - 1, board);
            }

            // 检查第一行和最后一行的O
            for (int j = 0; j < cols; j++)
            {
                if (board[0][j] == 'O')
                    DFS(0, j, board);
                if (board[rows - 1][j] == 'O')
                    DFS(rows - 1, j, board);
            }

            // 不能直接遍历四个边上，因为 i < rows ,  rows != cols !!!
            //for (int i = 0; i < rows; i++)
            //{
            //    if (board[i][0] == 'O')
            //        DFS(i, 0, board);
            //    if (board[i][cols - 1] == 'O')
            //        DFS(i, rows - 1, board);
            //    if (board[0][i] == 'O')
            //        DFS(i, rows - 1, board);
            //    if (board[rows - 1][i] == 'O')
            //        DFS(i, rows - 1, board);
            //}

            // 遍历整个矩阵，将 'O' 替换为 'X'，将标记的 'O'(即'#'), 替换回 'O'
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i][j] == 'O')
                    {
                        board[i][j] = 'X'; // 被围绕的区域转换为 'X'
                    }
                    else if (board[i][j] == '#')
                    {
                        board[i][j] = 'O'; // 边缘区域恢复为 'O'
                    }
                }
            }

        }

        
        public void DFS(int i ,int j,char[][] board)
        {
            if (i < 0 || i >= rows || j < 0 || j >= cols)
            {
                return;
            }
            if (board[i][j] == 'O')
            {
                //记录下来这些无法被包围的'O',同时将它们改为'#'还可以避免相邻之间的循环递归！！！
                board[i][j] = '#';
                DFS(i + 1, j, board);
                DFS(i - 1, j, board);
                DFS(i, j + 1, board);
                DFS(i, j - 1, board);
            }
        }
    }
}

