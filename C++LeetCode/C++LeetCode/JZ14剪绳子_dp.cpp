#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
 给你一根长度为 n 的绳子，请把绳子剪成整数长的 m 段（ m 、 n 都是整数， n > 1 并且 m > 1 ， m <= n ），每段绳子的长度记为 k[1],...,k[m] 。
 请问 k[1]*k[2]*...*k[m] 可能的最大乘积是多少？例如，当绳子的长度是 8 时，我们把它剪成长度分别为 2、3、3 的三段，此时得到的最大乘积是 18 。
*/ 

    int cutRope(int n) 
    {
        vector<int> dp(n+1,0);
        dp[0] = 1;
        dp[1] = 1;
        dp[2] = 1;
        for(int i = 3;i<=n;i++)
        {
            //首先将i 分为两段长度： j 和 i-j
            //计算 j 是否还能继续分解为更多段，进而获得更大的乘积
            //计算 i-j 是否还能继续分解为更多段，进而获得更大的乘积
            //最后将两部分的最大相乘
            for(int j = 1; j <= i/2 ;j++)
            {
                int part1 = max(j , dp[j]);
                int part2 = max(i-j , dp[i-j]);
                dp[i] = max(dp[i] , part1 * part2);
            }
        }
        return dp[n];
    }

int main()
{

}