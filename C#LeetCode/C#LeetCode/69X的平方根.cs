using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _69X的平方根
    {
        public int MySqrt(int x)
        {
            int l = 0;
            int r = x;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (mid * mid == x)
                {
                    return mid;
                }
                else if ((long)mid * mid > x)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return r;
        }
    }
}
