using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _53最大子数组和
    {
        public int MaxSubArray(int[] nums)
        {
            int n = nums.Length;
            int[] dp = new int[n];
            dp[0] = nums[0];
            int max = dp[0];
            for (int i = 1; i < n; i++)
            {
                dp[i] = Math.Max( dp[i-1] + nums[i] , nums[i]);
                max = Math.Max( max, dp[i] );
            }
            return max;
        }
    }
}
