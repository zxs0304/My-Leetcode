// FileName：41缺失的第一个正数.cs
// Author：duole-15
// Date：2024/11/21
// Des：描述
using System;
namespace C_LeetCode
{
    /*给你一个未排序的整数数组 nums ，请你找出其中没有出现的最小的正整数。

请你实现时间复杂度为 O(n) 并且只使用常数级别额外空间的解决方案。
示例 1：
输入：nums = [1,2,0]
输出：3
解释：范围 [1,2] 中的数字都在数组中。
示例 2：
输入：nums = [3,4,-1,1]
输出：2
解释：1 在数组中，但 2 没有。
示例 3：
输入：nums = [7,8,9,11,12]
输出：1
解释：最小的正数 1 没有出现。
	 */
    public class _41缺失的第一个正数
	{
        public int FirstMissingPositive(int[] nums)
        {
            int n = nums.Length;
            int i = 0;
            while (i < n)
            {
               // 如果当前数字 nums[i] 符合 1 ~ n 的区间 (那么表示nums[i]应该放在下标为 nums[i]-1 的位置上)
               // 若当前下标为 nums[i] -1 的位置上的数字，并不是nums[i] 
                if (nums[i] > 0 && nums[i] <= n && nums[i] != nums[nums[i] -1])
                {
                    // 那么此时就把 nums[i] 放到下标为 nums[i] - 1 的位置上
                    Swap(nums, i, nums[i] - 1);
                }
                else // 因为换到当前位置的新数字可能仍然需要再次换到它应该在的位置，所以，不能直接i++,要再次判断一次,在else里i++
                {
                    i++;
                }
            }

            for (i = 0;i<n;i++)
            {
                if (i != nums[i] - 1)
                {
                    return i + 1;
                }
            }
            return n+1;
        }

        public void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

    }
}

