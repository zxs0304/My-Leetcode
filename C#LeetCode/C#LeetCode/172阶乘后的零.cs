using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _172阶乘后的零
    {
        public int TrailingZeroes(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                int cur = i;
                while (cur > 0)
                {
                    if (cur % 5 == 0)
                    {
                        count++;
                        cur /= 5;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return count;
        }
    }
}
