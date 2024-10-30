using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _452用最少数量的箭引爆气球_区间_
    {
        private const int V = 2147483647;

        public int FindMinArrowShots(int[][] points)
        {
            int sum = 1;
            int n = points.Length;
            Array.Sort(points, (a,b) =>  a[0] < b[0] ? -1 : 1 );
            int i = 1;
            int[] current = points[0];
            while (i < n)
            {
                while (i < n && current[1] >= points[i][0])
                {
                    //由于两个气球都要扎爆，所以要取end的最小值，与之前合并区间不一样
                    current[1] = Math.Min(current[1], points[i][1]);
                    i++;
                }
                if (i<n)
                {
                    sum++;
                    current = points[i];
                    i++;
                }

            }

            return sum;
           
        }

    }
}
