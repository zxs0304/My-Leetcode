// FileName：152乘积最大的子数组(dp).cs
// Author：duole-15
// Date：2024/12/3
// Des：描述
using System;
namespace C_LeetCode
{
    /*
	 * 152. 乘积最大子数组
给你一个整数数组 nums ，请你找出数组中乘积最大的非空连续 子数组（该子数组中至少包含一个数字），并返回该子数组所对应的乘积。测试用例的答案是一个 32-位 整数。
输入: nums = [2,3,-2,4]
输出: 6
解释: 子数组 [2,3] 有最大乘积 6。
输入: nums = [-2,0,-1]
输出: 0
解释: 结果不能为 2, 因为 [-2,-1] 不是子数组。
	 */
    public class _152乘积最大的子数组_dp_
    {
        // 类似53.最大子数组和
        // 不同的是，在本题中，不仅维护一个最大值dp数组。由于负数的特性，还需要维护一个最小值dp数组
        // 主要是因为，如果我们在当前遇到了负数，最大乘积可能来自于先前的最小乘积（即负数），与当前的负数相乘后变为正数。
        public int MaxProduct(int[] nums)
        {
            int n = nums.Length;
            // dpMax[i] 表示到i为止，当前的最大乘积
            int[] dpMax  = new int[n];
            // dpMin[i] 表示到i为止，当前的最小乘积
            int[] dpMin = new int[n];
            int max = nums[0];
            dpMax[0] = nums[0];
            dpMin[0] = nums[0];
            for (int i = 1; i < n; i++)
            {
                // 由于当前数可能是负数，因此，到当前数的最大乘积，可能是从前一个数的最小乘积转变来的，因此要比较 三者的最大值
                // dpMax[i] = Max( nums[i] , dpMax[i - 1] * nums[i] , dpMin[i - 1] * nums[i] )
                dpMax[i] = Math.Max(nums[i], Math.Max(dpMax[i - 1] * nums[i], dpMin[i - 1] * nums[i]));
                // 同理，比较三者的最小值
                dpMin[i] = Math.Min(nums[i], Math.Min(dpMax[i - 1] * nums[i], dpMin[i - 1] * nums[i]));
                // 更新全局最大值
                max = Math.Max(max, dpMax[i]);
            }
            return max;
        }

        // 法二：由于dp数组只用到了dp[i-1]，因此可以进行空间优化，只用一个变量来存储上一个的最大值，而不需要一整个数组
        public int MaxProduct1(int[] nums)
        {
            int n = nums.Length;
            // curMax表示到前一个数的最大乘积
            int curMax = nums[0];
            // curMin表示到前一个数的最小乘积
            int curMin = nums[0];
            int max = nums[0];
            for (int i = 1; i < n; i++)
            {
                curMax = Math.Max(nums[i], Math.Max(curMax * nums[i], curMin * nums[i]));
                curMin = Math.Min(nums[i], Math.Min(curMax * nums[i], curMin * nums[i]));
                max = Math.Max(max, curMax);
            }
            return max;
        }


    }
}

