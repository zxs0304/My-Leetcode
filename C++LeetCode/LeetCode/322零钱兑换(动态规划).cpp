#include<stdio.h>
#include<string>
#include<vector>
#include <iostream>
using namespace std;

class Solution
{
public:
    int coinChange(vector<int>& coins, int amount)
    {
        int l = coins.size();
        vector<int> dp (amount + 1,99999); //dp[i]表示 兑i元钱所需要的最少的硬币数
        dp[0] = 0;
        for (int i = 1; i <= amount; i++)
        {
            int min = 99999; //min是为了选出dp[i - coins[j]]中最小的一个
            for (int j = 0; j < l; j++)
            {
                if (i >= coins[j] && dp[i-coins[j]] < min)
                {
                    min = dp[i - coins[j]]+1;
                }
            }
            dp[i] = dp[min];

        }
        return dp[amount] == 99999 ? -1 : dp[amount];

    }
};

