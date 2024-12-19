#include<iostream>
#include<vector>
using namespace std;  
    /*
169. 多数元素
给定一个大小为 n 的数组 nums ，返回其中的多数元素。多数元素是指在数组中出现次数 大于 ⌊ n/2 ⌋ 的元素。
你可以假设数组是非空的，并且给定的数组总是存在多数元素。
    */
    // 如果求大于等于 n/2的元素，不可用摩尔投票法！！！
    int majorityElement(vector<int>& nums) {
        int n = nums.size();
        int count = 0;
        int curNumber = 0;
        for(int i = 0;i<n;i++)
        {
            // count表示的是从0到i , curNumber比别的数字多出来的个数
            // 先判断count == 0，再 进行 count的加减
            if(count == 0)
            {
                curNumber = nums[i];
            }
            if(nums[i] == curNumber)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        return curNumber;
    }