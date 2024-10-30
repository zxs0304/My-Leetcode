#include<stdio.h>
#include<string>
#include<vector>
#include <iostream>
using namespace std;

class Solution
{
public:
    int search(vector<int>& nums, int target)
    {
        int len = nums.size();
        int l = 0;
        int r = len - 1;
        
        while (l<=r)
        {
            int pos = (l + r) / 2;
            if (nums[pos] < target)
            {
                l = pos + 1;
            }
            else if (nums[pos] > target)
            {
                r = pos - 1;
            }
            else
            {
                return pos;
            }

        }
        return -1;

    }
};