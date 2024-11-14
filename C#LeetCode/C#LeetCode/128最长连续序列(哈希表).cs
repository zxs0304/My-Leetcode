using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _128最长连续序列_哈希表_
    {
        public int LongestConsecutive(int[] nums)
        {
            int result = 0;
            HashSet<int> set = new HashSet<int>(nums);
            foreach (int i in set)
            {
                if (!set.Contains(i-1))
                {
                    int count = 1;
                    int currentNum = i;
                    while (set.Contains(currentNum + 1))
                    {
                        count++;
                        currentNum++;
                    }
                    result = Math.Max(result, count);
                }
            }
            return result;
        }

    }
}
