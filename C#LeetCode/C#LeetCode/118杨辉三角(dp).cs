// FileName：118杨辉三角(动态规划).cs
// Author：duole-15
// Date：2024/12/2
// Des：描述
using System;
namespace C_LeetCode
{
    /*
	 * 118. 杨辉三角
给定一个非负整数 numRows，生成「杨辉三角」的前 numRows 行。在「杨辉三角」中，每个数是它左上方和右上方的数的和。
输入: numRows = 5
输出: [[1],
     [1,1],
    [1,2,1],
   [1,3,3,1],
  [1,4,6,4,1]]
输入: numRows = 1
输出: [[1]]
	 */
    public class _18杨辉三角_动态规划_
	{
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int[][] numbers = new int[numRows][];
            for (int i = 0; i < numRows; i++)
            {
                // 初始化数组 以及首尾的1
                numbers[i] = new int[i + 1];
                numbers[i][0] = 1;
                numbers[i][i] = 1;
            }

            // 只需要填充每一行的中间元素即可
            for (int i = 1; i < numRows; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    numbers[i][j] = numbers[i - 1][j - 1] + numbers[i - 1][j];
                }
            }
            foreach (var array in numbers)
            {
                result.Add(array.ToList());
            }
            return result;
        }

        // 法二：原地算法，避免使用辅助数组
        public IList<IList<int>> Generate1(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                List<int> row = new List<int>(new int[i + 1]);
                row[0] = 1;  // 每行的第一个元素为1
                row[i] = 1;  // 每行的最后一个元素为1

                // 填充中间的元素
                for (int j = 1; j < i; j++)
                {
                    row[j] = result[i - 1][j - 1] + result[i - 1][j];
                }

                result.Add(row);
            }

            return result;
        }
    }

   


}

