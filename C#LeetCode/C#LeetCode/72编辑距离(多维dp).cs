// FileName：72编辑距离(多维dp).cs
// Author：duole-15
// Date：2024/12/9
// Des：描述
using System;
namespace C_LeetCode
{
    /*72. 编辑距离
给你两个单词 word1 和 word2， 请返回将 word1 转换成 word2 所使用的最少操作数。你可以对一个单词进行如下三种操作：
插入一个字符 删除一个字符 替换一个字符

输入：word1 = "horse", word2 = "ros"
输出：3
解释：
horse -> rorse (将 'h' 替换为 'r')
rorse -> rose (删除 'r')
rose -> ros (删除 'e')

输入：word1 = "intention", word2 = "execution"
输出：5
解释：
intention -> inention (删除 't')
inention -> enention (将 'i' 替换为 'e')
enention -> exention (将 'n' 替换为 'x')
exention -> exection (将 'n' 替换为 'c')
exection -> execution (插入 'u')
	 */

    public class _2编辑距离_多维dp_
	{
        public int MinDistance(string word1, string word2)
        {
            int n1 = word1.Length;
            int n2 = word2.Length;
            int[,] dp = new int[n1+1,n2+1];


            for (int i = 0; i <= n1; i++)
            {
                //当 word2 为空时，将 word1 的前 i 个字符转换为 word2 需要进行 i 次删除，因此 dp[i][0] = i。
                dp[i, 0] = i;
            }
            for (int i = 0; i <= n2; i++)
            {
                //当 word1 为空时，将空字符串转换为 word2 的前 j 个字符需要进行 j 次插入，因此 dp[0][j] = j。
                dp[0, i] = i;
            }
            dp[0, 0] = 0;
            for (int i = 1; i <= n1; i++)
            {
                for (int j = 1; j <= n2; j++)
                {
                    //如果 word1[i - 1] == word2[j - 1]，则 dp[i][j] = dp[i - 1][j - 1]。
                    if (word1[i - 1] == word2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        //否则：
                        //我们用 A = horse，B = ros 作为例子
                        //如果我们知道 horse 到 ro 的编辑距离为 a，那么显然 horse 到 ros 的编辑距离不会超过 a +1。
                        //这是因为我们可以在 a 次操作后将 horse 变为 ro，再需要额外的 1 次操作，在末尾添加字符 s 即可
                        //如果我们知道 hors 到 ros 的编辑距离为 b，那么显然 horse 到 ros 的编辑距离不会超过 b +1。
                        //这是因为我们可以先把horse减去一个e变为hors，然后再通过b次操作，变为ros。
                        //如果我们知道 hors 到 ro 的编辑距离为 c，那么显然 horse 到 ros 的编辑距离不会超过 c +1。
                        //这是因为我们可以在c次操作后将 hors 变为 ro ,再需要额外的 1 次操作，把末尾的e替换成s 即可
                        //那么从 horse 变成 ros 的编辑距离应该为 min(a +1, b + 1, c + 1)。
                        dp[i, j] = Math.Min(dp[i - 1, j - 1] + 1, Math.Min(dp[i - 1, j] + 1, dp[i, j - 1] + 1));
                    }
                }
            }
            return dp[n1, n2];

        }
    }
}

