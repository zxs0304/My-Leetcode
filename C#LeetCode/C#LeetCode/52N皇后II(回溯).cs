using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _52N皇后II_回溯_
    {
        public int TotalNQueens(int n)
        {
            int[] queens = new int[n]; // queens[0] = 2 表示在第一行第三列上放置了皇后
            return DiGui(queens, 0);
        }

        public int DiGui(int[] queens,int row)
        {
            if(row == queens.Length)
            {
                return 1; //找到一种解法
            }

            int count = 0;
            for(int col = 0;col < queens.Length; col++)
            {
                if (IsSafe(queens, row, col))
                {
                    queens[row] = col;
                    count += DiGui(queens,row+1);
                    queens[row] = -1;
                }
            }
            return count;
        }

        public bool IsSafe(int[] queens,int row,int col)
        {
            for (int i = 0; i < row; i++)
            {
                // 检查列和对角线
                if (queens[i] == col || (i - queens[i] == row - col) || (i + queens[i] == row + col))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
