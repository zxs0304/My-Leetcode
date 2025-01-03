#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
 209. 长度最小的子数组
给定一个含有 n 个正整数的数组和一个正整数 target 。找出该数组中满足其总和大于等于 target 的长度最小的 
子数组[numsl, numsl+1, ..., numsr-1, numsr] ，并返回其长度。如果不存在符合条件的子数组，返回 0 。

输入：target = 7, nums = [2,3,1,2,4,3]
输出：2
解释：子数组 [4,3] 是该条件下的长度最小的子数组。

输入：target = 4, nums = [1,4,4]
输出：1

输入：target = 11, nums = [1,1,1,1,1,1,1,1]
输出：0

*/ 

    //右指针指向的是不在当前窗口中的下一个元素！
    //每一轮循环中，都加入右指针的值，然后开始移动左指针尝试缩小窗口，一直缩小到窗口最小（即窗口内元素小于了target即为最小）
    int minSubArrayLen(int target, vector<int>& nums)
    {
        int curSum = 0;
        int n = nums.size();
        int l = 0;
        int r = 0;
        int minLength = 99999;

        while(r < n)
        {
            curSum += nums[r];
            r++;

            // 此时尝试一直缩小窗口到最小
            while(curSum >= target)
            {
                minLength = min(minLength, r - l ); // 更新最小长度
                curSum -= nums[l];
                l++;
            }

        }
        return minLength == 99999 ? 0 : minLength;
    }


int main()
{

}