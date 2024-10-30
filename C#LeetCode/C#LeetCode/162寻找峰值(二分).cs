using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _162寻找峰值_二分_
    {
        public int FindPeakElement(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    right = mid;
                }
                else if (nums[mid] < nums[mid + 1])
                {
                    left = mid + 1 ;
                }
            }
            return left;
        }



    }
}
