// FileName：1143最长公共子序列(多维dp).cs
// Author：duole-15
// Date：2024/12/11
// Des：描述
using System;
namespace C_LeetCode
{
    /*1143. 最长公共子序列
给定两个字符串 text1 和 text2，返回这两个字符串的最长 公共子序列 的长度。如果不存在 公共子序列 ，返回 0 。
一个字符串的 子序列 是指这样一个新的字符串：它是由原字符串在不改变字符的相对顺序的情况下删除某些字符（也可以不删除任何字符）后组成的新字符串。
例如，"ace" 是 "abcde" 的子序列，但 "aec" 不是 "abcde" 的子序列。
两个字符串的 公共子序列 是这两个字符串所共同拥有的子序列。
输入：text1 = "abcde", text2 = "ace" 
输出：3  
解释：最长公共子序列是 "ace" ，它的长度为 3 。
输入：text1 = "abc", text2 = "abc"
输出：3
解释：最长公共子序列是 "abc" ，它的长度为 3 。
输入：text1 = "abc", text2 = "def"
输出：0
解释：两个字符串没有公共子序列，返回 0 。
	 */
    public class _1143最长公共子序列_多维dp_
	{
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int m = text1.Length;
            int n = text2.Length;

            //dp[i][j] 表示 text1 的前 i 个字符和 text2 的前 j 个字符的最长公共子序列的长度。
            //因此dp数组的大小是m+1和n+1
            int[,] dp = new int[m+1, n+1];

            //dp[i, 0] 和 dp[0, j] 初始化为 0，表示任何字符串与空字符串的公共子序列长度为 0。
            for (int i = 0; i <= m; i++)
            {
                dp[i, 0] = 0;
            }
            for (int i = 0; i <= n; i++)
            {
                dp[0, i] = 0;
            }
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    //如果 text1[i-1] == text2[j-1]，这表示当前两个字符可以加入到最长公共子序列中，
                    //因此：dp[i][j] = dp[i - 1][j - 1] + 1
                    if (text1[i-1] == text2[j-1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        //反之如果 text1[i - 1] != text2[j - 1]，这意味着当前两个字符不能同时存在于最长公共子序列中
                        //选dp[i-1][j] :表示舍弃text1[i - 1]，在 text1 的前 i-1 个字符和 text2 的前 j 个字符中找到的最长公共子序列。
                        //选dp[i][j-1] :表示舍弃text2[j - 1]，在 text1 的前 i 个字符和 text2 的前 j-1 个字符中找到的最长公共子序列。
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[m, n];
        }
    }
}

