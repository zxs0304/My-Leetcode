#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
*/ 
    int maxProfit(vector<int>& prices) 
    {
        int n = prices.size();
        // 尤其注意初始条件，应该从第一天开始，而不是第一天之前，因此初始化dp的长度为n
        vector<vector<int>> dp(n, vector<int>(2, INT_MIN)); // 初始化为 INT_MIN
        // 因为第一天之前不可能持有股票，最早也要从第一天开始才有可能持有股票，因此初始条件就是第一天的状态
        dp[0][0] = 0;
        dp[0][1] = -prices[0];
        for(int i = 1;i<n;i++)
        {
            dp[i][0] = max(dp[i-1][1] + prices[i] , dp[i-1][0]);
            dp[i][1] = max(dp[i-1][0] - prices[i] , dp[i-1][1]);
        }
        return dp[n-1][0];
    }