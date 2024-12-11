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
                // 检查当前数字是否是一个序列的起点，如果集合包含了当前数字的前一个数字，说明当前数字不是起点
                // 只有当前数字是起点的时候，才会从当前开始计数，求当前的最长连续数字个数
                if (!set.Contains(i-1))
                {
                    int count = 1;
                    int currentNum = i;
                    // 检查下一个数字是否在集合中
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
