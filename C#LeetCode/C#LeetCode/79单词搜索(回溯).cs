using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    class _79单词搜索_回溯_
    {
        public bool Exist(char[][] board, string word)
        {
            bool flag = false;
            for(int row = 0; row < board.Length; row++)
            {
                for(int col = 0; col < board[0].Length; col++)
                {
                    if (DiGui(board, word, 0, row, col))
                    {
                        flag = true;
                    }
                  
                }
            }
            return flag;
        }

        public bool DiGui(char[][] board, string word, int index,int row , int col)
        {
            if (index == word.Length)
            {
                return true;
            }
            if ( row < 0 || col < 0 || row >= board.Length || col >= board[0].Length || board[row][col] != word[index] )
            {
                return false;
            }

            //走到这说明当前位置有效且正确
            char temp = board[row][col];
            board[row][col] = '#'; //设置当前位置为#是为了标识当前位置已访问过.避免了开辟一个bool[][]数组来表示是否访问.

            bool right = DiGui(board, word, index + 1, row + 1, col);
            bool up = DiGui(board, word, index + 1, row, col + 1);
            bool left = DiGui(board, word, index + 1, row - 1, col);
            bool down = DiGui(board, word, index + 1, row, col - 1);

            board[row][col] = temp;
            return right||up||down||left;

        }

    }
}
