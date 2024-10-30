using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _97交错字符串
    {

        public bool IsInterleave(string s1, string s2, string s3)
        {
            int len1 = s1.Length;
            int len2 = s2.Length;
            if (len1+len2 != s3.Length)
            {
                return false;
            }
            //dp[i][j] 表示 s3 的前 i + j 个字符是否可以由 s1 的前 i 个字符和 s2 的前 j 个字符交错组成
            //dp[i][j] 只有在以下条件之一成立时为 true：
            //dp[i - 1][j] 为 true 并且 s1[i - 1] 等于 s3[i + j - 1]。
            //dp[i][j - 1] 为 true 并且 s2[j - 1] 等于 s3[i + j - 1]。
            bool[,] dp = new bool[len1+1,len2+1];
            dp[0,0]= true;

            //先处理 i = 0 和 j = 0的情况 ,这样后续就不用考虑 i-1<0 和 j-1<0的下标越界了
            for (int i = 1;i<= len1;i++)
            {
                dp[i, 0] = dp[i - 1, 0] && s1[i - 1] == s3[i - 1];
            }

            for (int j = 1; j <= len2; j++)
            {
                dp[0, j] = dp[0, j-1] && s2[j - 1] == s3[j - 1];
            }

            for (int i = 1;i<=len1;i++ )
            {
                for (int j = 1;j<=len2;j++)
                {
                    dp[i, j] = 
                        (dp[i - 1, j] && s1[i - 1] == s3[i - 1 + j]) || (dp[i, j - 1] && s2[j - 1] == s3[j - 1 + i]);

                }

            }
            return dp[len1,len2];
        }

    }
}
