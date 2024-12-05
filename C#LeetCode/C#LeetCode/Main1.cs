using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{

    class Student
    {


        public static void Main(string[] args)
        {
            _152乘积最大的子数组_dp_ t = new _152乘积最大的子数组_dp_();

            var result = t.MaxProduct1(new int[] {-4 ,-3,-2});
            Console.WriteLine(result);
        }

        public int Rob(int[] nums)
        {
            int n = nums.Length;
            int[] dp = new int[n+1];
            dp[0] = nums[0];

            for (int i = 1;i<n;i++)
            {
                if (i == 1)
                {
                    dp[1] = Math.Max(dp[0], 0 + nums[1]);
                }
                else
                {
                    dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
                }

            }

        }

    }
}
