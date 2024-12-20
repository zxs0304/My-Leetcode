#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
 189. 轮转数组
给定一个整数数组 nums，将数组中的元素向右轮转 k 个位置，其中 k 是非负数。
*/ 
    void rotate(vector<int>& nums, int k) 
    {
        vector<int> nums2(nums);
        for(int i = 0;i<nums.size();i++)
        {
            nums[(i+k)%nums.size()] = nums2[i];
        }
    }

    // 先翻转全部，再翻转前k个，再翻转后n-k个
    void rotate2(vector<int>& nums, int k) 
    {
        k%=nums.size();
        reverse(nums.begin(),nums.end());
        reverse(nums.begin(),nums.begin()+k);
        reverse(nums.begin()+k,nums.end());
    }