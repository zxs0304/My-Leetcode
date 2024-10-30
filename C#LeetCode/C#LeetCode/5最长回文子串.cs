using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _5最长回文子串
    {
        public string LongestPalindrome(string s)
        {
            int n = s.Length;
            int start = 0;
            int maxLength = 1;
            bool[,] dp = new bool[n, n]; //dp[i][j] = true 表示从i 到 j的子串是回文的

            for (int i = 0; i < n; i++)     // 所有单个字符都是回文
            {
                dp[i,i] = true;
            }

            for (int r = 1; r < n; r++)
            {

                for (int l = 0; l < r; l++) 
                {
                    if (s[l] == s[r])
                    {                               //状态转移： 字符l == 字符r 且 从l+1到r-1又是回文串 ,那么l到r一定是回文串
                        if ( r-l==1 || dp[l+1,r-1]) //当相邻的两个字符相同时，此时也是回文串 如"bb"
                        {
                            dp[l, r] = true;
                            if (r - l + 1 > maxLength)
                            {
                                maxLength = r - l + 1;
                                start = l;
                            }

                        }

                    }

                }

            }

            return s.Substring(start, maxLength);


        }

    }
}
