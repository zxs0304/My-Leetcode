using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _560和为K的子数组_子串_
    {
        /*
         * 由于数组有正有负，不能使用滑动窗口来判断（因为并不是元素越多，和越大）。
         * 使用一个变量 curSum 来记录当前元素的前缀和。
           使用一个哈希表 dic 来记录每个前缀和出现的次数。初始化时，dic[0] = 1，表示前缀和0出现1一次。
           遍历数组：对于每个元素，更新 curSum，然后检查 curSum - k 是否存在于哈希表中。
           如果存在，说明从前缀和为 curSum - k的元素 到 当前元素的子数组和为 k，增加计数。
           更新哈希表
         * 
         */
        public int SubarraySum(int[] nums, int k)
        {
            int curSum = 0;
            int result = 0;
            Dictionary<int,int> dic = new Dictionary<int,int>();
            dic[0] = 1; //等同于dic.Add(0,1)
            for (int i = 0;i< nums.Length;i++)
            {
                curSum += nums[i];
                int targetSum = curSum - k;
                if (dic.ContainsKey(targetSum))
                {
                    result += dic[targetSum];
                }

                //更新字典
                if (dic.ContainsKey(curSum))
                {
                    dic[curSum]++;

                }
                else
                {
                    dic[curSum] = 1;
                }

            }

            return result;
        }

    }
}
