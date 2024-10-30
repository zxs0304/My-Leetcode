using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _274H指数
    {
        public int HIndex(int[] citations)
        {
            int n = citations.Length;
            Array.Sort(citations);
            int h = 0;
            for (int i = n-1; i>=0;i--)
            {

                if (h < citations[i])
                {
                    h++;
                }

            }
            return h ;
        }

    }
}
