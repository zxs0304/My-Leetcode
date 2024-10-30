#include<stdio.h>
#include<vector>
using namespace std;
class Solution {
public:
    int climbStairs(int n) 
    {
        vector<int> dp (n+1);
        dp[0] = 0;
        dp[1] = 1;
        for (int i = 2; i <= n; i++) 
        {
            dp[i] = dp[i - 1] + dp[i-2]; //因为两个目的地不同,所以 dp(n−1) 绝对不包含 dp(n−2)，即不重复。
        }
        return dp[n];
    }
};