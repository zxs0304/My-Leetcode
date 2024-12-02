// FileName：51N皇后(回溯).cs
// Author：duole-15
// Date：2024/12/2
// Des：描述
using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace C_LeetCode
{
    /*按照国际象棋的规则，皇后可以攻击与之处在同一行或同一列或同一斜线上的棋子。
n 皇后问题 研究的是如何将 n 个皇后放置在 n×n 的棋盘上，并且使皇后彼此之间不能相互攻击。给你一个整数 n ，返回所有不同的 n 皇后问题 的解决方案。
	每一种解法包含一个不同的 n 皇后问题 的棋子放置方案，该方案中 'Q' 和 '.' 分别代表了皇后和空位。
输入：n = 4
输出：[[".Q..","...Q","Q...","..Q."],["..Q.","Q...","...Q",".Q.."]]
解释：如上图所示，4 皇后问题存在两个不同的解法。
输入：n = 1
输出：[["Q"]]
	 */
    public class _51N皇后_回溯_
	{
        IList<IList<string>> result = new List<IList<string>>();
        // n皇后问题，不需要用二维数组来存储每个位置，浪费
        int[] queens;// 存储当前每一行中的皇后位置。//queens[0] = 2 表示第一行第三列有皇后。 -1表示此行没皇后。 
        public IList<IList<string>> SolveNQueens(int n)
        {
            queens = new int[n];
            Array.Fill(queens, -1); 
            Backtrack(0,n);
            return result;
        }

        private void Backtrack(int row,int n)
        {
            if (row == n)
            {
                List<string> curResult = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    // chras表示一行的结果
                    char[] chars = new char[n];
                    Array.Fill(chars, '.');
                    chars[queens[i]] = 'Q';
                    curResult.Add(new string(chars));
                }
                result.Add(curResult);
            }
            else
            {
                for (int col = 0; col < n; col++)
                {
                    if (IsSafe(queens,row,col))
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
                if (queens[i] == col ||  (i - queens[i] == row - col) || (i + queens[i] == row + col))
                {
                    return false;
                }
            }
            return true;
        }

    }
}

