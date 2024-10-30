using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _300最长递增子序列
    {
        public int lengthOfLIS(int[] nums)
        {
            int n = nums.Length;
            int[] dp = new int[n];
            int max = 1; //max初始值为1 !!!
            // 初始化 dp 数组，每个元素的初始值为 1      ！
            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
            }

            for ( int i = 1;i<n;i++)
            {
                for (int j = i-1;j >=0;j--)
                {
                    if (nums[i] > nums[j] )
                    {
                        dp[i] = Math.Max(dp[i] , dp[j]+1);

                    }
                }
                if (dp[i] > max)
                {
                    max = dp[i];
                }
            }


            return max;
        }
    }
}
