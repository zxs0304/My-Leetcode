#include<stdio.h>
#include<string>
using namespace std;
class Solution {
public:
    int strStr(string haystack, string needle) 
    {
        if (haystack.length() < needle.length())
            return -1;
        for (int i = 0; i < haystack.length(); i++) 
        {
            int k = 0;
            while (k < needle.length()) 
            {

                if (haystack[i+k] == needle[k]) 
                {
                    k++;
                }
                else 
                {
                    break;
                }
            }

            if (k == needle.length()) //如果是因为全部匹配成功后退出循环的，会有k == length，否则不会
            {
                return i;
            }

        }

        return -1;
    }
};