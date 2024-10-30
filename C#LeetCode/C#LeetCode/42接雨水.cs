using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _42接雨水
    {
        public int Trap(int[] height)
        {
            int n = height.Length;
            int[] leftMax = new int[n];//表示当前位置左边（包括当前位置）的最大柱子高度
            int[] rightMax = new int[n];
            leftMax[0] = height[0];
            rightMax[n-1] = height[n-1];
            int sum = 0;
            for (int i = 1;i<n;i++)
            {
                leftMax[i] = Math.Max(leftMax[i-1] , height[i]);

            }
            for (int j = n-2; j >= 0; j--)
            {
                rightMax[j] = Math.Max(rightMax[j + 1], height[j]);

            }
            for (int k = 1;k<n-1;k++)
            {
                sum += Math.Min(leftMax[k], rightMax[k]) - height[k];
            }
            return sum;
        }
    }
}
