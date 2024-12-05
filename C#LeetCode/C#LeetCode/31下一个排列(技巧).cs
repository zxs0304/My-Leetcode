// FileName：31下一个排列.cs
// Author：duole-15
// Date：2024/12/5
// Des：描述
using System;
namespace C_LeetCode
{
    /*31. 下一个排列
整数数组的一个 排列  就是将其所有成员以序列或线性顺序排列。
例如，arr = [1,2,3] ，以下这些都可以视作 arr 的排列：[1,2,3]、[1,3,2]、[2,1,3]、[2,3,1]、[3,1,2]、[3,2,1] 。
整数数组的 下一个排列 是指其整数的下一个字典序更大的排列。
更正式地，如果数组的所有排列根据其字典顺序从小到大排列在一个容器中，那么数组的 下一个排列 就是在这个有序容器中排在它后面的那个排列。
如果不存在下一个更大的排列，那么这个数组必须重排为字典序最小的排列（即，其元素按升序排列）。
例如，arr = [1,2,3] 的下一个排列是 [1,3,2] 。类似地，arr = [2,3,1] 的下一个排列是 [3,1,2] 。
而 arr = [3,2,1] 的下一个排列是 [1,2,3] ，因为 [3,2,1] 不存在一个字典序更大的排列。
给你一个整数数组 nums ，找出 nums 的下一个排列。必须 原地 修改，只允许使用额外常数空间。
	 */
    public class _1下一个排列
	{
        // 1.从后向前找到第一个降序的元素：找到第一个 i，使得 nums[i] < nums[i + 1]。如果找不到这样的 i，说明 nums 是降序排列的，直接将其反转成升序排列。
        // 2.找到比 nums[i] 大的最小的元素：从后向前找到第一个 j，使得 nums[j] > nums[i]。
        // 3.交换 nums[i] 和 nums[j]：将这两个元素交换。
        // 4.反转 i + 1 到数组末尾的部分：将 i + 1 到末尾的部分反转，以得到下一个排列。
        public void NextPermutation(int[] nums)
        {
            int n = nums.Length;

            int i = n - 2;
            while (i >= 0 && nums[i] >= nums[i+1])
            {
                i--;
            }

            //如果 i < 0，说明 nums 是降序排列的，直接将其反转成升序排列。
            if (i>=0)
            {
                int j = n - 1;
                while (j >= 0 && nums[j] <= nums[i])
                {
                    j--;
                }
                Swap(nums, i, j);
            }

            Array.Reverse(nums,i+1,n-i-1);
        }

        public void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}

