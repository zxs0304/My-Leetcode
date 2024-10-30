using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _740删除并获得点数_dp_
    {
        public int DeleteAndEarn(int[] nums)
        {
            int n = nums.Length;
            // 统计每个数字的出现次数
            Dictionary<int, int> count = new Dictionary<int, int>(); // count记录数组中每个数的出现次数
            foreach (var num in nums)
            {
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count[num] = 1;
                }
            }
            // 找到最大值
            int maxNum = 0;
            foreach (var key in count.Keys)
            {
                if (key > maxNum)
                {
                    maxNum = key;
                }
            }

            //如果我们选择了 i，那么 i-1 和 i+1 的所有元素都会消失。此时，dp[i] = i * count[i] + dp[i-2]。
            //如果我们不选择 i，那么 dp[i] = dp[i - 1]。
            int[] dp = new int[maxNum + 1]; //dp[i]表示 ，从0 ~ dp[i] 这些数中，能获取到的最大sum
            int sum = 0;
            dp[0] = 0;
            if (count.ContainsKey(1))
            {
                dp[1] = 1 * count[1];
            }
            else
            {
                dp[1] = dp[0];
            }
            for (int i = 2;i<n;i++)
            {
                if (count.ContainsKey(nums[i]))
                {
                    dp[i] = Math.Max(dp[i - 1], dp[i - 2] + i * count[i]);
                }
                else//如果压根没有数字dp[i] ，那么dp[i]不可能被选，因此dp[i] = dp[i-1]
                {
                    dp[i] = dp[i - 1];
                }
            }
            return dp[maxNum];

        }

    }
}
