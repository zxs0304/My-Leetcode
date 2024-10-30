using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _45跳跃游戏II_贪心_
    {

        public int Jump(int[] nums)
        {
            int n = nums.Length;
            int step = 0;
            int maxDistance = 0;
            int curEnd = 0;
            for (int i = 0; i<n-1;i++ )
            {
                maxDistance = Math.Max(maxDistance, i + nums[i]);

                if (i == curEnd)
                {
                    step++;
                    curEnd = maxDistance;
                    if (maxDistance >= n-1)
                    {
                        break;
                    }

                }

            }

            return step;
        }

    }
}
