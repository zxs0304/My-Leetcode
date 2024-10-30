#include<stdio.h>
#include<string>
#include<vector>
#include <iostream>
using namespace std;

class Solution {
public:
    int lengthOfLIS(vector<int>& nums) {
        int l = nums.size();
        vector<int> dp(l,1);
        dp[0] = 1;
        for (int i = 1;i < l;i++) 
        {
            for (int j = i - 1;j >= 0;j--) 
            {
                if (nums[i] > nums[j]) 
                {
                    dp[i] = max(dp[i], dp[j] + 1);
                }
            }
        }

        for (int i = 0;i < dp.size();i++)
        {
            cout << "dp[" << i << "] = " << dp[i] << endl;
        }

        return *max_element(dp.begin(), dp.end());
    }
};

//int main()
//{
//    Solution s;
//    vector<int> nums{10,9,2,5,3,7,101,18};
//    s.lengthOfLIS(nums);
//}