#include<iostream>
 #include<vector> 
 #include<string>
 #include<map>
 #include<algorithm> 
 using namespace std; 
 /*
 42. 接雨水
给定 n 个非负整数表示每个宽度为 1 的柱子的高度图，计算按此排列的柱子，下雨之后能接多少雨水。
输入：height = [0,1,0,2,1,0,1,3,2,1,2,1]
输出：6
解释：上面是由数组 [0,1,0,2,1,0,1,3,2,1,2,1] 表示的高度图，在这种情况下，可以接 6 个单位的雨水（蓝色部分表示雨水）。 
输入：height = [4,2,0,3,2,5]
输出：9
*/ 
    int trap(vector<int>& height) {
        int n = height.size();
        // left[i]表示 索引为i 的柱子左边的柱子中，最高的柱子高度
        vector<int> left(n,0);
        vector<int> right(n,0);
        // i=0的柱子，它的左边没有柱子，因此初始化为left[0] = 0; 
        left[0] = 0;
        right[n-1] = 0;
        for(int i = 1;i<n;i++)
        {
            left[i] = max(left[i-1] , height[i-1]);
        }
        for(int i = n-2;i>=0;i--)
        {
            right[i] = max(right[i+1] , height[i+1]);
        }

        int result = 0;
        for(int i = 0;i<n;i++)
        {
            if(min(left[i],right[i]) - height[i] > 0)
            {
                result += min(left[i],right[i]) - height[i];
            }
        }
        return result;
    }

int main()
{

}