using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _438找字符串中的所有异位词_滑动窗口_
    {

        public IList<int> FindAnagrams(string s, string p)
        {
            List<int> result = new List<int>();
            int n = s.Length;
            int m = p.Length;
            if (n < m)
            {
                return new List<int>();
            }
            int[] sCount = new int[26];
            int[] pCount = new int[26];
            for (int i = 0; i < m; ++i)
            {
                sCount[s[i] - 'a']++;
                pCount[p[i] - 'a']++;
            }
            
            if (sCount.SequenceEqual(pCount))
            {
                result.Add(0);
            }
            // i是当前窗口中的第一个元素下标
            // 当 i + m == n-1 时，即表示到达最后一次循环，所以终止条件为 i == n - m - 1
            for (int i = 0; i < n - m; ++i)
            {
                sCount[s[i] - 'a']--;
                sCount[s[i + m] - 'a']++;
                if (sCount.SequenceEqual(pCount))
                {
                    result.Add(i+1);
                }
            }

            return result;
        }

    }
}
