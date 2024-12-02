// FileName：279完全平方数(dp).cs
// Author：duole-15
// Date：2024/12/2
// Des：描述
using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace C_LeetCode
{
    /*279. 完全平方数
给你一个整数 n ，返回 和为 n 的完全平方数的最少数量 。
完全平方数 是一个整数，其值等于另一个整数的平方；换句话说，其值等于一个整数自乘的积。例如，1、4、9 和 16 都是完全平方数，而 3 和 11 不是。
输入：n = 12
输出：3 
解释：12 = 4 + 4 + 4
输入：n = 13
输出：2
解释：13 = 4 + 9
	 */
    public class _279完全平方数_dp_
	{
        // 类似322.零钱兑换
        public int NumSquares(int n)
        {
            // dp[i]表示组成 i 所需要的完全平方数的最小数量
            int[] dp = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                dp[i] = n + 1; // 初始化为一个较大的数

                // 遍历所有小于 i 的完全平方数
                for (int j = 1; j * j <= i; j++)
                {
                    int square = j * j;
                    dp[i] = Math.Min(dp[i], dp[i - square] + 1);
                }
            }
            return dp[n];

        }

        // 332.零钱兑换
        public int CoinChange(int[] coins, int amount)
        {
            int n = coins.Length;
            int[] dp = new int[amount + 1];
            for (int i = 1; i <= amount; i++)
            {
                // 不能定义为int.MaxValue，因为后面的 +1 可能会溢出
                dp[i] = short.MaxValue;
                for (int j = 0; j < n; j++)
                {
                    if (coins[j] <= i)
                    {
                        dp[i] = Math.Min(dp[i] , dp[i - coins[j]] + 1);
                    }
                }
            }
            return dp[amount] == short.MaxValue ? -1 : dp[amount];
        }

    }
}

