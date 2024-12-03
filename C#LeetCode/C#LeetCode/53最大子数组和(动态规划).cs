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

        // 法二：由于dp数组只用到了dp[i-1]，因此可以进行空间优化，只用一个变量来存储上一个的最大值，而不需要一整个数组
        public int MaxSubArray1(int[] nums)
        {
            int n = nums.Length;
            int allMax = nums[0];
            int curMax = nums[0];
            for (int i = 1; i < n; i++)
            {
                curMax = Math.Max(curMax + nums[i], nums[i]);
                allMax = Math.Max(allMax, curMax);
            }
            return allMax;
        }
    }
}
