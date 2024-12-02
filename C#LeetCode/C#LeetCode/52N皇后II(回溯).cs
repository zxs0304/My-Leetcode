using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _52N皇后II_回溯_
    {
        // n皇后问题，不需要用二维数组来存储每个位置，浪费.
        int[] queens;// 存储当前每一行中的皇后位置。//queens[0] = 2 表示第一行第三列有皇后。 -1表示此行没皇后。
        int result = 0;
        public int TotalNQueens(int n)
        {
            queens = new int[n];
            Array.Fill(queens, -1);
            Backtrack(0, n);
            return result;
        }

        private void Backtrack(int row, int n)
        {
            if (row == n)
            {
                result++;
            }
            else
            {
                for (int col = 0; col < n; col++)
                {
                    if (IsSafe(queens, row, col))
                    {
                        queens[row] = col;
                        Backtrack(row + 1, n);
                        queens[row] = -1;
                    }
                }
            }
        }

        public bool IsSafe(int[] queens, int row, int col)
        {
            // i要小于row, 因为只检查当前行之前的行是否有冲突
            for (int i = 0; i < row; i++)
            {
                // 检查列和对角线
                // 对于同一条主对角线上的元素，row - col 都相同 。
                // 对于同一条副对角线上的元素，row + col 都相同 。
                if (queens[i] == col || (i - queens[i] == row - col) || (i + queens[i] == row + col))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
