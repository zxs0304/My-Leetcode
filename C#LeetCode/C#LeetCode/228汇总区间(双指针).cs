using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _228汇总区间_双指针_
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            IList<string> result = new List<string>();
            if (nums.Length < 1)
                return result;

            int left = 0;
            for (int right = 1; right <= nums.Length; right++)
            {
                if (nums[right] != nums[right - 1] + 1 )
                {
                    if (right != left + 1)
                    {
                        result.Add($"{nums[left]}->{nums[right - 1]}");
                    }
                    else // right = left + 1
                    {
                        result.Add($"{nums[left]}");
                    }
                    left = right;
                }

            }
            //判断逻辑是只有当遇到不连续的区间时，才会记录下上一个区间的值，因此
            //出来以后，最后一个区间并未统计。此时left指向最后一个区间的起始位置
            if (left == nums.Length - 1) // 只有一个元素
            {
                result.Add($"{nums[left]}");
            }
            else // 有区间
            {
                result.Add($"{nums[left]}->{nums[nums.Length - 1]}");
            }
            return result;
        }
    
    }
}
