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

            if (k == needle.length()) //�������Ϊȫ��ƥ��ɹ����˳�ѭ���ģ�����k == length�����򲻻�
            {
                return i;
            }

        }

        return -1;
    }
};