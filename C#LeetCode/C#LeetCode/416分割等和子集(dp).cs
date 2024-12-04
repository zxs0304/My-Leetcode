// FileName：416分割等和子集.cs
// Author：duole-15
// Date：2024/12/4
// Des：描述
using System;
namespace C_LeetCode
{
    /*416. 分割等和子集
给你一个 只包含正整数 的 非空数组 nums 。请你判断是否可以将这个数组分割成两个子集，使得两个子集的元素和相等。
输入：nums = [1,5,11,5]
输出：true
解释：数组可以分割成 [1, 5, 5] 和 [11] 。
输入：nums = [1,2,3,5]
输出：false
解释：数组不能分割成两个元素和相等的子集。
	 */
    public class _416分割等和子集
	{
        public bool CanPartition(int[] nums)
        {
            int sum = nums.Sum();
            // 若总和为奇数，那么直接返回false
            if (sum % 2 != 0)
            {
                return false;
            }
            int target = sum / 2;

            // dp[i] 表示是否可以找到一个子集，其元素和为 i
            // 若能找到这样一个子集，那么剩余元素自动组成另一个子集
            bool[] dp = new bool[target + 1];
            dp[0] = true;

            // 对于数组中的每一位数字，判断是否能够用其组成target
            // 因为一个数字只能用一次，因此是 外层遍历数组，内层遍历target，
            foreach (var number in nums)
            {
                // !!!要让target从大到小来遍历，因为如果从小到大可能会导致一个数字用两次来组成target
                // 且要保证 target至少要大于number才有可能由number组成
                for (int i = target; i >= number; i--)
                {
                    dp[i] = dp[i] || dp[i - number];
                }
            }

            return dp[target];
        }
    }
}

