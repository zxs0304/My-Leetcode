#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
 238. 除自身以外数组的乘积
给你一个整数数组 nums，返回 数组 answer ，其中 answer[i] 等于 nums 中除 nums[i] 之外其余各元素的乘积 。
题目数据 保证 数组 nums之中任意元素的全部前缀元素和后缀的乘积都在  32 位 整数范围内。
请 不要使用除法，且在 O(n) 时间复杂度内完成此题。
输入: nums = [1,2,3,4]
输出: [24,12,8,6]
输入: nums = [-1,1,0,-3,3]
输出: [0,0,9,0,0]
*/ 
    vector<int> productExceptSelf(vector<int>& nums) {
        int n = nums.size();
        vector<int> result(n,0);
        // left[i]表示第i个元素左边所有数字的乘积
        vector<int> left(n,0);
        // right[i]表示第i个元素右边所有数字的乘积
        vector<int> right(n,0);
        left[0] = 1;
        right[n-1] = 1;
        for(int i = 1;i<n;i++)
        {
            left[i] = left[i-1] * nums[i-1];
        }

        for(int i = n-2;i>=0;i--)
        {
            right[i] = right[i+1] * nums[i+1];
        }
        for(int i = 0;i<n;i++)
        {
            result[i] = left[i] * right[i];
        }
        return result;
    }

int main()
{

}