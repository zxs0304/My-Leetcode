#include<stdio.h>
#include<string>
#include<vector>
#include <iostream>
using namespace std;

class Solution
{
public:
    vector<int> plusOne(vector<int>& digits)
    {
        int len = digits.size();

        digits[len-1] += 1;
        int i = len-1;
        if (digits[i] == 10)
        {
            while (i >= 0 && digits[i] == 10)
            {
                digits[i] = 0;
                if (i > 0)
                {
                    digits[i - 1] += 1;
                }
                else// i == 0
                {
                    digits[i] = 1;
                    digits.push_back(0);
                }

                i--;
            }
        }


        return digits;
    }
};