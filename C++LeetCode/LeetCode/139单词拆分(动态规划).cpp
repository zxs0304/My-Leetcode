#include<stdio.h>
#include<string>
#include<vector>
#include <iostream>
using namespace std;
class Solution
{
public:
    bool wordBreak(string s, vector<string>& wordDict)
    {
        int l = s.length();
        vector<bool> dp(l+1,false); // dp[i]表示字符串s中的前i个字符的子串，是否可以从字典中拼凑出
        dp[0] = true;
        for (int i = 1; i <= l; i++)
        {
            for (int j = i-1; j >= 0; j--) //j从i-1开始，倒着往前，效率更高
            {
                bool has = find(wordDict.begin(), wordDict.end(), s.substr(j, i-j)) != wordDict.end();

                if (dp[j] == true && has)
                {
                    dp[i] = true;
                    break;
                }

            }
        }
        return dp[l];
    }
};

//int main()
//{
//    Solution s;
//    vector<string> strs{ "leet", "code" };
//    s.wordBreak("leetcode", strs);
//}