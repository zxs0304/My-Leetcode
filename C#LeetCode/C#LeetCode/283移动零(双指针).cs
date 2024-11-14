using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _283移动零_双指针_
    {
        public void MoveZeroes(int[] nums)
        {
            int n = nums.Length;
            int left = 0;
            int right = 0;
            while (right < n) 
            {
                if (nums[right] != 0)
                {
                    nums[left] = nums[right];
                    left++;
                }
                right++;
            }

            while (left < n)
            {
                nums[left] = 0;
                left++;
            }

        }
    }
}
