#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
 给你一个整数数组 nums ，判断是否存在三元组 [nums[i], nums[j], nums[k]] 满足 i != j、i != k 且 j != k ，同时还满足 nums[i] + nums[j] + nums[k] == 0 。
 请你返回所有和为 0 且不重复的三元组。注意：答案中不可以包含重复的三元组。

输入：nums = [-1,0,1,2,-1,-4]
输出：[[-1,-1,2],[-1,0,1]]
解释：
nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0 。
nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0 。
nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0 。
不同的三元组是 [-1,0,1] 和 [-1,-1,2] 。
注意，输出的顺序和三元组的顺序并不重要。

输入：nums = [0,1,1]
输出：[]
解释：唯一可能的三元组和不为 0 。

输入：nums = [0,0,0]
输出：[[0,0,0]]
解释：唯一可能的三元组和为 0 。
 
*/ 
 
     
    // 大体思路和167.两数之和一样，先排序，然后定一个数k ,从i后面通过双指针i和j来找到 target
    // 但是尤其注意这题不包含重复的三元组，因此需要尤其注意边界修改的条件,
    // !!! 左边界不能只++一次，要一直加到不等于上一个数 , 右边界不能只-- 一次，要一直减到不等于上一个数
    vector<vector<int>> threeSum(vector<int>& nums) 
    {
        int n = nums.size();
        sort(nums.begin(),nums.end());
        vector<vector<int>> result;
        for(int k = 0 ; k < n - 2 ; k++ )
        {
            if(nums[k] > 0 )
            {
                break;
            }
            // 如果当前的i 和上一个i一样，那么直接continue
            if(k > 0 && nums[k] == nums[k - 1])
            {
                continue;
            }
            int target = -nums[k];
            int i = k+1;
            int j = n-1;
            while (i < j)
            {
                // 如果等于target，此时l和r都要++ 和 -- ， i不能只++一次，要一直加到不等于上一个数
                if(nums[i] + nums[j] == target)
                {
                    result.push_back(vector<int>{nums[k],nums[i],nums[j]});
                    while(i < j && nums[i] == nums[++i]);
                    while(i < j && nums[j] == nums[--j]);
                }
                else if(nums[i] + nums[j] < target) // 如果小于target，此时只需要i++, i不能只++一次，要一直加到不等于上一个数
                {
                    while(i < j && nums[i] == nums[++i]);
                }
                else
                {
                    while(i < j && nums[j] == nums[--j]);
                }
            }
        }
        return result;
    }

int main()
{

}