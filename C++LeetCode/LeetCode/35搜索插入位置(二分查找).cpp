#include<stdio.h>
#include<string>
#include<vector>
#include <iostream>
using namespace std;

class Solution
{
public:
    int searchInsert(vector<int>& nums, int target)
    {
        int l = 0; int r = nums.size(); //lָ���һ��������if������������һ�����ڵ���target����
        while (l <= r)
        {
            int mid = l + (r-l) / 2;
            if (nums[mid] < target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }

        }
        return l;

    }
};