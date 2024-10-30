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
        vector<bool> dp(l+1,false); // dp[i]��ʾ�ַ���s�е�ǰi���ַ����Ӵ����Ƿ���Դ��ֵ���ƴ�ճ�
        dp[0] = true;
        for (int i = 1; i <= l; i++)
        {
            for (int j = i-1; j >= 0; j--) //j��i-1��ʼ��������ǰ��Ч�ʸ���
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