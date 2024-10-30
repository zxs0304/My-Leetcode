using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    //给你一个 非空 整数数组 nums ，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。
    internal class _136只出现一次的数字_异或_
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (int i in nums)
            {
                result = result ^ i;
            }
            return result;
        }

        // 对于有序数组中的单一元素一定出现在偶数下标上(其余数字都出现两次)
        public int SingleNumber2(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }
            return nums[nums.Length - 1];
        }
    }
}
