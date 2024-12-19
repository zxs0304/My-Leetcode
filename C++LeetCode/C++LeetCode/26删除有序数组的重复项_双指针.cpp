#include<iostream>
#include<vector>
using namespace std;

    // 左指针left维护当前满足条件的数字，右指针right向右遍历新数字
    // !!!!left的位置才是当前要写入的位置，因此， nums[right]应该与nums[left - 1]相比较，而不是和nums[right - 1]相比较！！
    int removeDuplicates(vector<int>& nums) 
    {
        int left = 1;
        int right = 1;
        int n = nums.size();
        while(right < n)
        {
            // !!!!left的位置才是当前要写入的位置，因此， nums[right]应该与nums[left - 1]相比较，而不是和nums[right - 1]相比较！！
            if(nums[right] != nums[left - 1])
            {
                nums[left] = nums[right];
                left++;
            }
            right++;
        }
        return left;
    }

    //80.删除有序数组中的重复项II
    // 左指针left维护当前满足条件的数字，右指针right向右遍历新数字
    int removeDuplicates2(vector<int>& nums) {
        int left = 2;
        int right = 2;
        int n = nums.size();
        if( n < 2)
        {
            return n;
        }
        while(right < n)
        {
            // !!!!! left的位置才是当前要写入的位置，因此， nums[right]应该与nums[left - 2]相比较，而不是和nums[right - 2]相比较
            if(nums[right] != nums[left - 2])
            {
                nums[left] = nums[right];
                left++;
            }
            right++;

        }
        return left;
    }