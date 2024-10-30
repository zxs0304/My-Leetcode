using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _33搜索旋转排序数组_二分_
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // 检查中间元素是否是目标值
                if (nums[mid] == target)
                {
                    return mid;
                }

                // 判断左半部分是否有序
                if (nums[left] <= nums[mid])
                {
                    // 检查目标值是否在左半部分
                    if (nums[left] <= target && target < nums[mid])
                    {
                        right = mid - 1; // 在左半部分
                    }
                    else
                    {
                        left = mid + 1; // 在右半部分
                    }
                }
                // 右半部分有序
                else
                {
                    // 检查目标值是否在右半部分
                    if (nums[mid] < target && target <= nums[right])
                    {
                        left = mid + 1; // 在右半部分
                    }
                    else
                    {
                        right = mid - 1; // 在左半部分
                    }
                }
            }

            return -1; // 未找到目标值
        }
    }
}
