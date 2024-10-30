#include<stdio.h>
#include<string>
#include<vector>
#include <iostream>
using namespace std;

class Solution
{
public:
    vector<string> static letterCombinations(string digits)
    {
        vector<string> myStrs;
        if (digits == "")
        {
            return myStrs;
        }
        string currentStr;
        int len = digits.length();

        vector<string> map{" ",  //0
            "",     //1
            "abc",  //2
            "def",  //3
            "ghi",  //4
            "jkl",  //5
            "mno",  //6
            "pqrs", //7
            "tuv",  //8
            "wxyz"  //9
        };

        digui(digits, 0, currentStr, myStrs, map);
        return myStrs;
    }

    void static digui(string& digits, int i, string& currentStr, vector<string>& myStrs, vector<string>& map)
    {

        if (i == digits.length())
        {            
            myStrs.push_back(currentStr);
            return;
        }
        else
        {
            int number = digits[i] - '0';
            for (int j = 0; j < map[number].length(); j++)
            {
                currentStr.push_back(map[number][j]);
                digui(digits, i + 1, currentStr, myStrs, map);
                currentStr.pop_back();//回溯，必须删除最后一个字符。
            }
        }
    }
};

//int main()
//{
//    Solution::letterCombinations("23");
//}