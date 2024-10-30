using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _34在排序数组中查找第一个和最后一个位置
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            int last = left - 1;
            left = 0;
            right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] >= target)
                {
                    right = mid - 1;

                }
                else
                {
                    left = mid + 1;
                }
            }
            int first = right + 1;
            if (first > last)
            {
                first = -1;
                last = -1;
            }
            return new int[] { first, last };

        }
    }
}
