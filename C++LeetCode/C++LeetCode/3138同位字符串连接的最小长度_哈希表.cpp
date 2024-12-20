#include<iostream>
 #include<vector> 
 #include<string> 
#include<map> 
#include<algorithm>
 using namespace std; 

/*
3138. 同位字符串连接的最小长度
给你一个字符串 s ，它由某个字符串 t 和若干 t  的 同位字符串 连接而成。请你返回字符串 t 的 最小 可能长度。
同位字符串 指的是重新排列一个单词得到的另外一个字符串，原来字符串中的每个字符在新字符串中都恰好只使用一次。

输入：s = "abba"
输出：2
一个可能的字符串 t 为 "ba" 。

输入：s = "cdef"
输出：4
一个可能的字符串 t 为 "cdef" ，注意 t 可能等于 s 。
 */


// 光统计每种字符个数，然后求最小公因数是不可行的，因为aabb这种无法通过ab来组合。因此需要枚举不同长度的子串
// 字符串 t 的长度一定为字符串 s 的长度 n 的因数，因此可以从小到大枚举 n 的因数作为 t 的长度。
// 假设将字符串 s 切分为若干段长度为 i 的子字符串，然后比较，如果每一段字符串的字符个数都一样时，即为答案
    int minAnagramLength(string s) 
    {
        int n = s.size();
        for(int i = 1;i<=n;i++)
        {
            if(n % i == 0)
            {
                if(check(s,i))
                {
                    return i ;
                }
            }
        }
        return n;
    }
    bool check(string s,int t)
    {

        vector<int> chars1(26,0);
        vector<int> chars2(26,0);
        //统计第一段中每个字符的出现次数
        for(int i = 0; i < t; i++)   
        {
            chars1[s[i] - 'a']++;
        }
        // 保证后续每一段的字符个数都与第一段相同
        int index = t;
        while(index < s.size())
        {
            fill(chars2.begin(), chars2.end(), 0);
            for(int i = 0; i < t; i++)
            {
               chars2[s[index + i] - 'a']++;
            }
    
            if(chars2 != chars1)
            {
                return false;
            }
            index += t;
        }
        return true ;
    }